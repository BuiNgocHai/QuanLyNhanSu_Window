using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
  public  class ThongKePhongBanChucVu_DAO
    {
        private static ThongKePhongBanChucVu_DAO instance;

        

        public ThongKePhongBanChucVu_DAO()
        {

        }

        public static ThongKePhongBanChucVu_DAO Instance {
            get
            {
                if (instance == null)
                    instance = new ThongKePhongBanChucVu_DAO();
                return instance;
            }
        }

        DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public void layDLTenPhongBan_DAO(GunaComboBox cb)
        {
            var item = from q in db.PHONGBAN6s
                       select new { q.MAPB, q.TENPB };
            cb.DataSource = item;
            cb.DisplayMember = "TENPB";
            cb.ValueMember = "MAPB";
        }

        public void thongKeTheoPhongBan(String tenPhongBan, GunaDataGridView dgv)
        {
            //from HOSO6s in db.HOSO6s
            //where
            //  HOSO6s.PHONGBAN6.TENPB == "Kinh doanh"
            //select new
            //{
            //    HOSO6s.MANV,
            //    HOSO6s.HOTEN,
            //    HOSO6s.NGAYSINH,
            //    HOSO6s.GIOITINH,
            //    HOSO6s.SODT,
            //    HOSO6s.EMAIL,
            //    HOSO6s.NGAYTD,
            //    HOSO6s.PHONGBAN6.TENPB
            //}
        }
    }
}
