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
    public partial class Form_Muon : Form
    {
        public Form_Muon()
        {
            InitializeComponent();

            Load();           
        }

        private void Load()
        {
            ThuVienDataContext db = new ThuVienDataContext();
            //Mã số mượn trả
            var ketqua = from ma in db.MUONTRAs
                         select ma.MAMUONTRA;
            string maMT = ketqua.Max().ToString();

            int stt = int.Parse(maMT.Substring(2)) + 1;
            maMT = stt.ToString();
            while (maMT.Length < 3)
            {
                maMT = "0" + maMT;
            }

            txt_MaSoMuon.Text = "MT" + maMT;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_GhiChu.Text = "";
            txt_MaNV.Text = "";
            txt_MaSách.Text = "";
            txt_SoTheTV.Text = "";
            Load();
        }

        //Này là mượn nha
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();

            try
            {
                MUONTRA muonTra = new MUONTRA();
                muonTra.MAMUONTRA = txt_MaSoMuon.Text;
                muonTra.SOTHE = txt_SoTheTV.Text;
                muonTra.MANV = txt_MaNV.Text;
                muonTra.NGAYMUON = dateTP_NgayMuon.Value;
                db.MUONTRAs.InsertOnSubmit(muonTra);

                CHITIETMUONTRA chiTiet = new CHITIETMUONTRA();
                chiTiet.MASACH = txt_MaSách.Text;
                chiTiet.MAMUONTRA = txt_MaSoMuon.Text;
                chiTiet.GHICHU = txt_GhiChu.Text;
                chiTiet.TINHTRANG = "Chưa trả";
                chiTiet.NGAYTRA = dateTP_NgayTra.Value;
                chiTiet.SOLUONG = Convert.ToInt32(cbx_SoLuong.Text);
                db.CHITIETMUONTRAs.InsertOnSubmit(chiTiet);

                db.SubmitChanges();
                MessageBox.Show("Mượn thành công!");
                Load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Mượn không thành công!");
            }
           

        }
    }
}
