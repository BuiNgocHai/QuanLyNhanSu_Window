using DTO.DTO;
using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace DAO
{
    public class QuanLyNhanVienChucVu_DAO
    {

        private static QuanLyNhanVienChucVu_DAO instance;

        public static QuanLyNhanVienChucVu_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyNhanVienChucVu_DAO();
                }

                return instance;
            }
        }

        public QuanLyNhanVienChucVu_DAO()
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
            IQueryable<CHUCVU6> query = from q in db.CHUCVU6s
                                        select q;
            cb.DataSource = query;
            cb.DisplayMember = "TENCV";
            cb.ValueMember = "MACV";
        }

        public void layDLTable_DAO(DataGridView gr, string strMaNV)
        {
            var query =
            from q in db.NHANVIEN_CHUCVU6s
            where
              q.HOSO6.MANV == strMaNV
            select new
            {
                q.MACV,
                q.CHUCVU6.TENCV,
                HESOPC = (double?)q.CHUCVU6.HESOPC,
                q.TUNGAY,
                q.DENNGAY
            };
            gr.DataSource = query;
        }

        public int kiemTraTonTai(string strMaNV, string strMaCV, DateTime tuNgay)
        {
            return (from q in db.NHANVIEN_CHUCVU6s
                    where q.TUNGAY == tuNgay && q.MANV == strMaNV && q.MACV == strMaCV
                    select q).Count();
        }

        public int kiemTraThoiGian(string strMaNV, string strMaCV)
        {
            return (from q in db.NHANVIEN_CHUCVU6s
                    where q.MANV == strMaNV && q.DENNGAY == "Nay"
                    select q).Count(); ;
        }

        public void themNVCV_DAO(QuanLyNhanVienChucVu_DTO nvcv)
        {
            NHANVIEN_CHUCVU6 iNHANVIEN_CHUCVU6s = new NHANVIEN_CHUCVU6
            {
                MANV = nvcv.MaNV,
                MACV = nvcv.MaCV,
                TUNGAY = nvcv.TuNgay,
                DENNGAY = nvcv.DenNgay,
            };
            db.NHANVIEN_CHUCVU6s.InsertOnSubmit(iNHANVIEN_CHUCVU6s);
            db.SubmitChanges();
        }

        public void capnhatNVCV_DAO(QuanLyNhanVienChucVu_DTO nvcv)
        {

                IQueryable<NHANVIEN_CHUCVU6> query =
                 from q in db.NHANVIEN_CHUCVU6s
                 where q.MANV == nvcv.MaNV && q.MACV == nvcv.MaCV && q.TUNGAY == nvcv.TuNgay
                 select q;

                foreach (NHANVIEN_CHUCVU6 item in query)
                {
                    item.DENNGAY = nvcv.DenNgay;
                }
                db.SubmitChanges();
        }

        public bool xoaNVCV_DAO(string strMaNV, string strMaCV, DateTime tuNgay)
        {
            int dem = kiemTraTonTai(strMaNV, strMaCV, tuNgay);
            if (dem <= 0)
            {
                return false;
            }
            else
            {
                IQueryable<NHANVIEN_CHUCVU6> query =
                  from q in db.NHANVIEN_CHUCVU6s
                  where
                    q.MANV == strMaNV &&
                    q.MACV == strMaCV &&
                    q.TUNGAY == tuNgay
                  select q;
                foreach (NHANVIEN_CHUCVU6 del in query)
                {
                    db.NHANVIEN_CHUCVU6s.DeleteOnSubmit(del);
                }
                db.SubmitChanges();
                return true;
            }

        }
    }
}
