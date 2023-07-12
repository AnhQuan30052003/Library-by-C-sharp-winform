namespace Bai_Tap_HQTCSDL
{
    partial class QuanLyNhanSu_DocGia
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
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_soSachMuonDuoc = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.dt_ngayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dt_ngayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txt_dienThoai = new System.Windows.Forms.TextBox();
            this.dt_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_hoDem = new System.Windows.Forms.TextBox();
            this.txt_maDocGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_khongLuu = new System.Windows.Forms.Button();
            this.btn_chinhSua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(74, 11);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_timKiem.Multiline = true;
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(400, 20);
            this.txt_timKiem.TabIndex = 0;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm: ";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 42);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1281, 365);
            this.dgv.TabIndex = 3;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_soSachMuonDuoc);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.dt_ngayHetHan);
            this.groupBox1.Controls.Add(this.dt_ngayDangKy);
            this.groupBox1.Controls.Add(this.txt_dienThoai);
            this.groupBox1.Controls.Add(this.dt_ngaySinh);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_hoDem);
            this.groupBox1.Controls.Add(this.txt_maDocGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rdb_nu);
            this.groupBox1.Controls.Add(this.rdb_nam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 411);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1180, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Độc Giả ";
            // 
            // txt_soSachMuonDuoc
            // 
            this.txt_soSachMuonDuoc.Enabled = false;
            this.txt_soSachMuonDuoc.Location = new System.Drawing.Point(1015, 174);
            this.txt_soSachMuonDuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_soSachMuonDuoc.Name = "txt_soSachMuonDuoc";
            this.txt_soSachMuonDuoc.Size = new System.Drawing.Size(30, 20);
            this.txt_soSachMuonDuoc.TabIndex = 9;
            this.txt_soSachMuonDuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(463, 182);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(350, 20);
            this.txt_diaChi.TabIndex = 6;
            // 
            // dt_ngayHetHan
            // 
            this.dt_ngayHetHan.Enabled = false;
            this.dt_ngayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayHetHan.Location = new System.Drawing.Point(1015, 123);
            this.dt_ngayHetHan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ngayHetHan.Name = "dt_ngayHetHan";
            this.dt_ngayHetHan.Size = new System.Drawing.Size(93, 20);
            this.dt_ngayHetHan.TabIndex = 8;
            // 
            // dt_ngayDangKy
            // 
            this.dt_ngayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayDangKy.Location = new System.Drawing.Point(1015, 72);
            this.dt_ngayDangKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ngayDangKy.Name = "dt_ngayDangKy";
            this.dt_ngayDangKy.Size = new System.Drawing.Size(93, 20);
            this.dt_ngayDangKy.TabIndex = 7;
            this.dt_ngayDangKy.ValueChanged += new System.EventHandler(this.dt_ngayDangKy_ValueChanged);
            // 
            // txt_dienThoai
            // 
            this.txt_dienThoai.Location = new System.Drawing.Point(463, 131);
            this.txt_dienThoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dienThoai.Name = "txt_dienThoai";
            this.txt_dienThoai.Size = new System.Drawing.Size(190, 20);
            this.txt_dienThoai.TabIndex = 5;
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaySinh.Location = new System.Drawing.Point(118, 181);
            this.dt_ngaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ngaySinh.Name = "dt_ngaySinh";
            this.dt_ngaySinh.Size = new System.Drawing.Size(93, 20);
            this.dt_ngaySinh.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(117, 139);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(190, 20);
            this.txt_ten.TabIndex = 2;
            // 
            // txt_hoDem
            // 
            this.txt_hoDem.Location = new System.Drawing.Point(117, 101);
            this.txt_hoDem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_hoDem.Name = "txt_hoDem";
            this.txt_hoDem.Size = new System.Drawing.Size(190, 20);
            this.txt_hoDem.TabIndex = 1;
            // 
            // txt_maDocGia
            // 
            this.txt_maDocGia.Enabled = false;
            this.txt_maDocGia.Location = new System.Drawing.Point(117, 64);
            this.txt_maDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_maDocGia.Name = "txt_maDocGia";
            this.txt_maDocGia.Size = new System.Drawing.Size(80, 20);
            this.txt_maDocGia.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSlateGray;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(937, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ngày Hết Hạn";
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdb_nu.ForeColor = System.Drawing.Color.White;
            this.rdb_nu.Location = new System.Drawing.Point(499, 89);
            this.rdb_nu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_nu.TabIndex = 4;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = false;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdb_nam.ForeColor = System.Drawing.Color.White;
            this.rdb_nam.Location = new System.Drawing.Point(498, 68);
            this.rdb_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(47, 17);
            this.rdb_nam.TabIndex = 8;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSlateGray;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(936, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ngày Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(905, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Sách Mượn Được";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSlateGray;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(401, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSlateGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(419, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(426, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Độc Giả";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox5.Location = new System.Drawing.Point(888, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 175);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox4.Location = new System.Drawing.Point(395, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 175);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox6.Location = new System.Drawing.Point(39, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(287, 175);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(39, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 175);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.btn_dong);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_khongLuu);
            this.groupBox2.Controls.Add(this.btn_chinhSua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(1204, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(85, 239);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng ";
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.White;
            this.btn_dong.ForeColor = System.Drawing.Color.Red;
            this.btn_dong.Location = new System.Drawing.Point(8, 184);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(69, 50);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(8, 119);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(69, 24);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_khongLuu
            // 
            this.btn_khongLuu.BackColor = System.Drawing.Color.White;
            this.btn_khongLuu.Location = new System.Drawing.Point(8, 150);
            this.btn_khongLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_khongLuu.Name = "btn_khongLuu";
            this.btn_khongLuu.Size = new System.Drawing.Size(69, 24);
            this.btn_khongLuu.TabIndex = 3;
            this.btn_khongLuu.Text = "Không Lưu";
            this.btn_khongLuu.UseVisualStyleBackColor = false;
            this.btn_khongLuu.Click += new System.EventHandler(this.btn_khongLuu_Click);
            // 
            // btn_chinhSua
            // 
            this.btn_chinhSua.BackColor = System.Drawing.Color.White;
            this.btn_chinhSua.Location = new System.Drawing.Point(8, 89);
            this.btn_chinhSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_chinhSua.Name = "btn_chinhSua";
            this.btn_chinhSua.Size = new System.Drawing.Size(69, 24);
            this.btn_chinhSua.TabIndex = 2;
            this.btn_chinhSua.Text = "Chỉnh Sửa";
            this.btn_chinhSua.UseVisualStyleBackColor = false;
            this.btn_chinhSua.Click += new System.EventHandler(this.btn_chinhSua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(8, 57);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(69, 24);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(8, 28);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(69, 24);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // QuanLyNhanSu_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1295, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timKiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyNhanSu_DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.Load += new System.EventHandler(this.QuanLyNhanSu_DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_ngaySinh;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_hoDem;
        private System.Windows.Forms.TextBox txt_dienThoai;
        private System.Windows.Forms.DateTimePicker dt_ngayHetHan;
        private System.Windows.Forms.DateTimePicker dt_ngayDangKy;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_khongLuu;
        private System.Windows.Forms.Button btn_chinhSua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_soSachMuonDuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_maDocGia;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}