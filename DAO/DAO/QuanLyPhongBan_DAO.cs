using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAO
{
    public class QuanLyPhongBan_DAO
    {
        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();
        private static QuanLyPhongBan_DAO instance;

        public static QuanLyPhongBan_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyPhongBan_DAO();
                }

                return instance;
            }
        }
        public QuanLyPhongBan_DAO()
        {

        }

        public void hienThiDT_DAO(DataGridView gr)
        {
            var query =
            from q in db.PHONGBAN6s
            select new
            {
                q.MAPB,
                q.TENPB,
                q.NGAYTL
            };
            gr.DataSource = query;
        }
        public int kiemTraTonTai(string maPB)
        {
            int dem = 0;
            dem = (from q in db.PHONGBAN6s
                   where q.MAPB==maPB
                   select q).Count();
            return dem;
        }

        public bool themPhongBan(string maPB,string tenPB, DateTime ngayTL)
        {
            int count = kiemTraTonTai(maPB);
            if(count >0)
            {
                return false;
            }
            else
            {
                PHONGBAN6 pb = new PHONGBAN6
                {
                    MAPB = maPB,
                    TENPB = tenPB,
                    NGAYTL = ngayTL,
                };
                db.PHONGBAN6s.InsertOnSubmit(pb);
                db.SubmitChanges();
                return true;
            }
        }

        public bool suaPhongBan(string maPB, string tenPB, DateTime ngayTL)
        {
            int count = kiemTraTonTai(maPB);
            if (count == 0)
            {
                return false;
            }
            else
            {
                IQueryable<PHONGBAN6> query =
                from q in db.PHONGBAN6s
                where q.MAPB == maPB
                select q;
                bool output = false;
                foreach (PHONGBAN6 item in query)
                {
                    output = true;
                    item.TENPB = tenPB;
                    item.NGAYTL = ngayTL;
                }
                db.SubmitChanges();
                return output;
            }
        }

        public bool xoaPhongBan(string maPB, string tenPB, DateTime ngayTL)
        {
            int count = kiemTraTonTai(maPB);
            if (count == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    IQueryable<HOSO6> query =
                    from q in db.HOSO6s where q.MAPB == maPB select q;

                    foreach (HOSO6 del in query)
                    {

                        IQueryable<QUATRINHCONGTAC6> query1 =
                        from q in db.QUATRINHCONGTAC6s where q.MANV == del.MANV select q;
                        foreach (QUATRINHCONGTAC6 item in query1)
                        {
                            db.QUATRINHCONGTAC6s.DeleteOnSubmit(item);
                        }
                        IQueryable<NHANVIEN_CHUCVU6> query2 =
                              from q in db.NHANVIEN_CHUCVU6s where q.MANV == del.MANV select q;
                        foreach (NHANVIEN_CHUCVU6 item in query2)
                        {
                            db.NHANVIEN_CHUCVU6s.DeleteOnSubmit(item);
                        }
                        IQueryable<TRINHDOCHUYENMON6> query3 =
                              from q in db.TRINHDOCHUYENMON6s where q.MANV == del.MANV select q;
                        foreach (TRINHDOCHUYENMON6 item in query3)
                        {
                            db.TRINHDOCHUYENMON6s.DeleteOnSubmit(item);
                        }
                        IQueryable<TRINHDONGOAINGU6> query4 =
                              from q in db.TRINHDONGOAINGU6s where q.MANV == del.MANV select q;
                        foreach (TRINHDONGOAINGU6 item in query4)
                        {
                            db.TRINHDONGOAINGU6s.DeleteOnSubmit(item);
                        }
                        foreach (HOSO6 item in query)
                        {
                            db.HOSO6s.DeleteOnSubmit(item);
                        }
                    }
                    IQueryable<PHONGBAN6> query5 =
                      from q in db.PHONGBAN6s where q.MAPB == maPB select q;
                    foreach (PHONGBAN6 item in query5)
                    {
                        db.PHONGBAN6s.DeleteOnSubmit(item);
                    }
                    db.SubmitChanges();
                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }

        public void timKiemPhongBan(DataGridView dt, string maPB)
        {
            var query =
            from q in db.PHONGBAN6s
            where
              q.MAPB == maPB
            select q;
            dt.DataSource = query;
        }
    }
}
