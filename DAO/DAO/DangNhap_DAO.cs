using System.Data;
using System.Linq;
namespace DAO
{
    public class DangNhap_DAO
    {
        private static DangNhap_DAO instance;

        public static DangNhap_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DangNhap_DAO();
                }

                return instance;
            }
        }

        public DangNhap_DAO()
        {

        }

        public int dangNhap(string txtTaiKhoan, string txtMatKhau)
        {
            txtMatKhau = txtMatKhau.ToUpper();
            txtTaiKhoan = txtTaiKhoan.ToUpper();
            DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();
            var q = from cust in db.HOSO6s
                    where cust.TAIKHOAN == txtTaiKhoan && cust.MATKHAU == txtMatKhau.ToUpper()
                    select new { cust.TAIKHOAN, cust.MATKHAU, cust.QUYEN };
            foreach (var item in q)
            {
                if (item.TAIKHOAN == txtTaiKhoan && item.MATKHAU == txtMatKhau && item.QUYEN == "ADMIN")
                {
                    return 1;
                }
                else if (item.TAIKHOAN == txtTaiKhoan && item.MATKHAU == txtMatKhau && item.QUYEN == "NHANVIEN")
                {
                    return 2;
                }
            }




            return 0;
        }
    }
}
