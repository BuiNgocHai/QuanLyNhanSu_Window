using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Guna.UI.WinForms;


namespace DAO
{
    public class ThongKeTrinhDoNgoaiNgu_DAO
    {

        private static ThongKeTrinhDoNgoaiNgu_DAO instance;

        public ThongKeTrinhDoNgoaiNgu_DAO()
        {

        }
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



        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public void layDLNgoaiNgu_DAO(GunaComboBox cb)
        {
            var item = from q in db.TRINHDONGOAINGU6s
                       select new { q.NGOAINGU, q.TRINHDO };
            cb.DataSource = item;
            cb.DisplayMember = "NGOAINGU";
            cb.ValueMember = "TRINHDO";
        }
        public int thongKe_DAO(ComboBox cb, DataGridView dgv, int kieu)
        {
            if (kieu == 1)
            {
                var query = from q in db.TRINHDONGOAINGU6s
                            where
                              q.TRINHDO == cb.SelectedValue.ToString()
                            select new
                            {
                                q.MANV,
                                q.HOSO6.HOTEN,
                                q.HOSO6.PHONGBAN6.TENPB,
                                q.HOSO6.PHONGBAN6.NGAYTL
                            };
                if (query.Count() > 0)
                {
                    dgv.DataSource = query;
                    return 1;
                }

            }
            else
            {
                var query2 = from TRINHDONGOAINGU6s in db.TRINHDONGOAINGU6s
                             where
                               TRINHDONGOAINGU6s.TRINHDO == cb.SelectedValue.ToString()

                             select new
                             {
                                 TRINHDONGOAINGU6s.MANV,
                                 TRINHDONGOAINGU6s.HOSO6.HOTEN,
                                 TRINHDONGOAINGU6s.HOSO6.PHONGBAN6.TENPB,
                                 TRINHDONGOAINGU6s.HOSO6.PHONGBAN6.NGAYTL
                             };
                MessageBox.Show(cb.SelectedValue.ToString());
                if (query2.Count() > 0)
                {
                    dgv.DataSource = query2;
                    return 1;
                }
            }
            return 0;
        }
    }
}
