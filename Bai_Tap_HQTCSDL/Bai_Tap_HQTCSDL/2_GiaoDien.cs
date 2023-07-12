using project1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_HQTCSDL
{
    public partial class GiaoDien : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlCommand cauLenh;

        string taiKhoanDangNhap, matKhau, tenDangNhap;
        public GiaoDien(string taiKhoanDangNhap = "", string matKhau = "", string tenDangNhap = "")
        {
            InitializeComponent();
            this.taiKhoanDangNhap = taiKhoanDangNhap;
            this.matKhau = matKhau;
            this.tenDangNhap = tenDangNhap;
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            lb_xinChao.Text = "Xin chào " + tenDangNhap + " !";
        }

        private void HeThong_doiMatKhau_Click(object sender, EventArgs e)
        {
            groupbox_doiMatKhau.Visible = true;
            txt_tenTaiKhoan.Text = taiKhoanDangNhap;
            txt_matKhauCu.Focus();
        }

        private void thoat_doiMatKhau_Click(object sender, EventArgs e)
        {
            groupbox_doiMatKhau.Visible = false;
        }

        private void HeThong_dangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap a = new DangNhap();
            a.ShowDialog();
            this.Close();
        }

        private void HeThong_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận thoát ?", "Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK) this.Close();
        }

        private void QuanLySach_danhMucSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach_DanhMucSach a = new QuanLySach_DanhMucSach();
            a.ShowDialog();
            this.Show();
        }

        private void QuanLySach_tacGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach_TacGia a = new QuanLySach_TacGia();
            a.ShowDialog();
            this.Show();
        }

        private void QuanLyNhanSu_docGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanSu_DocGia a = new QuanLyNhanSu_DocGia(taiKhoanDangNhap);
            a.ShowDialog();
            this.Show();
        }

        private void QuanLyNhanSu_thuThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanSu_ThuThu a = new QuanLyNhanSu_ThuThu(taiKhoanDangNhap);
            a.ShowDialog();
            this.Show();
        }

        private void meu_thongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe a = new ThongKe();
            a.ShowDialog();
            this.Show();
        }

        private void QuanLySach_loaiSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach_LoaiSach a = new QuanLySach_LoaiSach();
            a.ShowDialog();
            this.Show();
        }

        private void xacNhan_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_matKhauCu.Text != matKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo");
                txt_matKhauCu.Focus();
                return;
            }

            if (txt_matKhauMoi.Text == matKhau)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Thông báo");
                txt_matKhauMoi.Focus();
                return;
            }

            if (txt_matKhauMoi.Text != txt_nhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không trùng khớp", "Thông báo");
                txt_matKhauMoi.Focus();
                return;
            }

            string s = "update DangNhap set matKhau = '" + txt_matKhauMoi.Text + "' where maTT = '" + taiKhoanDangNhap + "'";
            ketNoi.Open();
            cauLenh = new SqlCommand(s, ketNoi);
            cauLenh.ExecuteNonQuery();
            ketNoi.Close();

            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            groupbox_doiMatKhau.Visible = false;
        }

        private void QuanLySach_muonTraSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach_MuonTraSach a = new QuanLySach_MuonTraSach(taiKhoanDangNhap, tenDangNhap);
            a.ShowDialog();
            this.Show();
        }
    }
}
