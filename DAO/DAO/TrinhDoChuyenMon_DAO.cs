using DTO;
using System.Linq;
using System.Windows.Forms;

namespace DAO.DAO
{
    public class TrinhDoChuyenMon_DAO
    {
        public static TrinhDoChuyenMon_DAO instance;
        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public static TrinhDoChuyenMon_DAO createInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrinhDoChuyenMon_DAO();
                }
                return instance;
            }
        }

        public void timKiemTrinhDoChuyenMon_DAO(HoSoNV_DTO nhanvien)
        {
            var layTT = from td in db.HOSO6s
                        where td.MANV == nhanvien.MaNV
                        select new { td.HOTEN };
            foreach (var item in layTT)
            {
                nhanvien.HoTen = item.HOTEN;
            }
        }

        public int themTrinhDoChuyenMon(TrinhDoChuyenMon_DTO tdcm)
        {
            int check = (from t in db.TRINHDOCHUYENMON6s
                         where t.NGANH == tdcm.Nganh
                         select t).Count();

            if (check != 0)
            {
                return 0;
            }

            TRINHDOCHUYENMON6 td = new TRINHDOCHUYENMON6
            {
                MANV = tdcm.Manv,
                NGANH = tdcm.Nganh,
                LOAIHINHDT = tdcm.LoaiHinhDT,
                TRUONGDT = tdcm.TruongDT,
                TRINHDO = tdcm.TrinhDo
            };
            db.TRINHDOCHUYENMON6s.InsertOnSubmit(td);
            db.SubmitChanges();

            return 1;
        }

        public void hienThi(DataGridView gr, string ma)
        {
            var tdcm = from td in db.TRINHDOCHUYENMON6s
                       where td.MANV == ma
                       select new { td.MANV, td.NGANH, td.LOAIHINHDT, td.TRINHDO, td.TRUONGDT };
            gr.DataSource = tdcm;
        }

        public int capNhapTrinhDoChuyenMon(string nganh, string td, string lh, string truong)
        {
            int check = (from t in db.TRINHDOCHUYENMON6s
                         where t.NGANH == nganh
                         select t).Count();
            if (check == 0)
            {
                return 0;
            }

            IQueryable<TRINHDOCHUYENMON6> tdcm = from t in db.TRINHDOCHUYENMON6s
                                                 where t.NGANH == nganh
                                                 select t;

            foreach (TRINHDOCHUYENMON6 item in tdcm)
            {
                item.LOAIHINHDT = lh;
                item.TRUONGDT = truong;
                item.TRINHDO = td;
            }

            db.SubmitChanges();
            return 1;
        }


        public int xoaTrinhDoChuyenMon(string nganh, string ma)
        {
            MessageBox.Show(ma + "  " + nganh);
            IQueryable<TRINHDOCHUYENMON6> tdcm = from t in db.TRINHDOCHUYENMON6s
                                                 where t.MANV == ma && t.NGANH == nganh
                                                 select t;

            foreach (TRINHDOCHUYENMON6 item in tdcm)
            {
                db.TRINHDOCHUYENMON6s.DeleteOnSubmit(item);
            }
            db.SubmitChanges();
            return 1;
        }
    }

}