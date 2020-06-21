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
using QuanLyNhanSu_Nhom6.Chung;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInThongKeTrinhDoNgoaiNgu : Form
    {
		
		public frmInThongKeTrinhDoNgoaiNgu()
        {
            InitializeComponent();
            this.gunaLabel1.Parent = gunaPictureBox1;
            this.gunaLabel1.BackColor = Color.Transparent;
            this.btnExit.Parent = gunaPictureBox1;
            this.btnExit.BackColor = Color.Transparent;
            this.btnMinimize.Parent = gunaPictureBox1;
            this.btnMinimize.BackColor = Color.Transparent;
            this.panelChonChucNang.Parent = gunaPictureBox1;
            this.panelChonMucThongKe.Parent = panel1;
        }

        private void frmInQuanLyTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            cbNgoaiNgu.Enabled = false;
            cbTrinhDo.Enabled = false;
            ThongKeTrinhDoNgoaiNgu_BUS.Instance.layDLNgoaiNgu_BUS(cbNgoaiNgu);

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

        private void btnXem_Click(object sender, EventArgs e)
        {

        }
    }
}
