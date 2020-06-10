using DAO;
using DTO;
using Guna.UI.WinForms;
using System.Windows.Forms;
namespace BUS
{
    public class QuanLyNhanVienChucVu_BUS
    {
        private static QuanLyNhanVienChucVu_BUS instance;

        public static QuanLyNhanVienChucVu_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyNhanVienChucVu_BUS();
                }

                return instance;
            }
        }

        public QuanLyNhanVienChucVu_BUS()
        {

        }

        public bool LayThongTinHoSo_BUS(GunaTextBox txtMaNV, GunaLabel lb1, GunaLabel lb2)
        {
            HoSoNV_DTO nhanvien = new HoSoNV_DTO();
            nhanvien = QuanLyNhanVienChucVu_DAO.Instance.loadThongTinHoSo(txtMaNV.Text);
            if (nhanvien.MaNV != null)
            {
                lb1.Text = nhanvien.MaNV;
                lb2.Text = nhanvien.HoTen;
                return true;
            }else
            {
                MessageBox.Show("Không tìm thấy");
                return false;
            }          
        }
    }
}
