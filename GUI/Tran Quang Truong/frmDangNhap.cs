using BUS;
using QuanLyNhanSu_Nhom6.Chung;
using QuanLyNhanSu_Nhom6.Views;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6
{
    public partial class frmLogin : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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


        public frmLogin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            frmShowDialogYN d = new frmShowDialogYN();
            d.ShowDialog();
            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void gunaPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int kt = DangNhap_BUS.Instance.dangNhap_BUS(txtTK, txtMK);
            if (kt == 1)
            {
                frmDashboard Instance = new frmDashboard();
                Instance.Show();
                Close();
            }
            else if (kt == 2)
            {
                frmDashboard Instance = new frmDashboard();
                Instance.capNhatDangNhap();
                Instance.Show();
                Close();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thông tin tài khoản và mật khẩu \n không chính xác!");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }
    }
}
