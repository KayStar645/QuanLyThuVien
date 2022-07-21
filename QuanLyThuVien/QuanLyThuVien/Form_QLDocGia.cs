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
    public partial class Form_QLDocGia : Form
    {
        public Form_QLDocGia()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            ThuVienDataContext db = new ThuVienDataContext();

            dvg_ThongTinDG.Rows.Clear();

            var a = from p in db.THETHUVIENs
                    join c in db.MUONTRAs on p.SOTHE equals c.SOTHE into catGroup
                    from cat in catGroup.DefaultIfEmpty()
                    select new
                    {
                        Product = p.MADOCGIA,
                        Category = cat == null ? "<null>" : cat.MANV
                    };
            


            var ketqua = from docGia in db.DOCGIAs
                         join theThuVien in db.THETHUVIENs on docGia.MADOCGIA equals theThuVien.MADOCGIA
                             join muonTra in db.MUONTRAs on theThuVien.SOTHE equals muonTra.SOTHE into Group1
                             from thongTin1 in Group1.DefaultIfEmpty()
                                 join chiTiet in db.CHITIETMUONTRAs on thongTin1.MAMUONTRA equals chiTiet.MAMUONTRA into Group2
                                 from thongTin2 in Group2.DefaultIfEmpty()
                         select new
                         {
                             MaDocGia = docGia.MADOCGIA,
                             TenDocGia = docGia.TENDOCGIA,
                             GioiTinh = docGia.GIOITINH,
                             NgaySinh = docGia.NGAYSINHDG,
                             DiaChi = docGia.DIACHI,
                             SDT = docGia.SDT,
                             MaThe = theThuVien.SOTHE,
                             NgayLam = theThuVien.NGAYBATDAU,
                             NgayHetHan = theThuVien.NGAYHETHAN,
                             SoLuong = thongTin2 == null ? "null" : thongTin2.SOLUONG.ToString(),
                             TinhTrang = thongTin2 == null ? "null" : thongTin2.TINHTRANG
                         };

            dvg_ThongTinDG.DataSource = ketqua;

            dvg_ThongTinDG.Columns[0].Width = 100;
            dvg_ThongTinDG.Columns[1].Width = 163;
            dvg_ThongTinDG.Columns[2].Width = 80;
            dvg_ThongTinDG.Columns[3].Width = 100;
            dvg_ThongTinDG.Columns[4].Width = 177;
            dvg_ThongTinDG.Columns[5].Width = 100;
            dvg_ThongTinDG.Columns[6].Width = 100;
            dvg_ThongTinDG.Columns[7].Width = 110;
            dvg_ThongTinDG.Columns[8].Width = 110;
            dvg_ThongTinDG.Columns[9].Width = 60;
            dvg_ThongTinDG.Columns[10].Width = 62;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaDG.Text = "";
            txt_TenDG.Text = "";
            Load();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();

            dvg_ThongTinDG.Rows.Clear();

            var ketqua = from docGia in db.DOCGIAs
                         join theThuVien in db.THETHUVIENs on docGia.MADOCGIA equals theThuVien.MADOCGIA
                         join muonTra in db.MUONTRAs on theThuVien.SOTHE equals muonTra.SOTHE
                         join chiTiet in db.CHITIETMUONTRAs on muonTra.MAMUONTRA equals chiTiet.MAMUONTRA
                         select new
                         {
                             MaDocGia = docGia.MADOCGIA,
                             TenDocGia = docGia.TENDOCGIA,
                             GioiTinh = docGia.GIOITINH,
                             NgaySinh = docGia.NGAYSINHDG,
                             DiaChi = docGia.DIACHI,
                             SDT = docGia.SDT,
                             MaThe = theThuVien.SOTHE,
                             NgayLam = theThuVien.NGAYBATDAU,
                             NgayHetHan = theThuVien.NGAYHETHAN,
                             SoLuong = chiTiet.SOLUONG,
                             TinhTrang = chiTiet.TINHTRANG
                         };

            var ketQua = ketqua;
            bool flag = false;

            //Mã độc giả
            if (txt_MaDG.Text != "")
            {
                flag = true;
                ketQua = from docGia in ketQua
                         where docGia.MaDocGia == txt_MaDG.Text
                         select docGia;
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
            if (cbx_TinhTrang.Text != "")
            {
                if(cbx_TinhTrang.Text != "Tất cả")
                {
                    flag = true;
                    ketQua = from docGia in ketQua
                             where docGia.TinhTrang == cbx_TinhTrang.Text
                             select docGia;
                }    
            }

            //Giới tính
            if (cbx_GioiTinh.Text != "")
            {
                if (cbx_GioiTinh.Text != "Tất cả")
                {
                    flag = true;
                    ketQua = from docGia in ketQua
                             where docGia.GioiTinh == cbx_GioiTinh.Text
                             select docGia;
                }    
            }
            if (flag)
                dvg_ThongTinDG.DataSource = ketQua;
            else
                Load();
        }
    }
}
