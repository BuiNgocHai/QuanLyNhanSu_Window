using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using Guna.UI.WinForms;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace BUS
{
    public class QuanLyHoSo_BUS
    {
        private static QuanLyHoSo_BUS instance;
        private HoSo_DAO qlhs = new HoSo_DAO();
        public static QuanLyHoSo_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyHoSo_BUS();
                }

                return instance;
            }
        }
        public QuanLyHoSo_BUS()
        {

        }

        public void hienThi(DataGridView dt)
        {
            qlhs.hienThi(dt);
        }

        public void loadCBBox(ComboBox cb)
        {
            qlhs.loadCBBox(cb);
        }

        public bool themHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaTextBox nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Text;
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Text;
            string mapb = mpb.SelectedValue.ToString();
            string taikhoan = tk.Text;
            string matkhau = mk.Text;
            string quyen = q.Text;
            bool output = qlhs.themHoSo(manv, hoten, Convert.ToDateTime(ngaysinh), gioitinh, sodienthoai, email, Convert.ToDateTime(ngaytuyendung), mapb, taikhoan, matkhau, quyen);
            return output;
        }

        public bool suaHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaTextBox nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Text;
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Text;
            string mapb = mpb.SelectedValue.ToString();
            string taikhoan = tk.Text;
            string matkhau = mk.Text;
            string quyen = q.Text;
            bool output = qlhs.suaHoSo(manv, hoten, Convert.ToDateTime(ngaysinh), gioitinh, sodienthoai, email, Convert.ToDateTime(ngaytuyendung), mapb, taikhoan, matkhau, quyen);
            return output;
        }
        public void timKiemHoSoNhanVien(DataGridView dt,GunaTextBox mnv)
        {
            string manv = mnv.Text;
            qlhs.timKiemHoSo(dt,manv);
        }
        public bool xoaHoSoNhanVien(GunaTextBox mnv)
        {
            string manv = mnv.Text;
            bool output = qlhs.xoaHoSo(manv);
            return output;
        }
    }
}
