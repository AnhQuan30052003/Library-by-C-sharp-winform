using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_HQTCSDL
{
    public partial class QuanLySach_DanhMucSach : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        SqlCommand cauLenh;
        DataTable bangDuLieu;

        private bool truyCapDGV = true;

        public QuanLySach_DanhMucSach()
        {
            InitializeComponent();
        }

        // Tải dữ liệu bảng cho dgv
        private void TaiDuLieu(string s = "exec ThongTin_Sach")
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
            txt_maSach.Clear();
            txt_tenSach.Clear();
            txt_moTa.Clear();
            txt_soTrang.Clear();
            txt_giaTien.Clear();
            txt_soLuong.Clear();
            cb_ngonNgu.SelectedIndex = -1;
            cb_tenTacGia.SelectedIndex = -1;
            cb_tenLoaiSach.SelectedIndex = -1;
            txt_namXB.Clear();
        }

        // Lấy mã sách kế tiếp
        private string LayMaTiepTheo()
        {
            int i = dgv.RowCount - 2;
            if (i < 0) return "SA001";
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
        private void KhoaTruycap(bool k = true)
        {
            if (k == true)
            {
                truyCapDGV = true;
                txt_tenSach.Enabled = false;
                txt_moTa.Enabled = false;
                txt_soTrang.Enabled = false;
                txt_giaTien.Enabled = false;
                txt_soLuong.Enabled = false;
                cb_ngonNgu.Enabled = false;
                cb_tenTacGia.Enabled = false;
                cb_tenLoaiSach.Enabled = false;
                txt_namXB.Enabled = false;
            }
            else
            {
                truyCapDGV = false;
                txt_tenSach.Enabled = true;
                txt_moTa.Enabled = true;
                txt_soTrang.Enabled = true;
                txt_giaTien.Enabled = true;
                txt_soLuong.Enabled = true;
                cb_ngonNgu.Enabled = true;
                cb_tenTacGia.Enabled = true;
                cb_tenLoaiSach.Enabled = true;
                txt_namXB.Enabled = true;
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

        // Load form
        private void QuanLySach_DanhMucSach_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            KhoaTruycap();
            RangBuocNut(true, false, false, false, false);
        }

        // Tìm kiềm
        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiem.Text.Length == 0)
            {
                TaiDuLieu();
                return;
            }

            string s = "exec TimThongTin_Sach N'" + txt_timKiem.Text + "'";
            TaiDuLieu(s);
        }

        // Thay đổi dữ liệu, hiển thị khi click
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (truyCapDGV == false) return;
            int i = dgv.CurrentRow.Index;
            if (i == dgv.RowCount - 1)
            {
                LamSachDuLieu();
                return;
            }

            txt_maSach.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_tenSach.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txt_moTa.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txt_soTrang.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txt_giaTien.Text = dgv.Rows[i].Cells[5].Value.ToString();
            txt_soLuong.Text = dgv.Rows[i].Cells[6].Value.ToString();
            txt_namXB.Text = dgv.Rows[i].Cells[9].Value.ToString();

            string ngonNgu = dgv.Rows[i].Cells[7].Value.ToString();
            if (ngonNgu == "Tiếng Việt") cb_ngonNgu.SelectedIndex = 0;
            else cb_ngonNgu.SelectedIndex = 1;

            string tenLoaiSach = dgv.Rows[i].Cells[2].Value.ToString();
            cb_tenLoaiSach.Items.Clear();
            cb_tenLoaiSach.Items.Add(tenLoaiSach);
            cb_tenLoaiSach.SelectedIndex = 0;

            string tenTacGia = dgv.Rows[i].Cells[8].Value.ToString();
            cb_tenTacGia.Items.Clear();
            cb_tenTacGia.Items.Add(tenTacGia);
            cb_tenTacGia.SelectedIndex = 0;
            RangBuocNut(true, true, true, false, false);
        }

        // Các nút
        // Tiến hành thêm sách mới
        private void btn_them_Click(object sender, EventArgs e)
        {
            KhoaTruycap(false);
            LamSachDuLieu();
            txt_maSach.Text = LayMaTiepTheo();
            txt_tenSach.Focus();
            RangBuocNut(false, false, false, true, true);
        }

        //  Xoá sách
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xoá ?", "Cảnh báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;

            try
            {
                string s;
                ketNoi.Open();
                cauLenh = ketNoi.CreateCommand();

                s = "delete TacGia_Sach where maSach = '" + txt_maSach.Text + "'";
                cauLenh.CommandText = s;
                cauLenh.ExecuteNonQuery();

                s = "delete Sach where maSach = '" + txt_maSach.Text + "'";
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

        // Chỉnh sửa sách bất kỳ
        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            KhoaTruycap(false);
            txt_tenSach.Focus();
            RangBuocNut(false, false, false, true, true);
        }

        // Lưu sách
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                ketNoi.Open();
                string s = "exec Luu_Sach '" + txt_maSach.Text + "', N'" + txt_tenSach.Text + "', N'" + txt_moTa.Text + "', " + txt_soTrang.Text + ", " + txt_giaTien.Text + ", " + txt_soLuong.Text + ", N'" + cb_ngonNgu.SelectedItem + "', N'" + cb_tenTacGia.SelectedItem + "', " + txt_namXB.Text + ", N'" + cb_tenLoaiSach.SelectedItem + "'";
                cauLenh = new SqlCommand(s, ketNoi);
                cauLenh.ExecuteNonQuery();
                ketNoi.Close();

            } catch
            {
                ketNoi.Close();
            }

            MessageBox.Show("Lưu thành công !", "Thông báo");
            KhoaTruycap();
            LamSachDuLieu();
            TaiDuLieu();
            RangBuocNut(true, false, false, false, false);
        }

        // Không lưu, huỷ, xoá dữ liệu đang nhập
        private void btn_khongLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xoá tất cả dữ liệu đang nhập ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            LamSachDuLieu();
            KhoaTruycap();
            RangBuocNut(true, false, false, false, false);
        }

        // Đóng Form
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load tên tác giả khi click
        private void cb_tenTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            string s = "select tenTG from TacGia order by tenTG";
            ketNoi.Open();
            cauLenh = new SqlCommand(s, ketNoi);
            SqlDataReader re = cauLenh.ExecuteReader();

            cb_tenTacGia.Items.Clear();
            while (re.Read())
            {
                cb_tenTacGia.Items.Add(re["tenTG"].ToString());
            }
            re.Close();
            ketNoi.Close();
        }

        // Load tên lạoi sách khi click
        private void cb_tenLoaiSach_MouseClick(object sender, MouseEventArgs e)
        {
            string s = "select tenLS from LoaiSach order by tenLS";
            ketNoi.Open();
            cauLenh = new SqlCommand(s, ketNoi);
            SqlDataReader re = cauLenh.ExecuteReader();

            cb_tenLoaiSach.Items.Clear();
            while (re.Read())
            {
                cb_tenLoaiSach.Items.Add(re["tenLS"].ToString());
            }
            re.Close();
            ketNoi.Close();
        }

        // Mở Form tác giả
        private void btn_tacGia_Click(object sender, EventArgs e)
        {
            QuanLySach_TacGia a = new QuanLySach_TacGia();
            a.ShowDialog();
        }

        // Mở Form Loại sách
        private void btn_loaiSach_Click(object sender, EventArgs e)
        {
            QuanLySach_LoaiSach a = new QuanLySach_LoaiSach();
            a.ShowDialog();
        }
    }
}
