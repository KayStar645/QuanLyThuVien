namespace QuanLyThuVien
{
    partial class Form_Sach
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
            this.pnl_FSach = new System.Windows.Forms.Panel();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_TheLoai = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dvg_ThongTinSach = new System.Windows.Forms.DataGridView();
            this.pnl_FSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ThongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_FSach
            // 
            this.pnl_FSach.Controls.Add(this.btn_ThemSach);
            this.pnl_FSach.Controls.Add(this.btn_Clear);
            this.pnl_FSach.Controls.Add(this.label6);
            this.pnl_FSach.Controls.Add(this.btn_TimKiem);
            this.pnl_FSach.Controls.Add(this.txt_NhaXuatBan);
            this.pnl_FSach.Controls.Add(this.txt_TacGia);
            this.pnl_FSach.Controls.Add(this.txt_TenSach);
            this.pnl_FSach.Controls.Add(this.txt_TheLoai);
            this.pnl_FSach.Controls.Add(this.txt_MaSach);
            this.pnl_FSach.Controls.Add(this.label5);
            this.pnl_FSach.Controls.Add(this.label4);
            this.pnl_FSach.Controls.Add(this.label2);
            this.pnl_FSach.Controls.Add(this.label1);
            this.pnl_FSach.Controls.Add(this.label);
            this.pnl_FSach.Controls.Add(this.dvg_ThongTinSach);
            this.pnl_FSach.Location = new System.Drawing.Point(2, 0);
            this.pnl_FSach.Name = "pnl_FSach";
            this.pnl_FSach.Size = new System.Drawing.Size(1231, 660);
            this.pnl_FSach.TabIndex = 0;
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.BackColor = System.Drawing.Color.Aqua;
            this.btn_ThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ThemSach.Location = new System.Drawing.Point(882, 201);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(119, 42);
            this.btn_ThemSach.TabIndex = 16;
            this.btn_ThemSach.Text = "Thêm";
            this.btn_ThemSach.UseVisualStyleBackColor = false;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(1024, 201);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 42);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("VNI-Zap", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 9);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.label6.Size = new System.Drawing.Size(406, 85);
            this.label6.TabIndex = 14;
            this.label6.Text = "THƯ VIỆN HUFI";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.Location = new System.Drawing.Point(741, 201);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 42);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_NhaXuatBan
            // 
            this.txt_NhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NhaXuatBan.Location = new System.Drawing.Point(913, 106);
            this.txt_NhaXuatBan.Multiline = true;
            this.txt_NhaXuatBan.Name = "txt_NhaXuatBan";
            this.txt_NhaXuatBan.Size = new System.Drawing.Size(149, 40);
            this.txt_NhaXuatBan.TabIndex = 12;
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TacGia.Location = new System.Drawing.Point(438, 201);
            this.txt_TacGia.Multiline = true;
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(271, 40);
            this.txt_TacGia.TabIndex = 10;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenSach.Location = new System.Drawing.Point(438, 109);
            this.txt_TenSach.Multiline = true;
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(271, 40);
            this.txt_TenSach.TabIndex = 9;
            // 
            // txt_TheLoai
            // 
            this.txt_TheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TheLoai.Location = new System.Drawing.Point(132, 199);
            this.txt_TheLoai.Multiline = true;
            this.txt_TheLoai.Name = "txt_TheLoai";
            this.txt_TheLoai.Size = new System.Drawing.Size(149, 40);
            this.txt_TheLoai.TabIndex = 8;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(132, 109);
            this.txt_MaSach.Multiline = true;
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(149, 40);
            this.txt_MaSach.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 197);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label5.Size = new System.Drawing.Size(112, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 199);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label4.Size = new System.Drawing.Size(107, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 109);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 109);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(310, 109);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label.Size = new System.Drawing.Size(122, 40);
            this.label.TabIndex = 1;
            this.label.Text = "Tên sách";
            // 
            // dvg_ThongTinSach
            // 
            this.dvg_ThongTinSach.AllowUserToAddRows = false;
            this.dvg_ThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_ThongTinSach.Location = new System.Drawing.Point(0, 275);
            this.dvg_ThongTinSach.Name = "dvg_ThongTinSach";
            this.dvg_ThongTinSach.Size = new System.Drawing.Size(1226, 359);
            this.dvg_ThongTinSach.TabIndex = 0;
            // 
            // Form_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.pnl_FSach);
            this.Name = "Form_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Sach";
            this.pnl_FSach.ResumeLayout(false);
            this.pnl_FSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ThongTinSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_FSach;
        private System.Windows.Forms.DataGridView dvg_ThongTinSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_NhaXuatBan;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_TheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ThemSach;
    }
}