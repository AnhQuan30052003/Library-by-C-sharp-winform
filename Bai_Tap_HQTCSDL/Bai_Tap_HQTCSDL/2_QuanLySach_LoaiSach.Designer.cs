namespace Bai_Tap_HQTCSDL
{
    partial class QuanLySach_LoaiSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_khongLuu = new System.Windows.Forms.Button();
            this.btn_chinhSua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenLoaiSach = new System.Windows.Forms.TextBox();
            this.txt_maLoaiSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(447, 416);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(117, 294);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng ";
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.White;
            this.btn_dong.ForeColor = System.Drawing.Color.Red;
            this.btn_dong.Location = new System.Drawing.Point(13, 226);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(92, 62);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.White;
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(13, 146);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 30);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_khongLuu
            // 
            this.btn_khongLuu.BackColor = System.Drawing.Color.White;
            this.btn_khongLuu.ForeColor = System.Drawing.Color.Black;
            this.btn_khongLuu.Location = new System.Drawing.Point(13, 185);
            this.btn_khongLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khongLuu.Name = "btn_khongLuu";
            this.btn_khongLuu.Size = new System.Drawing.Size(92, 30);
            this.btn_khongLuu.TabIndex = 3;
            this.btn_khongLuu.Text = "Không Lưu";
            this.btn_khongLuu.UseVisualStyleBackColor = false;
            this.btn_khongLuu.Click += new System.EventHandler(this.btn_khongLuu_Click);
            // 
            // btn_chinhSua
            // 
            this.btn_chinhSua.BackColor = System.Drawing.Color.White;
            this.btn_chinhSua.ForeColor = System.Drawing.Color.Black;
            this.btn_chinhSua.Location = new System.Drawing.Point(13, 110);
            this.btn_chinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chinhSua.Name = "btn_chinhSua";
            this.btn_chinhSua.Size = new System.Drawing.Size(92, 30);
            this.btn_chinhSua.TabIndex = 2;
            this.btn_chinhSua.Text = "Chỉnh Sửa";
            this.btn_chinhSua.UseVisualStyleBackColor = false;
            this.btn_chinhSua.Click += new System.EventHandler(this.btn_chinhSua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(13, 70);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 30);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(13, 34);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 30);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tenLoaiSach);
            this.groupBox1.Controls.Add(this.txt_maLoaiSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 416);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(415, 294);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Sách";
            // 
            // txt_tenLoaiSach
            // 
            this.txt_tenLoaiSach.Location = new System.Drawing.Point(133, 177);
            this.txt_tenLoaiSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenLoaiSach.Name = "txt_tenLoaiSach";
            this.txt_tenLoaiSach.Size = new System.Drawing.Size(252, 22);
            this.txt_tenLoaiSach.TabIndex = 1;
            // 
            // txt_maLoaiSach
            // 
            this.txt_maLoaiSach.Enabled = false;
            this.txt_maLoaiSach.Location = new System.Drawing.Point(133, 94);
            this.txt_maLoaiSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maLoaiSach.Name = "txt_maLoaiSach";
            this.txt_maLoaiSach.Size = new System.Drawing.Size(105, 22);
            this.txt_maLoaiSach.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Loại Sách";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 52);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(567, 359);
            this.dgv.TabIndex = 14;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm Kiếm: ";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(99, 14);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timKiem.TabIndex = 0;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // QuanLySach_LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(588, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySach_LoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LOẠI SÁCH";
            this.Load += new System.EventHandler(this.QuanLySach_LoaiSach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_khongLuu;
        private System.Windows.Forms.Button btn_chinhSua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenLoaiSach;
        private System.Windows.Forms.TextBox txt_maLoaiSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timKiem;
    }
}