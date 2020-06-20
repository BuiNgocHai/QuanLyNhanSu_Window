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
using BUS.BUS;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInThongKePhongBanChucVu : Form
    {
        public frmInThongKePhongBanChucVu()
        {
            InitializeComponent();
            this.gunaLabel1.Parent = gunaPictureBox1;
            //this.gunaLabel1.BackColor = Color.Transparent;
            this.btnExit.Parent = gunaPictureBox1;
            this.btnExit.BackColor = Color.Transparent;
            this.btnMinimize.Parent = gunaPictureBox1;
            this.btnMinimize.BackColor = Color.Transparent;
            this.panelChonChucNang.Parent = gunaPictureBox1;
            this.panelChonMucThongKe.Parent = panel1;

        }

        private void frmInThongKePhongBanChucVu_Load(object sender, EventArgs e)
        {

            cbTenChucVu.Enabled = false;
            cbTenPhongBan.Enabled = false;
            QuanLyNhanVienChucVu_BUS.Instance.layDLCombox_BUS(cbTenChucVu);
            ThongKePhongBanChucVu_BUS.Instance.layDLTenPhongBan_BUS(cbTenPhongBan);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            cbTenPhongBan.Enabled = true;
            cbTenChucVu.Enabled = false;
        }

        private void rdChucVu_CheckedChanged(object sender, EventArgs e)
        {
            cbTenChucVu.Enabled = true;
            cbTenPhongBan.Enabled = false;
        }
    }

}
