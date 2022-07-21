using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; //Bỏ cái border đi
            childForm.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(childForm); //Thêm cái form vào main
            pnl_Main.Tag = childForm;  //Đưa dữ liệu form con qua panel
            childForm.BringToFront();
            childForm.Show();
        }

        private void trangChủToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Sach());
        }

        private void đangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Muon_Tra());
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_DangKy());
        }

        private void quảnLýThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QLDocGia());
        }
    }
}
