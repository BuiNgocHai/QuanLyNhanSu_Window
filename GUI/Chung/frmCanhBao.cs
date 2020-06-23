using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmShowDialogYN : Form
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

        private static frmShowDialogYN instance;

        public static frmShowDialogYN Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new frmShowDialogYN();
                }

                return instance;
            }
        }





        public frmShowDialogYN()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        private void frmShowDialogYN_Load(object sender, EventArgs e)
        {

        }

        public void capNhatLoiNhan(string txtLoiNhan)
        {
            labelXacNhan.Text = txtLoiNhan;
        }






    }
}
