namespace QuanLyThuVien
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.pictureBox2);
            this.pnl_Main.Controls.Add(this.pictureBox1);
            this.pnl_Main.Controls.Add(this.menuStrip1);
            this.pnl_Main.Location = new System.Drawing.Point(0, -1);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1235, 665);
            this.pnl_Main.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyThuVien.Properties.Resources.logo_ThuVien;
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.Panel_ThuVien;
            this.pictureBox1.Location = new System.Drawing.Point(221, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem1,
            this.sáchToolStripMenuItem,
            this.đangMượnToolStripMenuItem,
            this.quảnLýThẻToolStripMenuItem,
            this.đăngKýToolStripMenuItem});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.trangChủToolStripMenuItem.Text = "Menu";
            // 
            // trangChủToolStripMenuItem1
            // 
            this.trangChủToolStripMenuItem1.Name = "trangChủToolStripMenuItem1";
            this.trangChủToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.trangChủToolStripMenuItem1.Text = "Trang chủ";
            this.trangChủToolStripMenuItem1.Click += new System.EventHandler(this.trangChủToolStripMenuItem1_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // đangMượnToolStripMenuItem
            // 
            this.đangMượnToolStripMenuItem.Name = "đangMượnToolStripMenuItem";
            this.đangMượnToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.đangMượnToolStripMenuItem.Text = "Mượn Trả";
            this.đangMượnToolStripMenuItem.Click += new System.EventHandler(this.đangMượnToolStripMenuItem_Click);
            // 
            // quảnLýThẻToolStripMenuItem
            // 
            this.quảnLýThẻToolStripMenuItem.Name = "quảnLýThẻToolStripMenuItem";
            this.quảnLýThẻToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quảnLýThẻToolStripMenuItem.Text = "Quản lý độc giả";
            this.quảnLýThẻToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThẻToolStripMenuItem_Click);
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 294);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.label1.Size = new System.Drawing.Size(1112, 365);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.pnl_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đangMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThẻToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

