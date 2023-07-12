using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_HQTCSDL
{
    public partial class QuanLySach_TacGia : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        SqlCommand cauLenh;
        DataTable bangDuLieu;

        private bool truyCapDGV = true;
        public QuanLySach_TacGia()
        {
            InitializeComponent();
        }

        // Tải dữ liệu bảng cho dgv
        private void TaiDuLieu(string s = "select maTG [Mã tác giả], tenTG [Tên tác giả] from TacGia")
        {
            ketNoi.Open();
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            ketNoi.Close();

            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Xoá hết dữ liệu trong vùng nhập
        private void LamSachDuLieu()
        {
            txt_maTacGia.Clear();
            txt_tenTacGia.Clear();
        }

        // Ràng buộc nút
        private void RangBuocNut(bool them, bool xoa, bool chinhSua, bool luu, bool khongLuu)
        {
            if (them) btn_them.Enabled = true;
            else btn_them.Enabled = false;

            if (xoa) btn_xoa.Enabled = true;
            else btn_xoa.Enabled = false;

            if (chinhSua) btn_chinhSua.Enabled = true;
            else btn_chinhSua.Enabled = false;

            if (luu) btn_luu.Enabled = true;
            else btn_luu.Enabled = false;

            if (khongLuu) btn_khongLuu.Enabled = true;
            else btn_khongLuu.Enabled = false;
        }

        // Khoá truy cập
        private void KhoaTruycap(bool k = true)
        {
            if (k == true)
            {
                truyCapDGV = true;
                txt_tenTacGia.Enabled = false;
            }
            else
            {
                truyCapDGV = false;
                txt_tenTacGia.Enabled = true;
            }
        }

        // Lấy mã tác giả kế tiếp
        private string LayMaTiepTheo()
        {
            int i = dgv.RowCount - 2;
            if (i < 0) return "TG001";
            string ma = dgv.Rows[i].Cells[0].Value.ToString();
            int so = Convert.ToInt32(ma.Substring(2, 3)) + 1;

            string t = "";
            if (so < 10) t = t + "00" + so;
            else if (so < 100) t = t + '0' + so;
            else t = t + so;

            ma = ma.Substring(0, 2) + t;
            return ma;
        }

        private void QuanLySach_TacGia_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            KhoaTruycap();
            RangBuocNut(true, false, false, false, false);
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (truyCapDGV == false) return;
            int i = dgv.CurrentRow.Index;
            if (i == dgv.RowCount-1)
            {
                LamSachDuLieu();
                return;
            }

            txt_maTacGia.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_tenTacGia.Text = dgv.Rows[i].Cells[1].Value.ToString();
            RangBuocNut(true, true, true, false, false);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhoaTruycap(false);
            LamSachDuLieu();
            txt_maTacGia.Text = LayMaTiepTheo();
            txt_tenTacGia.Focus();
            RangBuocNut(false, false, false, true, true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xoá ?", "Cảnh báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;

            try
            {
                string s;
                ketNoi.Open();
                cauLenh = ketNoi.CreateCommand();

                s = "delete TacGia_Sach where maTG = '" + txt_maTacGia.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                s = "delete TacGia where maTG = '" + txt_maTacGia.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                ketNoi.Close();
                LamSachDuLieu();
                TaiDuLieu();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối dữ liệu !");
            }
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            KhoaTruycap(false);
            txt_tenTacGia.Focus();
            RangBuocNut(false, false, false, true, true);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                ketNoi.Open();
                string s = "exec Luu_TacGia '" + txt_maTacGia.Text + "', N'" + txt_tenTacGia.Text + "'";
                cauLenh = new SqlCommand(s, ketNoi);
                cauLenh.ExecuteNonQuery();
                ketNoi.Close();

            }
            catch
            {
                ketNoi.Close();
            }

            MessageBox.Show("Lưu thành công !", "Thông báo");
            KhoaTruycap();
            LamSachDuLieu();
            TaiDuLieu();
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_khongLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xoá tất cả dữ liệu đang nhập ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            LamSachDuLieu();
            KhoaTruycap();
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiem.Text.Length == 0)
            {
                TaiDuLieu();
                return;
            }

            string s = "exec TimThongTin_TacGia N'" + txt_timKiem.Text + "'";
            TaiDuLieu(s);
        }
    }
}
