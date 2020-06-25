using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace DAO
{
    public class QuanLyTrinhDoNgoaiNgu_DAO
    {

        private static QuanLyTrinhDoNgoaiNgu_DAO instance;

        public static QuanLyTrinhDoNgoaiNgu_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyTrinhDoNgoaiNgu_DAO();
                }

                return instance;
            }
        }

        public QuanLyTrinhDoNgoaiNgu_DAO()
        {

        }

        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();


        public HoSoNV_DTO layThongTinHoSo_DAO(string txtMaNV)
        {
            HoSoNV_DTO nhanVien = new HoSoNV_DTO();
            txtMaNV = txtMaNV.ToUpper();
            var query = from q in db.HOSO6s
                        where q.MANV == txtMaNV
                        select new { q.MANV, q.HOTEN };
            foreach (var item in query)
            {
                nhanVien.MaNV = item.MANV;
                nhanVien.HoTen = item.HOTEN;
            }
            return nhanVien;
        }

        public void layDLCombox_DAO(ComboBox cb)
        {
            var query = (from q in db.TRINHDONGOAINGU6s
                                                  select new { q.NGOAINGU }).Distinct();
            cb.DataSource = query;
            cb.DisplayMember = "NGOAINGU";
            cb.ValueMember = "NGOAINGU";
        }

        public void layDLTable_DAO(DataGridView gr, string strMaNV)
        {
            var query =
            from q in db.TRINHDONGOAINGU6s
            where
              q.MANV == strMaNV
            select new
            {
                q.MANV,
                q.NGOAINGU,
                q.TRINHDO
            };
            gr.DataSource = query;
        }

        public int kiemTraTonTai(string strMaNV, string nn)
        {
            int dem = 0;
            dem = (from q in db.TRINHDONGOAINGU6s
                   where q.MANV == strMaNV &&  q.NGOAINGU == nn
                   select q).Count();
            return dem;
        }

        public bool themNVCV_DAO(string strMaNV, string ngoaingu, string trinhdo)
        {
            int dem = kiemTraTonTai(strMaNV, ngoaingu);
            if (dem >  0)
            {
                return false;
            }
            else
            {
                TRINHDONGOAINGU6 iTRINHDONGOAINGU6s = new TRINHDONGOAINGU6
                {
                    MANV = strMaNV,
                    NGOAINGU = ngoaingu,
                    TRINHDO = trinhdo
                };
                db.TRINHDONGOAINGU6s.InsertOnSubmit(iTRINHDONGOAINGU6s);
                db.SubmitChanges();
                return true;
            }
        }

        public bool capnhatNVCV_DAO(string strMaNV, string ngoaingu, string trinhdo)
        {
            int dem = kiemTraTonTai(strMaNV,ngoaingu);
            if (dem <= 0)
            {
                return false;
            }
            else
            {
                IQueryable<TRINHDONGOAINGU6> query =
                 from q in db.TRINHDONGOAINGU6s
                 where q.MANV == strMaNV && q.NGOAINGU == ngoaingu
                 select q;
                foreach (TRINHDONGOAINGU6 item in query)
                {
                    item.MANV = strMaNV;
                    item.NGOAINGU = ngoaingu;
                    item.TRINHDO = trinhdo;
                }
                db.SubmitChanges();
                return true;
            }
        }

        public bool xoaNVCV_DAO(string strMaNV, string ngoaingu, string trinhdo)
        {
            int dem = kiemTraTonTai(strMaNV,ngoaingu);
            if (dem <= 0)
            {
                return false;
            }
            else
            {
                IQueryable<TRINHDONGOAINGU6> query =
                  from q in db.TRINHDONGOAINGU6s
                  where
                    q.MANV == strMaNV && q.NGOAINGU == ngoaingu
                  select q;
                foreach (TRINHDONGOAINGU6 del in query)
                {
                    db.TRINHDONGOAINGU6s.DeleteOnSubmit(del);
                }
                db.SubmitChanges();
                return true;
            }


        }
    }
}
