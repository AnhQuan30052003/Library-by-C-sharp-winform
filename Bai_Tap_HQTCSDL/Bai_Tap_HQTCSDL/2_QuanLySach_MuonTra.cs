using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai_Tap_HQTCSDL
{
    public partial class QuanLySach_MuonTraSach : Form
    {
        SqlConnection ketNoi = new SqlConnection(Connect.str);
        SqlDataAdapter chuyenDuLieu = new SqlDataAdapter();
        SqlCommand cauLenh;
        DataTable bangDuLieu;

        private string maTT, tenTT;
        private int i = -1;

        // Tải dữ liệu bảng cho dgv
        private void TaiDuLieu(string s = "exec ThongTin_MuonSach")
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

        // Khoá truy cập
        private void KhoaTruycap(bool k = true)
        {
            if (k == true)
            {
                txt_maDocGia.Enabled = false;
                txt_maSach.Enabled = false;
            }
            else
            {
                txt_maDocGia.Enabled = true;
                txt_maSach.Enabled = true;
            }
        }
        
        // Ràng buộc nut
        private void RangBucNut(bool muon, bool tra, bool dong)
        {
            if (muon) btn_muon.Enabled = true;
            else btn_muon.Enabled = false;

            if (tra) btn_tra.Enabled = true;
            else btn_tra.Enabled = false;

            if (dong) btn_dong.Enabled = true;
            else btn_dong.Enabled = false;
        }
        public QuanLySach_MuonTraSach(string maTT = "", string tenTT = "")
        {
            InitializeComponent();
            this.maTT = maTT;
            this.tenTT = tenTT;
        }

        private void QuanLySach_MuonSach_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            txt_tienPhat.Text = "5000";
            group_muonSach.Visible = false;
            group_traSach.Visible = false;
            RangBucNut(true,  false, true);
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                ketNoi.Open();
                string s = "insert into MuonSach values ('" + maTT + "', '" + txt_maSach.Text + "', '" + txt_maDocGia.Text + "', '" + dt_ngayMuon.Value + "', '" + dt_ngayPhaiTra.Value + "', '" + txt_tienPhat.Text + "')";
                cauLenh = new SqlCommand(s, ketNoi);
                cauLenh.ExecuteNonQuery();
                ketNoi.Close();

                MessageBox.Show("Cho mượn thành công", "Thông báo !");
                group_muonSach.Visible = false;
                RangBucNut(true, false, true);
                TaiDuLieu();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối dữ liệu", "Thông báo !");
                ketNoi.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận huỷ", "Cảnh báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            group_muonSach.Visible = false;
            RangBucNut(true, false, true);
        }

        private void btn_muon_Click(object sender, EventArgs e)
        {
            group_muonSach.Visible = true;
            KhoaTruycap(false);
            txt_maThuThu.Text = maTT;
            txt_hoVaTenThuThu.Text = tenTT;
            txt_maDocGia.Clear();
            txt_hoVaTenDocGia.Clear();
            txt_soDienThoai.Clear();
            txt_maSach.Clear();
            txt_tenSach.Clear();
            dt_ngayPhaiTra.Value = dt_ngayMuon.Value.AddDays(7);
            RangBucNut(false, false, false);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_maDocGia_TextChanged(object sender, EventArgs e)
        {
            txt_hoVaTenDocGia.Clear();
            txt_soDienThoai.Clear();

            ketNoi.Open();
            string s = "select hoDem + ' ' + ten [Họ và tên], dienThoai [Số điện thoai], soSachMuonDuoc [Số sách mượn được] from DocGia where maDG = '" + txt_maDocGia.Text + "'";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            ketNoi.Close();

            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv_tam.DataSource = null;
            dgv_tam.DataSource = bangDuLieu;

            if (dgv_tam.RowCount == 1) return;
            txt_hoVaTenDocGia.Text = dgv_tam.Rows[0].Cells[0].Value.ToString();
            txt_soDienThoai.Text = dgv_tam.Rows[0].Cells[1].Value.ToString();
            txt_soSachMuonDuoc.Text = dgv_tam.Rows[0].Cells[2].Value.ToString();

            int n = Convert.ToInt32(txt_soSachMuonDuoc.Text);
            if (n <= 0) MessageBox.Show("Độc giả không thể tiếp tục mượn sách", "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txt_maSach_TextChanged(object sender, EventArgs e)
        {
            txt_tenSach.Clear();
            ketNoi.Open();
            string s = "select maSach, tenSach from Sach where maSach = '" + txt_maSach.Text + "'";
            chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);
            ketNoi.Close();

            bangDuLieu = new DataTable();
            chuyenDuLieu.Fill(bangDuLieu);
            dgv_tam.DataSource = null;
            dgv_tam.DataSource = bangDuLieu;

            if (dgv_tam.RowCount == 1) return;
            txt_tenSach.Text = dgv_tam.Rows[0].Cells[1].Value.ToString();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgv.CurrentRow.Index;
            if (i == dgv.RowCount - 1) btn_tra.Enabled = false;
            else btn_tra.Enabled = true;
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            group_traSach.Visible = true;
            txt_tenSach_tra.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txt_tenDocGia_tra.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dt_ngayMuon_tra.Value = Convert.ToDateTime(dgv.Rows[i].Cells[4].Value);
            dt_ngayPhaiTra_tra.Value = Convert.ToDateTime(dgv.Rows[i].Cells[5].Value);
            txt_tienPhat_tra.Text = dgv.Rows[i].Cells[6].Value.ToString();

            TimeSpan soNgayTre = dt_ngayTra_tra.Value - dt_ngayPhaiTra_tra.Value;
            int ketQua = soNgayTre.Days - 7;
            if (ketQua < 0) ketQua = 0;
            txt_soNgayTre_tra.Text = ketQua.ToString();

            int tienPhat = Convert.ToInt32(txt_tienPhat_tra.Text);
            txt_tongTienPhat_tra.Text = (ketQua * tienPhat).ToString();
            RangBucNut(false, false, false);
        }

        private void btn_dongBangTra_Click(object sender, EventArgs e)
        {
            group_traSach.Visible = false;
            RangBucNut(true, false, true);
        }

        private void btn_xacNhanTra_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = dgv.Rows[0].Cells[0].Value.ToString();

                ketNoi.Open();
                cauLenh = ketNoi.CreateCommand();
                string s = "select maDG from DocGia where hoDem + ' ' + ten = N'" + txt_tenDocGia_tra.Text + "'";
                chuyenDuLieu.SelectCommand = new SqlCommand(s, ketNoi);

                bangDuLieu = new DataTable();
                chuyenDuLieu.Fill(bangDuLieu);
                dgv_tam.DataSource = null;
                dgv_tam.DataSource = bangDuLieu;
                string maDocGiaTra = dgv_tam.Rows[0].Cells[0].Value.ToString();

                s = "delete MuonSach where maDG = '" + maDocGiaTra + "' and maSach = '" + maSach + "' and ngayMuon = '" + dt_ngayMuon_tra.Value + "'";
                cauLenh = new SqlCommand(s, ketNoi);
                cauLenh.ExecuteNonQuery();
                ketNoi.Close();

                MessageBox.Show("Đã trả thành công !");
                group_traSach.Visible = false;
                RangBucNut(true, false, true);
                TaiDuLieu();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối dữ liệu", "Thông báo !");
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiem.Text.Length == 0)
            {
                TaiDuLieu();
                return;
            }

            string s = "exec TimThongTin_SachMuon N'" + txt_timKiem.Text + "'";
            TaiDuLieu(s);
        }
    }
}
