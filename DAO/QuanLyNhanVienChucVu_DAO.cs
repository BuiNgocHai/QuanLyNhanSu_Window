using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QuanLyNhanVienChucVu_DAO
    {

        private static QuanLyNhanVienChucVu_DAO instance;

        public static QuanLyNhanVienChucVu_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyNhanVienChucVu_DAO();
                }

                return instance;
            }
        }

        public QuanLyNhanVienChucVu_DAO()
        {

        }

        public  HoSoNV_DTO loadThongTinHoSo(string txtMaNV)
        {
            txtMaNV = txtMaNV.ToUpper(); 
            DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();
            var query = from q in db.HOSO6s
                        where q.MANV == txtMaNV
                        select new { q.MANV, q.HOTEN };
            HoSoNV_DTO nhanVien = new HoSoNV_DTO();
            foreach (var item in query)
            {
                nhanVien.MaNV = item.MANV;
                nhanVien.HoTen = item.HOTEN;
            }
            return nhanVien;            
        }
    }
}
