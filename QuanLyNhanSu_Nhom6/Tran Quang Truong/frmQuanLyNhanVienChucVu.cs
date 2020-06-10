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
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQuanLyNhanVienChucVu : Form
    {
        public frmQuanLyNhanVienChucVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVienChucVu_Load(object sender, EventArgs e)
        {
            gunaPanel1.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
         
            if(QuanLyNhanVienChucVu_BUS.Instance.LayThongTinHoSo_BUS(txtMaNV, codeMaNV, codeTenNV))
            {
                gunaPanel1.Enabled = true;
            }
        }
    }
}
