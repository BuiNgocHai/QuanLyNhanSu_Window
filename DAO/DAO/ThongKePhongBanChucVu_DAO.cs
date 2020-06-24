using Guna.UI.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAO.DAO
{
    public class ThongKePhongBanChucVu_DAO
    {
        private static ThongKePhongBanChucVu_DAO instance;



        public ThongKePhongBanChucVu_DAO()
        {

        }

        public static ThongKePhongBanChucVu_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKePhongBanChucVu_DAO();
                }

                return instance;
            }
        }

        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public void layDLTenPhongBan_DAO(GunaComboBox cb)
        {
            var item = from q in db.PHONGBAN6s
                       select new { q.MAPB, q.TENPB };
            cb.DataSource = item;
            cb.DisplayMember = "TENPB";
            cb.ValueMember = "MAPB";
        }

        public int thongKe_DAO(GunaComboBox cb, GunaDataGridView dgv, int kieu)
        {
            if (kieu == 1)
            {
                var query = from NHANVIEN_CHUCVU6s in db.NHANVIEN_CHUCVU6s
                            where
                              NHANVIEN_CHUCVU6s.HOSO6.PHONGBAN6.MAPB == cb.SelectedValue.ToString()
                            && NHANVIEN_CHUCVU6s.DENNGAY == "Nay"
                            select new
                            {
                                NHANVIEN_CHUCVU6s.HOSO6.MANV,
                                NHANVIEN_CHUCVU6s.HOSO6.HOTEN,
                                NGAYSINH = (DateTime?)NHANVIEN_CHUCVU6s.HOSO6.NGAYSINH,
                                NHANVIEN_CHUCVU6s.HOSO6.GIOITINH,
                                NHANVIEN_CHUCVU6s.HOSO6.SODT,
                                NHANVIEN_CHUCVU6s.HOSO6.EMAIL,
                                NGAYTD = (DateTime?)NHANVIEN_CHUCVU6s.HOSO6.NGAYTD,
                                NHANVIEN_CHUCVU6s.HOSO6.PHONGBAN6.TENPB,
                                NHANVIEN_CHUCVU6s.CHUCVU6.TENCV
                            };
                if (query.Count() > 0)
                {
                    dgv.DataSource = query;
                    return 1;
                }

            }
            else
            {
                var query2 = from NHANVIEN_CHUCVU6s in db.NHANVIEN_CHUCVU6s
                             where
                               NHANVIEN_CHUCVU6s.CHUCVU6.MACV == cb.SelectedValue.ToString()
                              && NHANVIEN_CHUCVU6s.DENNGAY== "Nay"
                             select new
                             {
                                 NHANVIEN_CHUCVU6s.HOSO6.MANV,
                                 NHANVIEN_CHUCVU6s.HOSO6.HOTEN,
                                 NGAYSINH = (DateTime?)NHANVIEN_CHUCVU6s.HOSO6.NGAYSINH,
                                 NHANVIEN_CHUCVU6s.HOSO6.GIOITINH,
                                 NHANVIEN_CHUCVU6s.HOSO6.SODT,
                                 NHANVIEN_CHUCVU6s.HOSO6.EMAIL,
                                 NGAYTD = (DateTime?)NHANVIEN_CHUCVU6s.HOSO6.NGAYTD,
                                 NHANVIEN_CHUCVU6s.HOSO6.PHONGBAN6.TENPB,
                                 NHANVIEN_CHUCVU6s.CHUCVU6.TENCV
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
