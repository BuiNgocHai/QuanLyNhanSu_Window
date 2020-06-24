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
            dtPickerNS.Enabled = false;
            dtPickerNTD.Enabled = false;
            dtGVTDCM.Enabled = false;
            dtGVQTCT.Enabled = false;
            dtGVTDNN.Enabled = false;
        }






        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            qlhs_bus.timKiemHS(txbMaNV, txbTenNV, dtPickerNS, txbGioiTinh, txbSoDT, txbEmail, dtPickerNTD, txbTenPB,  dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoSo_Click(object sender, EventArgs e)
        {
            qlhs_bus.xuatFile(txbMaNV, txbTenNV, dtPickerNS, txbGioiTinh, txbSoDT, txbEmail, dtPickerNTD, txbTenPB, dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }
    }
}
