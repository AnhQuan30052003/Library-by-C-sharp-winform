namespace Bai_Tap_HQTCSDL
{
    partial class GiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThong_doiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThong_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThong_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySach_danhMucSach = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySach_tacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySach_muonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySach_loaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyNhanSu_docGia = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyNhanSu_thuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.meu_thongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupbox_doiMatKhau = new System.Windows.Forms.GroupBox();
            this.thoat_doiMatKhau = new System.Windows.Forms.Button();
            this.xacNhan_DoiMatKhau = new System.Windows.Forms.Button();
            this.txt_nhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txt_matKhauMoi = new System.Windows.Forms.TextBox();
            this.txt_matKhauCu = new System.Windows.Forms.TextBox();
            this.txt_tenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_xinChao = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupbox_doiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýNhânSựToolStripMenuItem,
            this.meu_thongKe});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(663, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong_doiMatKhau,
            this.HeThong_dangXuat,
            this.HeThong_thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // HeThong_doiMatKhau
            // 
            this.HeThong_doiMatKhau.Name = "HeThong_doiMatKhau";
            this.HeThong_doiMatKhau.Size = new System.Drawing.Size(146, 22);
            this.HeThong_doiMatKhau.Text = "Đổi Mật Khẩu";
            this.HeThong_doiMatKhau.Click += new System.EventHandler(this.HeThong_doiMatKhau_Click);
            // 
            // HeThong_dangXuat
            // 
            this.HeThong_dangXuat.Name = "HeThong_dangXuat";
            this.HeThong_dangXuat.Size = new System.Drawing.Size(146, 22);
            this.HeThong_dangXuat.Text = "Đăng Xuất";
            this.HeThong_dangXuat.Click += new System.EventHandler(this.HeThong_dangXuat_Click);
            // 
            // HeThong_thoat
            // 
            this.HeThong_thoat.Name = "HeThong_thoat";
            this.HeThong_thoat.Size = new System.Drawing.Size(146, 22);
            this.HeThong_thoat.Text = "Thoát";
            this.HeThong_thoat.Click += new System.EventHandler(this.HeThong_thoat_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLySach_danhMucSach,
            this.QuanLySach_tacGia,
            this.QuanLySach_muonSach,
            this.QuanLySach_loaiSach});
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            // 
            // QuanLySach_danhMucSach
            // 
            this.QuanLySach_danhMucSach.Name = "QuanLySach_danhMucSach";
            this.QuanLySach_danhMucSach.Size = new System.Drawing.Size(161, 22);
            this.QuanLySach_danhMucSach.Text = "Danh Mục Sách ";
            this.QuanLySach_danhMucSach.Click += new System.EventHandler(this.QuanLySach_danhMucSach_Click);
            // 
            // QuanLySach_tacGia
            // 
            this.QuanLySach_tacGia.Name = "QuanLySach_tacGia";
            this.QuanLySach_tacGia.Size = new System.Drawing.Size(161, 22);
            this.QuanLySach_tacGia.Text = "Tác Giả";
            this.QuanLySach_tacGia.Click += new System.EventHandler(this.QuanLySach_tacGia_Click);
            // 
            // QuanLySach_muonSach
            // 
            this.QuanLySach_muonSach.Name = "QuanLySach_muonSach";
            this.QuanLySach_muonSach.Size = new System.Drawing.Size(161, 22);
            this.QuanLySach_muonSach.Text = "Mượn - Trả Sách";
            this.QuanLySach_muonSach.Click += new System.EventHandler(this.QuanLySach_muonTraSach_Click);
            // 
            // QuanLySach_loaiSach
            // 
            this.QuanLySach_loaiSach.Name = "QuanLySach_loaiSach";
            this.QuanLySach_loaiSach.Size = new System.Drawing.Size(161, 22);
            this.QuanLySach_loaiSach.Text = "Loại Sách";
            this.QuanLySach_loaiSach.Click += new System.EventHandler(this.QuanLySach_loaiSach_Click);
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyNhanSu_docGia,
            this.QuanLyNhanSu_thuThu});
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản Lý Nhân Sự";
            // 
            // QuanLyNhanSu_docGia
            // 
            this.QuanLyNhanSu_docGia.Name = "QuanLyNhanSu_docGia";
            this.QuanLyNhanSu_docGia.Size = new System.Drawing.Size(119, 22);
            this.QuanLyNhanSu_docGia.Text = "Độc Giả";
            this.QuanLyNhanSu_docGia.Click += new System.EventHandler(this.QuanLyNhanSu_docGia_Click);
            // 
            // QuanLyNhanSu_thuThu
            // 
            this.QuanLyNhanSu_thuThu.Name = "QuanLyNhanSu_thuThu";
            this.QuanLyNhanSu_thuThu.Size = new System.Drawing.Size(119, 22);
            this.QuanLyNhanSu_thuThu.Text = "Thủ Thư";
            this.QuanLyNhanSu_thuThu.Click += new System.EventHandler(this.QuanLyNhanSu_thuThu_Click);
            // 
            // meu_thongKe
            // 
            this.meu_thongKe.Checked = true;
            this.meu_thongKe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meu_thongKe.Name = "meu_thongKe";
            this.meu_thongKe.Size = new System.Drawing.Size(70, 20);
            this.meu_thongKe.Text = "Thống Kê";
            this.meu_thongKe.Click += new System.EventHandler(this.meu_thongKe_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 32);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(197, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đại học Nha Trang";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 357);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupbox_doiMatKhau
            // 
            this.groupbox_doiMatKhau.Controls.Add(this.thoat_doiMatKhau);
            this.groupbox_doiMatKhau.Controls.Add(this.xacNhan_DoiMatKhau);
            this.groupbox_doiMatKhau.Controls.Add(this.txt_nhapLaiMatKhauMoi);
            this.groupbox_doiMatKhau.Controls.Add(this.txt_matKhauMoi);
            this.groupbox_doiMatKhau.Controls.Add(this.txt_matKhauCu);
            this.groupbox_doiMatKhau.Controls.Add(this.txt_tenTaiKhoan);
            this.groupbox_doiMatKhau.Controls.Add(this.label4);
            this.groupbox_doiMatKhau.Controls.Add(this.label3);
            this.groupbox_doiMatKhau.Controls.Add(this.label2);
            this.groupbox_doiMatKhau.Controls.Add(this.label1);
            this.groupbox_doiMatKhau.ForeColor = System.Drawing.Color.White;
            this.groupbox_doiMatKhau.Location = new System.Drawing.Point(147, 127);
            this.groupbox_doiMatKhau.Name = "groupbox_doiMatKhau";
            this.groupbox_doiMatKhau.Size = new System.Drawing.Size(322, 169);
            this.groupbox_doiMatKhau.TabIndex = 5;
            this.groupbox_doiMatKhau.TabStop = false;
            this.groupbox_doiMatKhau.Text = "Đổi Mật Khẩu";
            this.groupbox_doiMatKhau.Visible = false;
            // 
            // thoat_doiMatKhau
            // 
            this.thoat_doiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat_doiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.thoat_doiMatKhau.Location = new System.Drawing.Point(230, 122);
            this.thoat_doiMatKhau.Name = "thoat_doiMatKhau";
            this.thoat_doiMatKhau.Size = new System.Drawing.Size(75, 36);
            this.thoat_doiMatKhau.TabIndex = 5;
            this.thoat_doiMatKhau.Text = "Thoát";
            this.thoat_doiMatKhau.UseVisualStyleBackColor = true;
            this.thoat_doiMatKhau.Click += new System.EventHandler(this.thoat_doiMatKhau_Click);
            // 
            // xacNhan_DoiMatKhau
            // 
            this.xacNhan_DoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacNhan_DoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.xacNhan_DoiMatKhau.Location = new System.Drawing.Point(127, 122);
            this.xacNhan_DoiMatKhau.Name = "xacNhan_DoiMatKhau";
            this.xacNhan_DoiMatKhau.Size = new System.Drawing.Size(75, 36);
            this.xacNhan_DoiMatKhau.TabIndex = 3;
            this.xacNhan_DoiMatKhau.Text = "Xác Nhận";
            this.xacNhan_DoiMatKhau.UseVisualStyleBackColor = true;
            this.xacNhan_DoiMatKhau.Click += new System.EventHandler(this.xacNhan_DoiMatKhau_Click);
            // 
            // txt_nhapLaiMatKhauMoi
            // 
            this.txt_nhapLaiMatKhauMoi.Location = new System.Drawing.Point(127, 90);
            this.txt_nhapLaiMatKhauMoi.Name = "txt_nhapLaiMatKhauMoi";
            this.txt_nhapLaiMatKhauMoi.Size = new System.Drawing.Size(181, 20);
            this.txt_nhapLaiMatKhauMoi.TabIndex = 2;
            // 
            // txt_matKhauMoi
            // 
            this.txt_matKhauMoi.Location = new System.Drawing.Point(127, 64);
            this.txt_matKhauMoi.Name = "txt_matKhauMoi";
            this.txt_matKhauMoi.Size = new System.Drawing.Size(181, 20);
            this.txt_matKhauMoi.TabIndex = 1;
            // 
            // txt_matKhauCu
            // 
            this.txt_matKhauCu.Location = new System.Drawing.Point(127, 39);
            this.txt_matKhauCu.Name = "txt_matKhauCu";
            this.txt_matKhauCu.Size = new System.Drawing.Size(181, 20);
            this.txt_matKhauCu.TabIndex = 0;
            // 
            // txt_tenTaiKhoan
            // 
            this.txt_tenTaiKhoan.Enabled = false;
            this.txt_tenTaiKhoan.Location = new System.Drawing.Point(127, 14);
            this.txt_tenTaiKhoan.Name = "txt_tenTaiKhoan";
            this.txt_tenTaiKhoan.Size = new System.Drawing.Size(181, 20);
            this.txt_tenTaiKhoan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // lb_xinChao
            // 
            this.lb_xinChao.AutoSize = true;
            this.lb_xinChao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_xinChao.ForeColor = System.Drawing.Color.Red;
            this.lb_xinChao.Location = new System.Drawing.Point(373, 5);
            this.lb_xinChao.Name = "lb_xinChao";
            this.lb_xinChao.Size = new System.Drawing.Size(35, 13);
            this.lb_xinChao.TabIndex = 6;
            this.lb_xinChao.Text = "label5";
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(663, 391);
            this.Controls.Add(this.lb_xinChao);
            this.Controls.Add(this.groupbox_doiMatKhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupbox_doiMatKhau.ResumeLayout(false);
            this.groupbox_doiMatKhau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeThong_doiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem HeThong_dangXuat;
        private System.Windows.Forms.ToolStripMenuItem HeThong_thoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLySach_danhMucSach;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNhanSu_docGia;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNhanSu_thuThu;
        private System.Windows.Forms.ToolStripMenuItem meu_thongKe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem QuanLySach_tacGia;
        private System.Windows.Forms.GroupBox groupbox_doiMatKhau;
        private System.Windows.Forms.TextBox txt_nhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txt_matKhauMoi;
        private System.Windows.Forms.TextBox txt_matKhauCu;
        private System.Windows.Forms.TextBox txt_tenTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_doiMatKhau;
        private System.Windows.Forms.Button xacNhan_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem QuanLySach_muonSach;
        private System.Windows.Forms.ToolStripMenuItem QuanLySach_loaiSach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_xinChao;
    }
}

