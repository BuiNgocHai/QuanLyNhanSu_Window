using System;
using System.Data;
using System.Data.Common;
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
                if(item.TAIKHOAN == txtTaiKhoan && item.MATKHAU == txtMatKhau && item.QUYEN=="ADMIN")
                {
                    return 1;
                }else if(item.TAIKHOAN == txtTaiKhoan && item.MATKHAU == txtMatKhau && item.QUYEN == "NHANVIEN")
                {
                    return 2;
                }
            }

            
            
            //foreach (var z in q)
            //{
            //    Console.WriteLine("\t {0} \t {1}", z.TAIKHOAN,z.MATKHAU);
            //  //  Console.WriteLine(String.Format("\t {0}"), z.MATKHAU);
            //   // Console.WriteLine("\t {1}", z.MATKHAU.ToString());
            //}

            //DbCommand dc = db.GetCommand(q);
            //Console.WriteLine("\nCommand Text: \n{0}", dc.CommandText);
            //Console.WriteLine("\nCommand Type: {0}", dc.CommandType);
            //Console.WriteLine("\nConnection: {0}", dc.Connection);
            //Console.ReadLine();
            return 0;
        }
    }
}
