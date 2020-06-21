using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace DAO
{
    public class ThongKeTrinhDoNgoaiNgu_DAO
    {

        private static ThongKeTrinhDoNgoaiNgu_DAO instance;

        public static ThongKeTrinhDoNgoaiNgu_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ThongKeTrinhDoNgoaiNgu_DAO();
                }

                return instance;
            }
        }

        public ThongKeTrinhDoNgoaiNgu_DAO()
        {

        }

        DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public void layDLNgoaiNgu_DAO(ComboBox cb)
        {
            var item = from q in db.TRINHDONGOAINGU6s
                       select new { q.NGOAINGU, q.TRINHDO };
            cb.DataSource = item;
            cb.DisplayMember = "NGOAINGU";
            cb.ValueMember = "TRINHDO";
        }
    }
}
