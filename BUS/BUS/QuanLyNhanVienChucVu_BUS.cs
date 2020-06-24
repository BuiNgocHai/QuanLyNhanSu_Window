using DAO;
using DTO;
using DTO.DTO;
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

          public int kiemTraDuLieu(GunaLabel txtMaNV, GunaComboBox cbCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay, GunaCheckBox chb,ref string strDenNgay)
        {
            int kt = 0;
            if (chb.Checked)
            {
                if (QuanLyNhanVienChucVu_DAO.Instance.kiemTraThoiGian(txtMaNV.Text, cbCV.SelectedValue.ToString()) > 0)
                    return 1;// kiểm tra nhân viên có đang làm công việc nào đó không?
                else
                {
                    strDenNgay = "Nay";                  
                    return 3;
                }
                    
            }
            kt = tuNgay.Value.CompareTo(denNgay.Value);
            if (kt == 0 || kt >= 1)
            {
                return 2;// kiểm tra ngày tháng nhập vào có đúng theo quy tắc không? từ ngày < đến ngày
            }
            return 3;
        }

        public int themNVCV_BUS(GunaLabel txtMaNV, GunaComboBox cbCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay, GunaCheckBox chb)
        {            
            if (QuanLyNhanVienChucVu_DAO.Instance.kiemTraTonTai(txtMaNV.Text, cbCV.SelectedValue.ToString(), tuNgay.Value) > 0)
                return 0;//kiểm tra đã tồn tại nhân viên với cv này chưa?

            string strDenNgay=denNgay.Text;
            int kiemtra = kiemTraDuLieu(txtMaNV, cbCV, tuNgay, denNgay, chb,ref strDenNgay);
           if (kiemtra ==3)
            {
                QuanLyNhanVienChucVu_DTO nvcv = new QuanLyNhanVienChucVu_DTO(txtMaNV.Text, cbCV.SelectedValue.ToString(), tuNgay.Value, strDenNgay);
                QuanLyNhanVienChucVu_DAO.Instance.themNVCV_DAO(nvcv);
            }
            return kiemtra;
            
            
        }

        public int capnhatNVCV_BUS(GunaLabel txtMaNV, GunaComboBox cbCV, GunaDateTimePicker tuNgay, GunaDateTimePicker denNgay, GunaCheckBox chb)
        {
            if (QuanLyNhanVienChucVu_DAO.Instance.kiemTraTonTai(txtMaNV.Text, cbCV.SelectedValue.ToString(), tuNgay.Value) <= 0)
                return 0;//kiểm tra đã tồn tại nhân viên với cv này chưa? 
            string strDenNgay = denNgay.Text;
            int kiemtra = kiemTraDuLieu(txtMaNV, cbCV, tuNgay, denNgay, chb, ref strDenNgay);
            if (kiemtra == 3)
            {
                QuanLyNhanVienChucVu_DTO nvcv = new QuanLyNhanVienChucVu_DTO(txtMaNV.Text, cbCV.SelectedValue.ToString(), tuNgay.Value, strDenNgay);
                QuanLyNhanVienChucVu_DAO.Instance.capnhatNVCV_DAO(nvcv);
            }
            return kiemtra;
        }

        public bool xoaNVCV_BUS(GunaLabel strMaNV, GunaLabel strMaCV, GunaDateTimePicker tuNgay)
        {
            return QuanLyNhanVienChucVu_DAO.Instance.xoaNVCV_DAO(strMaNV.Text, strMaCV.Text, tuNgay.Value);
        }


        }
}
