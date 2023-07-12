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
    public partial class QuanLyNhanSu_ThuThu : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        SqlCommand cauLenh;
        DataTable bangDuLieu;

        private bool truyCapDGV = true;
        private string maTT;

        // Tải dữ liệu bảng cho dgv
        private void TaiDuLieu(string s = "select maTT [Mã thủ thư], hoDem [Họ đệm], ten [Tên], ngaySinh [Ngày sinh], gioiTinh [Giới tính], diaChi [Địa chỉ], dienThoai [Điện thoại] from ThuThu")
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
            txt_maThuThu.Clear();
            txt_hoDem.Clear();
            txt_ten.Clear();
            rdb_nam.Checked = rdb_nu.Checked = false;
            txt_diaChi.Clear();
            txt_dienThoai.Clear();
            dt_ngaySinh.Value = DateTime.Now;
        }

        // Lấy mã sách kế tiếp
        private string LayMaTiepTheo()
        {
            int i = dgv.RowCount - 2;
            if (i < 0) return "TT001";
            string ma = dgv.Rows[i].Cells[0].Value.ToString();
            int so = Convert.ToInt32(ma.Substring(2, 3)) + 1;

            string t = "";
            if (so < 10) t = t + "00" + so;
            else if (so < 100) t = t + '0' + so;
            else t = t + so;

            ma = ma.Substring(0, 2) + t;
            return ma;
        }

        // Khoá truy cập
        private void KhoaTruyCap(bool k = true)
        {
            if (k == true)
            {
                truyCapDGV = true;
                txt_hoDem.Enabled = false;
                txt_ten.Enabled = false;
                dt_ngaySinh.Enabled = false;
                rdb_nam.Enabled = false;
                rdb_nu.Enabled = false;
                txt_diaChi.Enabled = false;
                txt_dienThoai.Enabled = false;
                dt_ngaySinh.Enabled = false;
            }
            else
            {
                truyCapDGV = false;
                txt_hoDem.Enabled = true;
                txt_ten.Enabled = true;
                dt_ngaySinh.Enabled = true;
                rdb_nam.Enabled = true;
                rdb_nu.Enabled = true;
                txt_diaChi.Enabled = true;
                txt_dienThoai.Enabled = true;
                dt_ngaySinh.Enabled = true;
            }
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

        public QuanLyNhanSu_ThuThu(string maTT = "")
        {
            InitializeComponent();
            this.maTT = maTT;
        }

        private void QuanLyNhanSu_ThuThu_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            KhoaTruyCap();
            RangBuocNut(true, false, false, false, false);
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiem.Text.Length == 0)
            {
                TaiDuLieu();
                return;
            }

            string s = "exec TimThongTin_ThuThu N'" + txt_timKiem.Text + "'";
            TaiDuLieu(s);
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

            txt_maThuThu.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_hoDem.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txt_ten.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txt_dienThoai.Text = dgv.Rows[i].Cells[6].Value.ToString();
            txt_diaChi.Text = dgv.Rows[i].Cells[5].Value.ToString();

            string gioiTinh = dgv.Rows[i].Cells[4].Value.ToString();
            if (gioiTinh == "Nam") rdb_nam.Checked = true;
            else rdb_nu.Checked = true;

            dt_ngaySinh.Value = Convert.ToDateTime(dgv.Rows[i].Cells[3].Value);
            RangBuocNut(true, true, true, false, false);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            KhoaTruyCap(false);
            LamSachDuLieu();
            txt_maThuThu.Text = LayMaTiepTheo();
            txt_hoDem.Focus();
            rdb_nam.Checked = true;
            RangBuocNut(false, false, false, true, true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maThuThu.Text == maTT)
            {
                MessageBox.Show("Tài khoản đang đăng nhập, không thể xoá", "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Xác nhận xoá ?", "Cảnh báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;

            try
            {
                string s;
                ketNoi.Open();
                cauLenh = ketNoi.CreateCommand();

                s = "delete DangKy where maTT = '" + txt_maThuThu.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                s = "delete DangNhap where maTT = '" + txt_maThuThu.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                s = "delete ThuThu where maTT = '" + txt_maThuThu.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                ketNoi.Close();
                TaiDuLieu();
                LamSachDuLieu();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối dữ liệu !");
            }
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            KhoaTruyCap(false);
            txt_hoDem.Focus();
            RangBuocNut(false, false, false, true, true);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string gioiTinh;
                if (rdb_nam.Checked) gioiTinh = "Nam";
                else gioiTinh = "Nữ";

                ketNoi.Open();
                string s = "exec Luu_ThuThu '" + txt_maThuThu.Text + "', N'" + txt_hoDem.Text + "', N'" + txt_ten.Text + "', '" + dt_ngaySinh.Value + " ', N'" + gioiTinh + "', N'" + txt_diaChi.Text + "', '" + txt_dienThoai.Text + "'";
                cauLenh = new SqlCommand(s, ketNoi);
                cauLenh.ExecuteNonQuery();
                ketNoi.Close();
            }
            catch
            {
                ketNoi.Close();
            }

            MessageBox.Show("Lưu thành công !", "Thông báo");
            KhoaTruyCap();
            TaiDuLieu();
            LamSachDuLieu();
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_khongLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xoá tất cả dữ liệu đang nhập ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            LamSachDuLieu();
            KhoaTruyCap();
            RangBuocNut(true, false, false, false, false);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
