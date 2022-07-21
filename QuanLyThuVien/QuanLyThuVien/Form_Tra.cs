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
    public partial class Form_Tra : Form
    {
        public Form_Tra()
        {
            InitializeComponent();
        }

        private void Load()
        {
            ThuVienDataContext db = new ThuVienDataContext();

            var ketqua = from muonTra in db.MUONTRAs
                         join chiTiet in db.CHITIETMUONTRAs on muonTra.MAMUONTRA equals chiTiet.MAMUONTRA
                         select new
                         {
                             MaMuonTra = muonTra.MAMUONTRA,
                             TheTV = muonTra.SOTHE,
                             NgayMuon = muonTra.NGAYMUON,
                             MaSach = chiTiet.MASACH,
                             TinhTrang = chiTiet.TINHTRANG,
                             NgayTra = chiTiet.NGAYTRA,
                             SoLuong = chiTiet.SOLUONG
                         };

            dgv_ThongTin.DataSource = ketqua;

            for (int i = 0; i < dgv_ThongTin.Columns.Count; i++)
            {
                dgv_ThongTin.Columns[i].Width = 100;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();

            var ketqua = from muonTra in db.MUONTRAs
                          join chiTiet in db.CHITIETMUONTRAs on muonTra.MAMUONTRA equals chiTiet.MAMUONTRA
                          where muonTra.MAMUONTRA == txt_MaMuonTra.Text
                          select new
                          {
                              MaMuonTra = muonTra.MAMUONTRA,
                              TheTV = muonTra.SOTHE,
                              NgayMuon = muonTra.NGAYMUON,
                              MaSach = chiTiet.MASACH,
                              TinhTrang = chiTiet.TINHTRANG,
                              NgayTra = chiTiet.NGAYTRA,
                              SoLuong = chiTiet.SOLUONG
                          };

            dgv_ThongTin.DataSource = ketqua;

            for(int i = 0; i < dgv_ThongTin.Columns.Count; i++)
            {
                dgv_ThongTin.Columns[i].Width = 100;
            }    
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            ThuVienDataContext db = new ThuVienDataContext();


            try
            {

                var chiTiet = db.CHITIETMUONTRAs.
                    Where(mt => mt.MAMUONTRA == txt_MaMuonTra.Text &&
                    mt.TINHTRANG == "Chưa trả").Single();
                if(cbx_SoLuong.Text == "Tất cả" ||
                    int.Parse(cbx_SoLuong.Text) == chiTiet.SOLUONG)
                {
                    chiTiet.NGAYTRA = DateTime.Now;
                    chiTiet.TINHTRANG = "Đã trả";
                }    
                else if(int.Parse(cbx_SoLuong.Text) < chiTiet.SOLUONG)
                {
                    chiTiet.SOLUONG -= int.Parse(cbx_SoLuong.Text);
                }
                else
                {
                    MessageBox.Show("Trả sách không thành công!");
                    return;
                }
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!");
                return;
            }

            MessageBox.Show("Trả sách thành công!");
            Load();
        }
    }
}
