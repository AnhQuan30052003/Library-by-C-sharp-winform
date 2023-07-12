using Bai_Tap_HQTCSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    partial class DangNhap : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        DataTable bangDuLieu;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            ketNoi.Open();
            string s = "select tt.maTT [Tài khoản], matKhau [Mật khẩu], hoDem + ' ' + ten [Họ và tên thủ thư] from DangNhap dn join ThuThu tt on dn.maTT = tt.maTT where tt.maTT = '" + txt_taiKhoan.Text + "'";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            ketNoi.Close();

            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;

            if (dgv.RowCount == 1)
            {
                MessageBox.Show("Tài khoản không tồn tại !", "Thông báo");
                txt_taiKhoan.Focus();
                return;
            }

            string matKhau = dgv.Rows[0].Cells[1].Value.ToString();
            if (txt_matKhau.Text != matKhau)
            {
                MessageBox.Show("Mật khẩu không chính xác !", "Thông báo");
                txt_matKhau.Focus();
                return;
            }

            string tenDangNhap = dgv.Rows[0].Cells[2].Value.ToString();

            // Chuyển vào form chính
            this.Hide();
            GiaoDien gd = new GiaoDien(txt_taiKhoan.Text, matKhau, tenDangNhap);
            gd.ShowDialog();
            this.Close();
        }

        private void checkbox_hienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_hienThiMatKhau.Checked) txt_matKhau.UseSystemPasswordChar = false;
            else txt_matKhau.UseSystemPasswordChar = true;
        }
    }
}
