using BUS;
using System;
using System.Windows.Forms;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInHoSoNV : Form
    {
        private QuanLyHoSo_BUS qlhs_bus = new QuanLyHoSo_BUS();
        public frmInHoSoNV()
        {
            InitializeComponent();

        }

        private void frmInHoSoNV_Load(object sender, EventArgs e)
        {

        }



        private void gunaLabel15_Click(object sender, EventArgs e)
        {

        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            qlhs_bus.timKiemHS(txbMaNV, txbTenNV, txbNgaySinh, txbGioiTinh, txbSoDT, txbEmail, txbNgayTD, txbTenPB, txbTaiKhoan, txbMatKhau, txbQuyen, dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoSo_Click(object sender, EventArgs e)
        {
            qlhs_bus.xuatFile(txbMaNV, txbTenNV, txbNgaySinh, txbGioiTinh, txbSoDT, txbEmail, txbNgayTD, txbTenPB, txbTaiKhoan, txbMatKhau, txbQuyen, dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }
    }
}
