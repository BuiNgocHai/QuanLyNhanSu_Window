using DTO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace DAO
{
    public class ChucVu_DAO
    {
        private static ChucVu_DAO instance;

        public static ChucVu_DAO createInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVu_DAO();
                }
                return instance;
            }
        }

        public ChucVu_DAO()
        {

        }

        private DBQLNhanSu_6DataContext db = new DBQLNhanSu_6DataContext();

        public int kiemTraTonTai(string ma)
        {
            int check = (from q in db.CHUCVU6s
                         where q.MACV == ma
                         select q).Count();
            return check;
        }

        public int themChucVu(ChucVu_DTO cv)
        {
            int check = kiemTraTonTai(cv.MaCV);
            if (check > 0)
            {
                return 0;
            }
            else
            {
                CHUCVU6 themcv = new CHUCVU6
                {
                    MACV = cv.MaCV,
                    TENCV = cv.TenCV,
                    HESOPC = cv.HeSoPhuCap
                };
                db.CHUCVU6s.InsertOnSubmit(themcv);
                db.SubmitChanges();
                return 1;
            }
        }

        public void hienThiDuLieu(DataGridView gr)
        {
            IQueryable<CHUCVU6> query = from cv in db.CHUCVU6s
                                        select cv;
            gr.DataSource = query;
        }

        public int capNhatChucVu(string ma, string ten, float hspc)
        {
            int check = kiemTraTonTai(ma);
            if (check == 0)
            {
                return 0;
            }

            IQueryable<CHUCVU6> list = from cv in db.CHUCVU6s
                                       where cv.MACV == ma
                                       select cv;

            foreach (CHUCVU6 cv in list)
            {
                cv.TENCV = ten;
                cv.HESOPC = hspc;
            }
            db.SubmitChanges();
            return 1;
        }

        public void xoaChucVu(string ma)
        {
            IQueryable<CHUCVU6> list = from cv in db.CHUCVU6s
                                        where cv.MACV == ma
                                        select cv;

            foreach(CHUCVU6 cv in list)
            {
                db.CHUCVU6s.DeleteOnSubmit(cv);
            }
            db.SubmitChanges();

        }

        public void timkiem (string strMaCV,DataGridView gr)
        {
            var query = from q in db.CHUCVU6s
                        where q.MACV == strMaCV
                        select q;
            gr.DataSource = query;       
        }

    }
}
