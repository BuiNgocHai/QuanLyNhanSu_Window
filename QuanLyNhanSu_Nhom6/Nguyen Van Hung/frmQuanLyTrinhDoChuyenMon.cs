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
    public partial class frmQuanLyTrinhDoChuyenMon : Form
    {
        public frmQuanLyTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pl.Enabled = true;
        }

        private void frmQuanLyTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            pl.Enabled = false;
        }

       
    }
}
