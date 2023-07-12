namespace project1
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.checkbox_hienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.checkbox_hienThiMatKhau);
            this.groupBox1.Controls.Add(this.btn_dangNhap);
            this.groupBox1.Controls.Add(this.txt_matKhau);
            this.groupBox1.Controls.Add(this.txt_taiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_thoat.Location = new System.Drawing.Point(238, 86);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(162, 49);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // checkbox_hienThiMatKhau
            // 
            this.checkbox_hienThiMatKhau.AutoSize = true;
            this.checkbox_hienThiMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_hienThiMatKhau.ForeColor = System.Drawing.Color.White;
            this.checkbox_hienThiMatKhau.Location = new System.Drawing.Point(358, 50);
            this.checkbox_hienThiMatKhau.Name = "checkbox_hienThiMatKhau";
            this.checkbox_hienThiMatKhau.Size = new System.Drawing.Size(68, 19);
            this.checkbox_hienThiMatKhau.TabIndex = 2;
            this.checkbox_hienThiMatKhau.Text = "Hiển thị";
            this.checkbox_hienThiMatKhau.UseVisualStyleBackColor = true;
            this.checkbox_hienThiMatKhau.CheckedChanged += new System.EventHandler(this.checkbox_hienThiMatKhau_CheckedChanged);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dangNhap.Location = new System.Drawing.Point(70, 86);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(162, 49);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(99, 47);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(253, 20);
            this.txt_matKhau.TabIndex = 1;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Location = new System.Drawing.Point(99, 18);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(253, 20);
            this.txt_taiKhoan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(707, 241);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(38, 33);
            this.dgv.TabIndex = 3;
            this.dgv.Visible = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(478, 322);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DangNhap";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_hienThiMatKhau;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv;
    }
}
