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
    public partial class Form_Muon_Tra : Form
    {
        public Form_Muon_Tra()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            ThuVienDataContext db = new ThuVienDataContext();

            var ketqua = from chiTiet in db.CHITIETMUONTRAs
                         join muonTra in db.MUONTRAs on chiTiet.MAMUONTRA equals muonTra.MAMUONTRA
                         join theTV in db.THETHUVIENs on muonTra.SOTHE equals theTV.SOTHE
                         join docGia in db.DOCGIAs on theTV.MADOCGIA equals docGia.MADOCGIA
                         join sach in db.SACHes on chiTiet.MASACH equals sach.MASACH
                         select new
                         {
                             MaMuon = muonTra.MAMUONTRA,
                             MaSach = chiTiet.MASACH,
                             TenSach = sach.TENSACH,
                             TheThuVien = muonTra.SOTHE,
                             TenDocGia = docGia.TENDOCGIA,
                             NgayMuon = muonTra.NGAYMUON,
                             NgayTra = chiTiet.NGAYTRA,
                             TinhTrang = chiTiet.TINHTRANG,
                             SoLuong = chiTiet.SOLUONG
                         };

            dvg_TTDangMuon.DataSource = ketqua;


            dvg_TTDangMuon.Columns[0].Width = 150;
            dvg_TTDangMuon.Columns[1].Width = 150;
            dvg_TTDangMuon.Columns[2].Width = 210;
            dvg_TTDangMuon.Columns[3].Width = 100;
            dvg_TTDangMuon.Columns[4].Width = 173;
            dvg_TTDangMuon.Columns[5].Width = 100;
            dvg_TTDangMuon.Columns[6].Width = 100;
            dvg_TTDangMuon.Columns[7].Width = 100;
            dvg_TTDangMuon.Columns[8].Width = 100;

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();

            var ketqua = from chiTiet in db.CHITIETMUONTRAs
                         join muonTra in db.MUONTRAs on chiTiet.MAMUONTRA equals muonTra.MAMUONTRA
                         join theTV in db.THETHUVIENs on muonTra.SOTHE equals theTV.SOTHE
                         join docGia in db.DOCGIAs on theTV.MADOCGIA equals docGia.MADOCGIA
                         join sach in db.SACHes on chiTiet.MASACH equals sach.MASACH
                         select new
                         {
                             MaMuon = muonTra.MAMUONTRA,
                             MaSach = chiTiet.MASACH,
                             TenSach = sach.TENSACH,
                             TheThuVien = muonTra.SOTHE,
                             TenDocGia = docGia.TENDOCGIA,
                             NgayMuon = muonTra.NGAYMUON,
                             NgayTra = chiTiet.NGAYTRA,
                             TinhTrang = chiTiet.TINHTRANG,
                             SoLuong = chiTiet.SOLUONG
                         };

            var ketQua = ketqua;
            bool flag = false;

            //Mã sách
            if (txt_MaSach.Text != "")
            {
                flag = true;
                ketQua = from sach in ketQua
                         where sach.MaSach == txt_MaSach.Text
                         select sach;
            }

            //Tên sách
            if (txt_TenSach.Text != "")
            {
                flag = true;
                ketQua = from sach in ketQua
                         where sach.TenSach == txt_TenSach.Text
                         select sach;
            }

            //Thẻ thư viện
            if (txt_TheTV.Text != "")
            {
                flag = true;
                ketQua = from theTV in ketQua
                         where theTV.TheThuVien == txt_TheTV.Text
                         select theTV;
            }

            //Tên độc giả
            if (txt_TenDG.Text != "")
            {
                flag = true;
                ketQua = from docGia in ketQua
                         where docGia.TenDocGia == txt_TenDG.Text
                         select docGia;
            }

            //Tình trạng
            if(cbx_TinhTrang.Text != "")
            {
                if(cbx_TinhTrang.Text != "Tất cả")
                {
                    if(cbx_TinhTrang.Text == "Quá hạn")
                    {
                        flag = true;
                        ketQua = from tinhTrang in ketQua
                                 where tinhTrang.NgayTra < DateTime.Now && tinhTrang.TinhTrang == "Chưa trả"
                                 select tinhTrang;
                    }    
                    else
                    {
                        flag = true;
                        ketQua = from tinhTrang in ketQua
                                 where tinhTrang.TinhTrang == cbx_TinhTrang.Text
                                 select tinhTrang;
                    }    
                }    
            }    


            dvg_TTDangMuon.Rows.Clear();

            if (flag)
            {
                dvg_TTDangMuon.DataSource = ketQua;
            }
            else
            {
                Load();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_TenDG.Text = "";
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TheTV.Text = "";
            Load();
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            Form_Muon form_Muon = new Form_Muon();
            form_Muon.ShowDialog();

            
        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            Form_Tra tra = new Form_Tra();
            tra.ShowDialog();
        }
    }
}
