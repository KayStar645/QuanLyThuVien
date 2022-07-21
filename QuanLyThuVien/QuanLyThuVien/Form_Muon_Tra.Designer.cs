namespace QuanLyThuVien
{
    partial class Form_Muon_Tra
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
            this.btn_Tra = new System.Windows.Forms.Button();
            this.cbx_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.txt_TheTV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dvg_TTDangMuon = new System.Windows.Forms.DataGridView();
            this.pnl_FSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TTDangMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_FSach
            // 
            this.pnl_FSach.Controls.Add(this.btn_Tra);
            this.pnl_FSach.Controls.Add(this.cbx_TinhTrang);
            this.pnl_FSach.Controls.Add(this.label4);
            this.pnl_FSach.Controls.Add(this.txt_TenDG);
            this.pnl_FSach.Controls.Add(this.txt_TheTV);
            this.pnl_FSach.Controls.Add(this.label2);
            this.pnl_FSach.Controls.Add(this.label3);
            this.pnl_FSach.Controls.Add(this.btn_Muon);
            this.pnl_FSach.Controls.Add(this.btn_Clear);
            this.pnl_FSach.Controls.Add(this.label6);
            this.pnl_FSach.Controls.Add(this.btn_TimKiem);
            this.pnl_FSach.Controls.Add(this.txt_TenSach);
            this.pnl_FSach.Controls.Add(this.txt_MaSach);
            this.pnl_FSach.Controls.Add(this.label1);
            this.pnl_FSach.Controls.Add(this.label);
            this.pnl_FSach.Controls.Add(this.dvg_TTDangMuon);
            this.pnl_FSach.Location = new System.Drawing.Point(2, 0);
            this.pnl_FSach.Name = "pnl_FSach";
            this.pnl_FSach.Size = new System.Drawing.Size(1231, 660);
            this.pnl_FSach.TabIndex = 1;
            // 
            // btn_Tra
            // 
            this.btn_Tra.BackColor = System.Drawing.Color.Aqua;
            this.btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Tra.Location = new System.Drawing.Point(916, 164);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(119, 42);
            this.btn_Tra.TabIndex = 23;
            this.btn_Tra.Text = "Trả";
            this.btn_Tra.UseVisualStyleBackColor = false;
            this.btn_Tra.Click += new System.EventHandler(this.btn_Tra_Click);
            // 
            // cbx_TinhTrang
            // 
            this.cbx_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TinhTrang.FormattingEnabled = true;
            this.cbx_TinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Đã trả",
            "Chưa trả",
            "Quá hạn"});
            this.cbx_TinhTrang.Location = new System.Drawing.Point(916, 112);
            this.cbx_TinhTrang.Name = "cbx_TinhTrang";
            this.cbx_TinhTrang.Size = new System.Drawing.Size(137, 28);
            this.cbx_TinhTrang.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 112);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label4.Size = new System.Drawing.Size(130, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tình trạng";
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenDG.Location = new System.Drawing.Point(438, 190);
            this.txt_TenDG.Multiline = true;
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.Size = new System.Drawing.Size(271, 40);
            this.txt_TenDG.TabIndex = 20;
            // 
            // txt_TheTV
            // 
            this.txt_TheTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TheTV.Location = new System.Drawing.Point(132, 190);
            this.txt_TheTV.Multiline = true;
            this.txt_TheTV.Name = "txt_TheTV";
            this.txt_TheTV.Size = new System.Drawing.Size(149, 40);
            this.txt_TheTV.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 190);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label2.Size = new System.Drawing.Size(106, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thẻ TV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 190);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label3.Size = new System.Drawing.Size(111, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên ĐG";
            // 
            // btn_Muon
            // 
            this.btn_Muon.BackColor = System.Drawing.Color.Aqua;
            this.btn_Muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Muon.Location = new System.Drawing.Point(753, 164);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(119, 42);
            this.btn_Muon.TabIndex = 16;
            this.btn_Muon.Text = "Mượn";
            this.btn_Muon.UseVisualStyleBackColor = false;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(916, 212);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 42);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(753, 212);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 42);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
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
            // txt_MaSach
            // 
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(132, 109);
            this.txt_MaSach.Multiline = true;
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(149, 40);
            this.txt_MaSach.TabIndex = 7;
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
            // dvg_TTDangMuon
            // 
            this.dvg_TTDangMuon.AllowUserToAddRows = false;
            this.dvg_TTDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_TTDangMuon.Location = new System.Drawing.Point(0, 275);
            this.dvg_TTDangMuon.Name = "dvg_TTDangMuon";
            this.dvg_TTDangMuon.Size = new System.Drawing.Size(1226, 359);
            this.dvg_TTDangMuon.TabIndex = 0;
            // 
            // Form_Muon_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.pnl_FSach);
            this.Name = "Form_Muon_Tra";
            this.Text = "Form_MuonTra";
            this.pnl_FSach.ResumeLayout(false);
            this.pnl_FSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TTDangMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_FSach;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvg_TTDangMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenDG;
        private System.Windows.Forms.TextBox txt_TheTV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbx_TinhTrang;
        private System.Windows.Forms.Button btn_Tra;
    }
}