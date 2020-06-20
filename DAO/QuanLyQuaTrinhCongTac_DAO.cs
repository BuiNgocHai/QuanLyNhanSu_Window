using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace DAO
{
    public class QuanLyQuaTrinhCongTac_DAO
    {

        private static QuanLyQuaTrinhCongTac_DAO instance;

        public static QuanLyQuaTrinhCongTac_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyQuaTrinhCongTac_DAO();
                }

                return instance;
            }
        }

        public QuanLyQuaTrinhCongTac_DAO()
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
            IQueryable<QUATRINHCONGTAC6> query = from q in db.QUATRINHCONGTAC6s
                                                 select q;
            cb.DataSource = query;
            cb.DisplayMember = "CHUCVU";
			cb.ValueMember = "MANV";
        }

        public void layDLTable_DAO(DataGridView gr, string strMaNV)
        {
            var query =
            from q in db.QUATRINHCONGTAC6s
            where
              q.MANV == strMaNV
            select new
            {
                q.MANV,
                q.TUNGAY,
                q.DENNGAY,
                q.NOICONGTAC,
                q.CHUCVU
            };
            gr.DataSource = query;
        }

        public int kiemTraTonTai(string strMaNV)
        {
            int dem = 0;
            dem = (from q in db.NHANVIEN_CHUCVU6s
                   where q.MANV == strMaNV
                   select q).Count();
            return dem;
        }

        public bool themNVCV_DAO(string strMaNV, DateTime tuNgay, DateTime denNgay, string noiCongTac, string chucVu)
        {
            int dem = kiemTraTonTai(strMaNV);
            if (dem > 0)
            {
                return false;
            }
            else
            {
                QUATRINHCONGTAC6 iQUATRINHCONGTAC6s = new QUATRINHCONGTAC6
                {
                    MANV = strMaNV,
                    TUNGAY = tuNgay,
                    DENNGAY = denNgay,
                    NOICONGTAC = noiCongTac,
                    CHUCVU = chucVu
                };
                db.QUATRINHCONGTAC6s.InsertOnSubmit(iQUATRINHCONGTAC6s);
                db.SubmitChanges();
                return true;
            }
        }

        public bool capnhatNVCV_DAO(string strMaNV, DateTime tuNgay, DateTime denNgay, string noiCongTac, string chucVu)
        {
            int dem = kiemTraTonTai(strMaNV);
            if (dem <= 0 )
            {
                return false;
            }
            else
            {
                IQueryable<QUATRINHCONGTAC6> query =
                 from q in db.QUATRINHCONGTAC6s
                 where q.MANV == strMaNV && q.TUNGAY == tuNgay
                 select q;
                foreach (QUATRINHCONGTAC6 item in query)
                {
                    item.MANV = strMaNV;
                    item.DENNGAY = denNgay;
                    item.TUNGAY = tuNgay;
                    item.NOICONGTAC = noiCongTac;
                    item.CHUCVU = chucVu;
                }
                db.SubmitChanges();
                return true;
            }
        }

        public bool xoaNVCV_DAO(string strMaNV, DateTime tuNgay)
        {
            int dem = kiemTraTonTai(strMaNV);
            if (dem < 1)
            {
                return false;
            }
            else
            {
                IQueryable<QUATRINHCONGTAC6> query =
                  from q in db.QUATRINHCONGTAC6s
                  where
                    q.MANV == strMaNV &&
                    q.TUNGAY == tuNgay
                  select q;
                foreach (QUATRINHCONGTAC6 del in query)
                {
                    db.QUATRINHCONGTAC6s.DeleteOnSubmit(del);
                }
                db.SubmitChanges();
                return true;
            }


        }
    }
}
