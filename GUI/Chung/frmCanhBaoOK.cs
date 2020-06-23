using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6.Chung
{
    public partial class frmCanhBaoOK : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public frmCanhBaoOK()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

        }

        private static frmCanhBaoOK instance;

        public static frmCanhBaoOK Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new frmCanhBaoOK();
                }

                return instance;
            }
        }

        public void capNhatLoiNhan(string txtLoiNhan)
        {
            labelXacNhan.Text = txtLoiNhan;
        }

        
    }
}
