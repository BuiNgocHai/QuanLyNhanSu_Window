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


       

        public bool layThongTinHoSo_BUS(GunaTextBox txtMaNV, GunaLabel lb1, GunaLabel lb2)
        {
            HoSoNV_DTO nhanvien = new HoSoNV_DTO();
            nhanvien = QuanLyNhanVienChucVu_DAO.Instance.layThongTinHoSo_DAO(txtMaNV.Text);

            if (nhanvien.MaNV != null)
            {
                lb1.Text = nhanvien.MaNV;
                lb2.Text = nhanvien.HoTen;
                return true;
            }else
            {                
                return false;
            }          
        }

        public void layDLCombox_BUS(GunaComboBox cb)
        {
            QuanLyNhanVienChucVu_DAO.Instance.layDLCombox_DAO(cb);
        }

        public void layDLTable_BUS(GunaDataGridView gr, GunaLabel lb)
        {
            QuanLyNhanVienChucVu_DAO.Instance.layDLTable_DAO(gr,lb.Text);
        }

        public bool themNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV,GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay)
        {
           return QuanLyNhanVienChucVu_DAO.Instance.themNVCV_DAO(txtMNV.Text, cbCV.SelectedValue.ToString(),tuNgay.Value, denNgay.Value);
        }

        public bool capnhatNVCV_BUS(GunaLabel strMaNV, GunaLabel strMaCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay)
        {
            return QuanLyNhanVienChucVu_DAO.Instance.capnhatNVCV_DAO(strMaNV.Text, strMaCV.Text, tuNgay.Value, denNgay.Value);
        }

        public bool xoaNVCV_BUS(GunaLabel strMaNV, GunaLabel strMaCV, GunaDateTimePicker tuNgay)
        {
            return QuanLyNhanVienChucVu_DAO.Instance.xoaNVCV_DAO(strMaNV.Text, strMaCV.Text, tuNgay.Value);
        }


        }
}
