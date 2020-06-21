using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class HoSo_DAO
    {
        private static HoSo_DAO instance;

        public static HoSo_DAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new HoSo_DAO();
                }

                return instance;
            }
        }

        public HoSo_DAO()
        {

        }

        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public void hienThi(DataGridView dt)
        {
            var query = from q in db.HOSO6s select q;
            dt.DataSource = query;
        }

        public void loadCBBox(ComboBox cb)
        {
            IQueryable<PHONGBAN6> query = from q in db.PHONGBAN6s
                                          select q;
            cb.DataSource = query;
            cb.DisplayMember = "TENPB";
            cb.ValueMember = "MAPB";
        }
        public int kiemTraTonTai(string maNV)
        {
            int dem = 0;
            dem = (from q in db.HOSO6s
                   where q.MANV == maNV
                   select q).Count();
            return dem;
        }
        public bool themHoSo(string maNV, string tenNV, DateTime ngayS, string gt, string sdt, string email, DateTime ntd, string mpb, string tk,string mk, string q)
        {
            int count = kiemTraTonTai(maNV);
            if (count > 0)
            {
                return false;
            }
            else
            {
                try
                {
                    HOSO6 pb = new HOSO6
                    {
                        MANV = maNV,
                        HOTEN = tenNV,
                        NGAYSINH = ngayS,
                        GIOITINH = gt,
                        SODT = sdt,
                        EMAIL = email,
                        NGAYTD = ntd,
                        MAPB = mpb,
                        TAIKHOAN = tk,
                        QUYEN = q
                    };
                    db.HOSO6s.InsertOnSubmit(pb);
                    db.SubmitChanges();
                    return true;
                }
                catch(Exception )
                {
                    return false;
                }
            }
        }
        public bool suaHoSo(string maNV, string tenNV, DateTime ngayS, string gt, string sdt, string email, DateTime ntd, string mpb, string tk, string mk, string quyen)
        {
            int count = kiemTraTonTai(maNV);
            if (count == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    IQueryable<HOSO6> query =
                    from q in db.HOSO6s
                    where q.MANV == maNV
                    select q;
                    bool output = false;
                    foreach (HOSO6 item in query)
                    {
                        output = true;
                        item.MANV = maNV;
                        item.HOTEN = tenNV;
                        item.NGAYSINH = ngayS;
                        item.GIOITINH = gt;
                        item.SODT = sdt;
                        item.EMAIL = email;
                        item.NGAYTD = ntd;
                        item.MAPB = mpb;
                        item.TAIKHOAN = tk;
                        item.QUYEN = quyen;
                    }
                    db.SubmitChanges();
                    return output;
                }
                catch (Exception )
                {
                    return false;
                }
            }
        }
        public void timKiemHoSo(DataGridView dt,string maNV)
        {
            IQueryable<HOSO6> query =
                    from q in db.HOSO6s
                    where q.MANV == maNV
                    select q;
            dt.DataSource = query;
        }
        public bool xoaHoSo(string maNV)
        {
            int count = kiemTraTonTai(maNV);
            if (count == 0)
            {
                return false;
            }
            IQueryable<QUATRINHCONGTAC6> query =
                  from q in db.QUATRINHCONGTAC6s where q.MANV == maNV select q;
            foreach(QUATRINHCONGTAC6 item in query)
            {
                db.QUATRINHCONGTAC6s.DeleteOnSubmit(item);
            }
            IQueryable<NHANVIEN_CHUCVU6> query1 =
                  from q in db.NHANVIEN_CHUCVU6s where q.MANV == maNV select q;
            foreach(NHANVIEN_CHUCVU6 item in query1)
            {
                db.NHANVIEN_CHUCVU6s.DeleteOnSubmit(item);
            }
            IQueryable<TRINHDOCHUYENMON6> query2 =
                  from q in db.TRINHDOCHUYENMON6s where q.MANV == maNV select q;
            foreach (TRINHDOCHUYENMON6 item in query2)
            {
                db.TRINHDOCHUYENMON6s.DeleteOnSubmit(item);
            }
            IQueryable<TRINHDONGOAINGU6> query3 =
                  from q in db.TRINHDONGOAINGU6s where q.MANV == maNV select q;
            foreach (TRINHDONGOAINGU6 item in query3)
            {
                db.TRINHDONGOAINGU6s.DeleteOnSubmit(item);
            }
            IQueryable<HOSO6> query4 =
                  from q in db.HOSO6s where q.MANV == maNV select q;
            foreach (HOSO6 item in query4)
            {
                db.HOSO6s.DeleteOnSubmit(item);
            }
            db.SubmitChanges();
            return true;
        }
        public HoSoNV_DTO timKiem(string maNV)
        {
            HoSoNV_DTO nv = new HoSoNV_DTO();
            IQueryable<HOSO6> query= from q in db.HOSO6s where q.MANV == maNV select q;
            foreach (HOSO6 item in query) {
                nv.MaNV = maNV;
                nv.HoTen = item.HOTEN;
                nv.NgaySinh = Convert.ToDateTime(item.NGAYSINH);
                nv.GioiTinh = item.GIOITINH;
                nv.SDT = item.SODT;
                nv.Email = item.EMAIL;
                nv.NgayTD = Convert.ToDateTime(item.NGAYTD);
                nv.MaPB = item.MAPB;
                nv.TaiKhoan = item.TAIKHOAN;
                nv.MatKhau = item.MATKHAU;
                nv.Quyen = item.QUYEN;
            }
            
            return nv;
        }

        public void hienThiQTCT(DataGridView dt,string maNV)
        {
            var query = from q in db.QUATRINHCONGTAC6s
            where q.MANV == maNV 
            select new
            {
                q.CHUCVU,
                q.TUNGAY,
                q.DENNGAY,
                q.NOICONGTAC
            };
            dt.DataSource = query;
        }
        public void hienThiTDNN(DataGridView dt, string maNV)
        {
            var query = from q in db.TRINHDONGOAINGU6s
                        where q.MANV == maNV
                        select new
                        {
                            q.NGOAINGU,
                            q.TRINHDO
                        };
            dt.DataSource = query;
        }
        public void hienThiTDCM(DataGridView dt, string maNV)
        {
            var query = from q in db.TRINHDOCHUYENMON6s
                        where q.MANV == maNV
                        select new
                        {
                            q.NGANH,
                            q.TRINHDO,
                            q.LOAIHINHDT,
                            q.TRUONGDT
                        };
            dt.DataSource = query;
        }
    }
}
