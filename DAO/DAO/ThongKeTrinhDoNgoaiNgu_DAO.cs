using DTO;
using Guna.UI.WinForms;
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
            var item = (from TRINHDONGOAINGU6s in db.TRINHDONGOAINGU6s
                        select new
                        {
                            TRINHDONGOAINGU6s.NGOAINGU
                        }).Distinct();
            cb.DataSource = item;
            cb.DisplayMember = "NGOAINGU";
            cb.ValueMember = "NGOAINGU";
        }

        public void layDLTrinhDo_DAO(ComboBox cb)
        {
            var item = (from TRINHDONGOAINGU6s in db.TRINHDONGOAINGU6s
                        select new
                        {
                            TRINHDONGOAINGU6s.TRINHDO
                        }).Distinct();
            cb.DataSource = item;
            cb.DisplayMember = "TRINHDO";
            cb.ValueMember = "TRINHDO";
        }

        public int thongKe_DAO(GunaComboBox cb, GunaDataGridView dgv, int kieu)
        {
            if (kieu == 1)
            {
                var query = from TRINHDONGOAINGU6s in db.TRINHDONGOAINGU6s
                            where
                              TRINHDONGOAINGU6s.TRINHDO == cb.SelectedValue.ToString()
                            select new
                            {
                                TRINHDONGOAINGU6s.HOSO6.MANV,
                                TRINHDONGOAINGU6s.HOSO6.HOTEN,
                                NGAYSINH = (DateTime?)TRINHDONGOAINGU6s.HOSO6.NGAYSINH,
                                TRINHDONGOAINGU6s.HOSO6.GIOITINH,
                                TRINHDONGOAINGU6s.HOSO6.EMAIL,
                                TRINHDONGOAINGU6s.HOSO6.SODT,
                                NGAYTD = (DateTime?)TRINHDONGOAINGU6s.HOSO6.NGAYTD,
                                TRINHDONGOAINGU6s.NGOAINGU,
                                TRINHDONGOAINGU6s.TRINHDO
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
                               TRINHDONGOAINGU6s.NGOAINGU == cb.SelectedValue.ToString()
                             select new
                             {
                                 TRINHDONGOAINGU6s.HOSO6.MANV,
                                 TRINHDONGOAINGU6s.HOSO6.HOTEN,
                                 NGAYSINH = (DateTime?)TRINHDONGOAINGU6s.HOSO6.NGAYSINH,
                                 TRINHDONGOAINGU6s.HOSO6.GIOITINH,
                                 TRINHDONGOAINGU6s.HOSO6.EMAIL,
                                 TRINHDONGOAINGU6s.HOSO6.SODT,
                                 NGAYTD = (DateTime?)TRINHDONGOAINGU6s.HOSO6.NGAYTD,
                                 TRINHDONGOAINGU6s.NGOAINGU,
                                 TRINHDONGOAINGU6s.TRINHDO
                             };
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
