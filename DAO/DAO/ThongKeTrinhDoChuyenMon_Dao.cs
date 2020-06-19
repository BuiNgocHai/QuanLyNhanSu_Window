using Guna.UI.WinForms;
using System.Linq;

namespace DAO.DAO
{
    public class ThongKeTrinhDoChuyenMon_Dao
    {
        public static ThongKeTrinhDoChuyenMon_Dao instance;

        public static ThongKeTrinhDoChuyenMon_Dao createInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeTrinhDoChuyenMon_Dao();
                }
                return instance;
            }
        }

        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public int thongKeTrinhDo(string strTK, GunaDataGridView dg, int kieu)
        {

            if (kieu == 1)
            {
                var query1 = from TRINHDOCHUYENMON6s in db.TRINHDOCHUYENMON6s
                             where
                               TRINHDOCHUYENMON6s.TRINHDO ==strTK
                             select new
                             {
                                 TRINHDOCHUYENMON6s.MANV,
                                 TRINHDOCHUYENMON6s.HOSO6.HOTEN,
                                 TRINHDOCHUYENMON6s.TRINHDO,
                                 TRINHDOCHUYENMON6s.NGANH,
                                 TRINHDOCHUYENMON6s.LOAIHINHDT,
                                 TRINHDOCHUYENMON6s.TRUONGDT
                             };
                if (query1.Count()>0)
                {
                    dg.DataSource = query1;
                    return 1;
                }
       
            }else
            {
                var query = from TRINHDOCHUYENMON6s in db.TRINHDOCHUYENMON6s
                            where
                              TRINHDOCHUYENMON6s.NGANH == strTK
                            select new
                            {
                                TRINHDOCHUYENMON6s.MANV,
                                TRINHDOCHUYENMON6s.HOSO6.HOTEN,
                                TRINHDOCHUYENMON6s.TRINHDO,
                                TRINHDOCHUYENMON6s.NGANH,
                                TRINHDOCHUYENMON6s.LOAIHINHDT,
                                TRINHDOCHUYENMON6s.TRUONGDT
                            };
                if (query.Count() > 0)
                {
                    dg.DataSource = query;
                    return 1;
                }
            }
            return 0;
           
        }
    }
}
