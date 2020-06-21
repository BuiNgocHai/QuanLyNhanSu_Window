using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInHoSoNV : Form
    {
        QuanLyHoSo_BUS qlhs_bus = new QuanLyHoSo_BUS();
        public frmInHoSoNV()
        {
            InitializeComponent();
        }

        private void gunaLabel15_Click(object sender, EventArgs e)
        {

        }

        private void frmInHoSoNV_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            qlhs_bus.timKiemHS(txbMaNV, txbTenNV, txbNgaySinh, txbGioiTinh, txbSoDT, txbEmail, txbNgayTD, txbTenPB, txbTaiKhoan, txbMatKhau, txbQuyen, dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoSo_Click(object sender, EventArgs e)
        {
            qlhs_bus.xuatFile(txbMaNV, txbTenNV, txbNgaySinh, txbGioiTinh, txbSoDT, txbEmail, txbNgayTD, txbTenPB, txbTaiKhoan, txbMatKhau, txbQuyen, dtGVTDCM, dtGVTDNN, dtGVQTCT);
        }
    }
}
