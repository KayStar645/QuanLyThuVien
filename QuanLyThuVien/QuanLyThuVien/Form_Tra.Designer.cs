namespace QuanLyThuVien
{
    partial class Form_Tra
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
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_ThongTin = new System.Windows.Forms.DataGridView();
            this.txt_MaMuonTra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.cbx_SoLuong = new System.Windows.Forms.ComboBox();
            this.pnl_FSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_FSach
            // 
            this.pnl_FSach.Controls.Add(this.cbx_SoLuong);
            this.pnl_FSach.Controls.Add(this.btn_TimKiem);
            this.pnl_FSach.Controls.Add(this.dgv_ThongTin);
            this.pnl_FSach.Controls.Add(this.txt_MaMuonTra);
            this.pnl_FSach.Controls.Add(this.label2);
            this.pnl_FSach.Controls.Add(this.label1);
            this.pnl_FSach.Controls.Add(this.label6);
            this.pnl_FSach.Controls.Add(this.btn_DangKy);
            this.pnl_FSach.Location = new System.Drawing.Point(3, 4);
            this.pnl_FSach.Name = "pnl_FSach";
            this.pnl_FSach.Size = new System.Drawing.Size(989, 581);
            this.pnl_FSach.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.Location = new System.Drawing.Point(656, 183);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(170, 42);
            this.btn_TimKiem.TabIndex = 23;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_ThongTin
            // 
            this.dgv_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTin.Location = new System.Drawing.Point(91, 269);
            this.dgv_ThongTin.Name = "dgv_ThongTin";
            this.dgv_ThongTin.Size = new System.Drawing.Size(750, 60);
            this.dgv_ThongTin.TabIndex = 21;
            // 
            // txt_MaMuonTra
            // 
            this.txt_MaMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMuonTra.Location = new System.Drawing.Point(208, 135);
            this.txt_MaMuonTra.Multiline = true;
            this.txt_MaMuonTra.Name = "txt_MaMuonTra";
            this.txt_MaMuonTra.Size = new System.Drawing.Size(216, 34);
            this.txt_MaMuonTra.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 133);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 133);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã mượn trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 21);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.label6.Size = new System.Drawing.Size(289, 83);
            this.label6.TabIndex = 14;
            this.label6.Text = "TRẢ SÁCH";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.Aqua;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DangKy.Location = new System.Drawing.Point(792, 531);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(170, 42);
            this.btn_DangKy.TabIndex = 13;
            this.btn_DangKy.Text = "Xác nhận";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // cbx_SoLuong
            // 
            this.cbx_SoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SoLuong.FormattingEnabled = true;
            this.cbx_SoLuong.Items.AddRange(new object[] {
            "Tất cả",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_SoLuong.Location = new System.Drawing.Point(644, 145);
            this.cbx_SoLuong.Name = "cbx_SoLuong";
            this.cbx_SoLuong.Size = new System.Drawing.Size(137, 28);
            this.cbx_SoLuong.TabIndex = 24;
            // 
            // Form_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 589);
            this.Controls.Add(this.pnl_FSach);
            this.Name = "Form_Tra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tra";
            this.pnl_FSach.ResumeLayout(false);
            this.pnl_FSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_FSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaMuonTra;
        private System.Windows.Forms.DataGridView dgv_ThongTin;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox cbx_SoLuong;
    }
}