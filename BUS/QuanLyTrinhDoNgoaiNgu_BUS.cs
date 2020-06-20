using DAO;
using DTO;
using Guna.UI.WinForms;
using System;
using System.Windows.Forms;
namespace BUS
{
    public class QuanLyTrinhDoNgoaiNgu_BUS
    {
        private static QuanLyTrinhDoNgoaiNgu_BUS instance;

        public static QuanLyTrinhDoNgoaiNgu_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyTrinhDoNgoaiNgu_BUS();
                }

                return instance;
            }
        }

        public QuanLyTrinhDoNgoaiNgu_BUS()
        {

        }

		public void layDLCombox_BUS(GunaComboBox cb)
		{
            QuanLyTrinhDoNgoaiNgu_DAO.Instance.layDLCombox_DAO(cb);
        }

		public bool layThongTinHoSo_BUS(GunaTextBox txtMaNV, GunaLabel lb1, GunaLabel lb2)
        {
            HoSoNV_DTO nhanvien = new HoSoNV_DTO();
            nhanvien = QuanLyTrinhDoNgoaiNgu_DAO.Instance.layThongTinHoSo_DAO(txtMaNV.Text);

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

        public void layDLTable_BUS(GunaDataGridView gr, GunaLabel lb)
        {
            QuanLyTrinhDoNgoaiNgu_DAO.Instance.layDLTable_DAO(gr, lb.Text);
        }

        public bool themNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV, GunaTextBox gunaTextBox1)
        {
            return QuanLyTrinhDoNgoaiNgu_DAO.Instance.themNVCV_DAO(txtMNV.Text, cbCV.SelectedValue.ToString(), gunaTextBox1.Text);
        }

        public bool capnhatNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV, GunaTextBox gunaTextBox1)
        {
            return QuanLyTrinhDoNgoaiNgu_DAO.Instance.capnhatNVCV_DAO(txtMNV.Text, cbCV.SelectedValue.ToString(), gunaTextBox1.Text);
        }

        public bool xoaNVCV_BUS(GunaLabel txtMNV, GunaComboBox cbCV, GunaTextBox gunaTextBox1)
        {
            return QuanLyTrinhDoNgoaiNgu_DAO.Instance.xoaNVCV_DAO(txtMNV.Text, cbCV.SelectedValue.ToString(), gunaTextBox1.Text);
        }


    }
}
