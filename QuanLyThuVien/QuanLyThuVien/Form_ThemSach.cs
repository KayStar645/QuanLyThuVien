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
    public partial class Form_ThemSach : Form
    {
        public Form_ThemSach()
        {
            InitializeComponent();

            Load();
        }
        ThuVienDataContext db = new ThuVienDataContext();

        private void Load()
        {

            //Mã số độc giả
            var ketqua = from sach in db.SACHes
                         select sach.MASACH;
            string maSach = "";
            maSach = ketqua.Max().ToString();
            int stt = int.Parse(maSach.Substring(2)) + 1;
            maSach = stt.ToString();
            while (maSach.Length < 3)
            {
                maSach = "0" + maSach;
            }

            txt_MaSach.Text = "SH" + maSach;
        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {

            try
            {
                bool flag;
                if(txt_MaTL.Text != "")
                {
                    var tLoai = from TL in db.THELOAIs
                                select TL.MATHELOAI;
                    DataGridView kq = new DataGridView();
                    kq.DataSource = tLoai;

                    flag = true;
                    foreach (var x in tLoai)
                    {
                        if (x == txt_MaTL.Text)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        //Thêm thể loại
                        THELOAI theLoai = new THELOAI();
                        theLoai.MATHELOAI = txt_MaTL.Text;
                        theLoai.TENTHELOAI = txt_TenTL.Text;
                        theLoai.VITRI = txt_ViTriTL.Text;
                        db.THELOAIs.InsertOnSubmit(theLoai);
                    }
                }    
                
                if(txt_MaTG.Text != "")
                {
                    var tGia = from TG in db.TACGIAs
                               select TG.MATACGIA;
                    flag = true;
                    foreach (var x in tGia)
                    {
                        if (x == txt_MaTG.Text)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        //Thêm tác giả
                        TACGIA tacGia = new TACGIA();
                        tacGia.MATACGIA = txt_MaTG.Text;
                        tacGia.TENTACGIA = txt_TenTG.Text;
                        tacGia.DIACHITG = txt_DiaChiTG.Text;
                        db.TACGIAs.InsertOnSubmit(tacGia);
                    }
                }    

                if(txt_MaNXB.Text != "")
                {
                    var NXB = from nXB in db.NHAXUATBANs
                              select nXB.MANXB;

                    flag = true;
                    foreach (var x in NXB)
                    {
                        if (x == txt_MaNXB.Text)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        //Thêm nhà xuất bản
                        NHAXUATBAN nxb = new NHAXUATBAN();
                        nxb.MANXB = txt_MaNXB.Text;
                        nxb.TENNXB = txt_TenNXB.Text;
                        nxb.DIACHINXB = txt_DiaChiNXB.Text;
                        nxb.EMAIL = txt_EmailNXB.Text;
                        nxb.SDT_NXB = txt_SDT_NXB.Text;
                        db.NHAXUATBANs.InsertOnSubmit(nxb);
                    }
                }    

                
                if(txt_MaSach.Text != "")
                {
                    var SH = from sh in db.SACHes
                             select sh.MASACH;

                    flag = true;
                    foreach (var x in SH)
                    {
                        if (x == txt_MaSach.Text)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        //Thêm sách
                        SACH sach = new SACH();
                        sach.MASACH = txt_MaSach.Text;
                        sach.MATHELOAI = txt_MaTL.Text;
                        sach.MATACGIA = txt_MaTG.Text;
                        sach.MANXB = txt_MaNXB.Text;
                        sach.TENSACH = txt_TenSach.Text;
                        sach.NAMXUATBAN = dateTP_NamXB.Value;
                        sach.SOLUONG = int.Parse(txt_SoLuong.Text);
                        db.SACHes.InsertOnSubmit(sach);
                    }
                    else
                    {
                        //Update số lượng lại
                        var sach = db.SACHes.Where(mt => mt.MASACH == txt_MaSach.Text).Single();
                        sach.SOLUONG += int.Parse(txt_SoLuong.Text);
                        MessageBox.Show("Đã cập nhật lại số lượng!");
                        db.SubmitChanges();
                        return;
                    }
                }    
                
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi rồi!");
                return;
            }

            MessageBox.Show("Thêm sách thành công!");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaTL.Text = "";
            txt_TenTL.Text = "";
            txt_ViTriTL.Text = "";

            txt_MaTG.Text = "";
            txt_TenTG.Text = "";
            txt_DiaChiTG.Text = "";

            txt_MaNXB.Text = "";
            txt_TenNXB.Text = "";
            txt_DiaChiNXB.Text = "";
            txt_EmailNXB.Text = "";
            txt_SDT_NXB.Text = "";

            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            
        }
    }
}
