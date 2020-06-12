using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
