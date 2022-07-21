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
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();

            suKien();
        }

        private void suKien()
        {
            ThuVienDataContext db = new ThuVienDataContext();
            //Mã số độc giả
            var ketqua = from docGia in db.DOCGIAs
                         select docGia.MADOCGIA;
            string maDG = ketqua.Max().ToString();

            int stt = int.Parse(maDG.Substring(2)) + 1;
            maDG = stt.ToString();
            while(maDG.Length < 3)
            {
                maDG = "0" + maDG;
            }    

            txt_MaSoDG.Text = "DG" + maDG;


            //Mã số thẻ
            ketqua = from theTV in db.THETHUVIENs
                     select theTV.SOTHE;
            string soThe = ketqua.Max().ToString();
            
            stt = int.Parse(soThe.Substring(2)) + 1;
            soThe = stt.ToString();
            while (soThe.Length < 3)
            {
                soThe = "0" + soThe;
            }

            txt_MaSoThe.Text = "TH" + soThe;

            //Ngày hết hạn
            dateTP_NgayHetHan.Value = dateTP_NgayLam.Value.AddYears(7);

            dateTP_NgaySinh.Value = DateTime.Now.AddYears(-18);


        }    

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();

            

            try
            {
                DOCGIA docGia = new DOCGIA();
                docGia.MADOCGIA = txt_MaSoDG.Text;
                docGia.TENDOCGIA = txt_HoTen.Text;
                docGia.GIOITINH = cbx_GioiTinh.Text;
                docGia.NGAYSINHDG = dateTP_NgaySinh.Value;
                docGia.DIACHI = txt_DiaChi.Text;
                docGia.SDT = txt_SDT.Text;
                db.DOCGIAs.InsertOnSubmit(docGia);

                THETHUVIEN theThuVien = new THETHUVIEN();
                theThuVien.SOTHE = txt_MaSoThe.Text;
                theThuVien.MADOCGIA = txt_MaSoDG.Text;
                theThuVien.NGAYBATDAU = dateTP_NgayLam.Value;
                theThuVien.NGAYHETHAN = dateTP_NgayHetHan.Value;
                theThuVien.GHICHUTHE = "Mới";
                db.THETHUVIENs.InsertOnSubmit(theThuVien);

                //Xác nhận thêm vô
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Đăng ký không thành công!");
                return;
            }

            MessageBox.Show("Đăng ký thành công!");
            suKien();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";

            dateTP_NgaySinh.Value = DateTime.Now.AddYears(-18);
        }
    }
}
