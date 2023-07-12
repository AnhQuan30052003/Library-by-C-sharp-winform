using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_HQTCSDL
{
    public partial class ThongKe : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        SqlCommand cauLenh;
        DataTable bangDuLieu;

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            string s = "";
            ketNoi.Open();
            cauLenh = ketNoi.CreateCommand();
            // Số lượng độc giả
            s = "select count(*) from DocGia";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            txt_soLuongDocGia.Text = dgv.Rows[0].Cells[0].Value.ToString();

            // Số lượng thủ thủ
            s = "select count(*) from ThuThu";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            txt_soLuongThuThu.Text = dgv.Rows[0].Cells[0].Value.ToString();

            // Số lượng tác giả
            s = "select count(*) from TacGia";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            txt_soLuongTacGia.Text = dgv.Rows[0].Cells[0].Value.ToString();

            // Số độc giả mượn quá hạn
            s = "select count(*) from MuonSach ms join DocGia dg on ms.maDG = dg.maDG where ms.ngayPhaiTra < GetDate()";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            txt_soLuongDocGiaQuanHan.Text = dgv.Rows[0].Cells[0].Value.ToString();

            //  Thể loại đọc nhiều nhất
            s = "select top 1 ls.tenLS from MuonSach ms join Sach s on ms.MaSach = s.MaSach join LoaiSach ls on ls.maLS = s.maLS group by ls.tenLS having count(*) >= all (select count(*) from MuonSach ms join Sach s on ms.MaSach = s.MaSach join LoaiSach ls on ls.maLS = s.maLS group by ls.tenLS)";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            if (dgv.RowCount == 1) txt_theLoaiSachMuonNhieuNhat.Text = "";
            else txt_theLoaiSachMuonNhieuNhat.Text = dgv.Rows[0].Cells[0].Value.ToString();
            ketNoi.Close();
            group_thongTin.Visible = false;
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            group_thongTin.Visible = true;
            btn_dong.Enabled = false;
            group_thongTin.Text = "Các Độc Giả Mượn Sách Từ Ngày \"" + dt_tuNgay.Value.ToShortDateString() + "\" Đến Ngày \"" + dt_denNgay.Value.ToShortDateString() + "\"";
            string s = "select dg.maDG [Mã độc giả], dg.hoDem + ' ' + dg.ten [Họ và tên], ms.ngayMuon [Ngày mượn] from DocGia dg join MuonSach ms on dg.maDG = ms.maDG where ms.ngayMuon >= '" + dt_tuNgay.Value + "' and ms.ngayMuon <= '" + dt_denNgay.Value + "'";
            ketNoi.Open();
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ketNoi.Close();
        }

        private void btn_dongGroupThongTin_Click(object sender, EventArgs e)
        {
            group_thongTin.Visible = false;
            btn_dong.Enabled = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_theLoaiSach_MouseClick(object sender, MouseEventArgs e)
        {
            string s = "select tenLS from LoaiSach order by tenLS";
            ketNoi.Open();
            cauLenh = new SqlCommand(s, ketNoi);
            SqlDataReader re = cauLenh.ExecuteReader();

            cb_theLoaiSach.Items.Clear();
            while (re.Read())
            {
                cb_theLoaiSach.Items.Add(re["tenLS"].ToString());
            }
            re.Close();
            ketNoi.Close();
        }

        private void cb_theLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select count(*) from Sach s join LoaiSach ls on s.maLS = ls.maLS where ls.tenLS = N'" + cb_theLoaiSach.SelectedItem + "'";
            ketNoi.Open();
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            ketNoi.Close();

            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            txt_soLuongSach.Text = dgv.Rows[0].Cells[0].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            group_thongTin.Visible = true;
            btn_dong.Enabled = false;
            group_thongTin.Text = "Ngày Hiện Tại: " + DateTime.Now.ToShortDateString();
            ketNoi.Open();
            string s = "select dg.maDG [Mã], dg.hoDem + ' ' + dg.ten [Họ và tên], ms.ngayMuon [Ngày mượn], ms.ngayPhaiTra [Ngày phải trả] from MuonSach ms join DocGia dg on ms.maDG = dg.maDG where ms.ngayPhaiTra < GetDate()";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv.DataSource = null;
            dgv.DataSource = bangDuLieu;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ketNoi.Close();
        }
    }
}
