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
    public partial class Form_Sach : Form
    {
        public Form_Sach()
        {
            InitializeComponent();
            Load();
        }

        ThuVienDataContext db = new ThuVienDataContext();

        private void Load()
        {
            dvg_ThongTinSach.Rows.Clear();

            var ketqua = from sach in db.SACHes
                         join theLoai in db.THELOAIs on sach.MATHELOAI equals theLoai.MATHELOAI
                         join tacGia in db.TACGIAs on sach.MATACGIA equals tacGia.MATACGIA
                         join nhaXuatBan in db.NHAXUATBANs on sach.MANXB equals nhaXuatBan.MANXB
                         select new
                         {
                             MaSach = sach.MASACH,
                             TenSach = sach.TENSACH,
                             TenTheLoai = theLoai.TENTHELOAI,
                             TenTacGia = tacGia.TENTACGIA,
                             NamXuatBan = sach.NAMXUATBAN,
                             NhaXuatBan = nhaXuatBan.TENNXB,
                             SoLuong = sach.SOLUONG,
                             ViTri = theLoai.VITRI
                         };

            dvg_ThongTinSach.DataSource = ketqua;

            dvg_ThongTinSach.Columns[0].Width = 150;
            dvg_ThongTinSach.Columns[1].Width = 180;
            dvg_ThongTinSach.Columns[2].Width = 170;
            dvg_ThongTinSach.Columns[3].Width = 181;
            dvg_ThongTinSach.Columns[4].Width = 150;
            dvg_ThongTinSach.Columns[5].Width = 135;
            dvg_ThongTinSach.Columns[6].Width = 100;
            dvg_ThongTinSach.Columns[7].Width = 100;

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var ketqua = from sach in db.SACHes
                         join theLoai in db.THELOAIs on sach.MATHELOAI equals theLoai.MATHELOAI
                         join tacGia in db.TACGIAs on sach.MATACGIA equals tacGia.MATACGIA
                         join nhaXuatBan in db.NHAXUATBANs on sach.MANXB equals nhaXuatBan.MANXB
                         select new
                         {
                             MaSach = sach.MASACH,
                             TenSach = sach.TENSACH,
                             TenTheLoai = theLoai.TENTHELOAI,
                             TenTacGia = tacGia.TENTACGIA,
                             NamXuatBan = sach.NAMXUATBAN,
                             NhaXuatBan = nhaXuatBan.TENNXB,
                             SoLuong = sach.SOLUONG,
                             ViTri = theLoai.VITRI
                         };

            var ketQua = ketqua;
            bool flag = false;

            //Mã sách
            if(txt_MaSach.Text != "")
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

            //Tên thể loại
            if (txt_TheLoai.Text != "")
            {
                flag = true;
                ketQua = from theLoai in ketQua
                         where theLoai.TenTheLoai  == txt_TheLoai.Text
                         select theLoai;
            }

            //Tên tác giả
            if (txt_TacGia.Text != "")
            {
                flag = true;
                ketQua = from tacGia in ketQua
                         where tacGia.TenTacGia == txt_TacGia.Text
                         select tacGia;
            }

            //Nhà xuất bản
            if (txt_NhaXuatBan.Text != "")
            {
                flag = true;
                ketQua = from xuatBan in ketQua
                         where xuatBan.NhaXuatBan == txt_NhaXuatBan.Text
                         select xuatBan;
            }


            dvg_ThongTinSach.Rows.Clear();

            if (flag)
            {
                dvg_ThongTinSach.DataSource = ketQua;
            }
            else
            {
                Load();
            } 
                
        }

        //Reset
        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TheLoai.Text = "";
            txt_TacGia.Text = "";
            txt_NhaXuatBan.Text = "";
            Load();
        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            Form_ThemSach themSach = new Form_ThemSach();
            themSach.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var ketqua = from sach in db.SACHes
                         join theLoai in db.THELOAIs on sach.MATHELOAI equals theLoai.MATHELOAI
                         join tacGia in db.TACGIAs on sach.MATACGIA equals tacGia.MATACGIA
                         join nhaXuatBan in db.NHAXUATBANs on sach.MANXB equals nhaXuatBan.MANXB
                         select new
                         {
                             MaSach = sach.MASACH,
                             TenSach = sach.TENSACH,
                             TenTheLoai = theLoai.TENTHELOAI,
                             TenTacGia = tacGia.TENTACGIA,
                             NamXuatBan = sach.NAMXUATBAN,
                             NhaXuatBan = nhaXuatBan.TENNXB
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
        }
    }
}
