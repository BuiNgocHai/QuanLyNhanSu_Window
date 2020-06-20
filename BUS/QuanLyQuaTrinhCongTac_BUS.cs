using DAO;
using DTO;
using Guna.UI.WinForms;
using System.Windows.Forms;
namespace BUS
{
    public class QuanLyQuaTrinhCongTac_BUS
    {
        private static QuanLyQuaTrinhCongTac_BUS instance;

        public static QuanLyQuaTrinhCongTac_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyQuaTrinhCongTac_BUS();
                }

                return instance;
            }
        }

        public QuanLyQuaTrinhCongTac_BUS()
        {

        }




        public bool layThongTinHoSo_BUS(GunaTextBox txtMaNV, GunaLabel lb1, GunaLabel lb2)
        {
            HoSoNV_DTO nhanvien = new HoSoNV_DTO();
            nhanvien = QuanLyQuaTrinhCongTac_DAO.Instance.layThongTinHoSo_DAO(txtMaNV.Text);

            if (nhanvien.MaNV != null)
            {
                lb1.Text = nhanvien.MaNV;
                lb2.Text = nhanvien.HoTen;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void layDLCombox_BUS(GunaComboBox cb)
        {
            QuanLyQuaTrinhCongTac_DAO.Instance.layDLCombox_DAO(cb);
        }

        public void layDLTable_BUS(GunaDataGridView gr, GunaLabel lb)
        {
            QuanLyQuaTrinhCongTac_DAO.Instance.layDLTable_DAO(gr, lb.Text);
        }

        public bool themNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay, GunaTextBox gunaTextBox1)
        {
            return QuanLyQuaTrinhCongTac_DAO.Instance.themNVCV_DAO(txtMNV.Text, tuNgay.Value, denNgay.Value, gunaTextBox1.Text, cbCV.SelectedValue.ToString());
        }

        public bool capnhatNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay, GunaTextBox noiCongTac)
        {
            return QuanLyQuaTrinhCongTac_DAO.Instance.capnhatNVCV_DAO(txtMNV.Text, tuNgay.Value, denNgay.Value, noiCongTac.Text, cbCV.SelectedValue.ToString());
        }

        public bool xoaNVCV_BUS(GunaLabel strMaNV, GunaDateTimePicker tuNgay)
        {
            return QuanLyQuaTrinhCongTac_DAO.Instance.xoaNVCV_DAO(strMaNV.Text, tuNgay.Value);
        }


    }
}
