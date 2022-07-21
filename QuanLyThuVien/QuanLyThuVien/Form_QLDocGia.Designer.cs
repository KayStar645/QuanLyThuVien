namespace QuanLyThuVien
{
    partial class Form_QLDocGia
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
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cbx_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.txt_MaDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dvg_ThongTinDG = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_FSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ThongTinDG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_FSach
            // 
            this.pnl_FSach.Controls.Add(this.cbx_GioiTinh);
            this.pnl_FSach.Controls.Add(this.label3);
            this.pnl_FSach.Controls.Add(this.btn_Clear);
            this.pnl_FSach.Controls.Add(this.btn_TimKiem);
            this.pnl_FSach.Controls.Add(this.cbx_TinhTrang);
            this.pnl_FSach.Controls.Add(this.label2);
            this.pnl_FSach.Controls.Add(this.txt_TenDG);
            this.pnl_FSach.Controls.Add(this.txt_MaDG);
            this.pnl_FSach.Controls.Add(this.label1);
            this.pnl_FSach.Controls.Add(this.label);
            this.pnl_FSach.Controls.Add(this.dvg_ThongTinDG);
            this.pnl_FSach.Controls.Add(this.label6);
            this.pnl_FSach.Location = new System.Drawing.Point(2, 0);
            this.pnl_FSach.Name = "pnl_FSach";
            this.pnl_FSach.Size = new System.Drawing.Size(1231, 660);
            this.pnl_FSach.TabIndex = 2;
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.DisplayMember = " ";
            this.cbx_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cbx_GioiTinh.Location = new System.Drawing.Point(269, 224);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(149, 28);
            this.cbx_GioiTinh.TabIndex = 26;
            this.cbx_GioiTinh.ValueMember = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 216);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label3.Size = new System.Drawing.Size(116, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giới tính";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(992, 224);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 42);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.Location = new System.Drawing.Point(841, 224);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 42);
            this.btn_TimKiem.TabIndex = 22;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cbx_TinhTrang
            // 
            this.cbx_TinhTrang.DisplayMember = " ";
            this.cbx_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TinhTrang.FormattingEnabled = true;
            this.cbx_TinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Đã trả",
            "Chưa trả"});
            this.cbx_TinhTrang.Location = new System.Drawing.Point(594, 224);
            this.cbx_TinhTrang.Name = "cbx_TinhTrang";
            this.cbx_TinhTrang.Size = new System.Drawing.Size(164, 28);
            this.cbx_TinhTrang.TabIndex = 21;
            this.cbx_TinhTrang.ValueMember = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 218);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label2.Size = new System.Drawing.Size(130, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tình trạng";
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenDG.Location = new System.Drawing.Point(594, 144);
            this.txt_TenDG.Multiline = true;
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.Size = new System.Drawing.Size(271, 40);
            this.txt_TenDG.TabIndex = 19;
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDG.Location = new System.Drawing.Point(269, 144);
            this.txt_MaDG.Multiline = true;
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.Size = new System.Drawing.Size(149, 40);
            this.txt_MaDG.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 144);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã độc giả";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(446, 144);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label.Size = new System.Drawing.Size(142, 40);
            this.label.TabIndex = 16;
            this.label.Text = "Tên độc giả";
            // 
            // dvg_ThongTinDG
            // 
            this.dvg_ThongTinDG.AllowUserToAddRows = false;
            this.dvg_ThongTinDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_ThongTinDG.Location = new System.Drawing.Point(6, 286);
            this.dvg_ThongTinDG.Name = "dvg_ThongTinDG";
            this.dvg_ThongTinDG.Size = new System.Drawing.Size(1222, 348);
            this.dvg_ThongTinDG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("VNI-Zap", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 24);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.label6.Size = new System.Drawing.Size(406, 85);
            this.label6.TabIndex = 14;
            this.label6.Text = "THƯ VIỆN HUFI";
            // 
            // Form_QLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.pnl_FSach);
            this.Name = "Form_QLDocGia";
            this.Text = "Form_QLDocGia";
            this.pnl_FSach.ResumeLayout(false);
            this.pnl_FSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ThongTinDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_FSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvg_ThongTinDG;
        private System.Windows.Forms.TextBox txt_TenDG;
        private System.Windows.Forms.TextBox txt_MaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_TinhTrang;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_GioiTinh;
    }
}