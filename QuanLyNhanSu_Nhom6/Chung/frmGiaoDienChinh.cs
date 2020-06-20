using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmDashboard : Form
    {
        private Form frmCon;

        private void moFrmCon(Form frmMoi)
        {
            if (frmCon != null)
            {
                frmCon.Close();
            }
            frmCon = frmMoi;
            //End
            frmMoi.TopLevel = false;
            frmMoi.FormBorderStyle = FormBorderStyle.None;
            frmMoi.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(frmMoi);
            panelMenu.Tag = frmMoi;
            frmMoi.BringToFront();
            frmMoi.Show();
        }












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

        public frmDashboard()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void gunaPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        //Tạo Instance(trường)
        private static frmDashboard instance;

        public static frmDashboard Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new frmDashboard();
                }

                return instance;
            }
        }
        //end
        // Tạo update khi đăng nhập(trường)
        public void capNhatDangNhap()
        {
            labelTenFrom.Text = "Employee Dashboard";
            panelTTNV.Dispose();
            panelQLDM.Dispose();
            panelTKBC.Location = new System.Drawing.Point(0,0);
         
            

        }







        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
        }




        //Cài đặt thời gian sổ Menu        
        private bool isCollapsed;

        private void time(Panel panel, Timer time)
        {
            if (isCollapsed)
            {

                panel.Height += 10;
                if (panel.Size == panel.MaximumSize)
                {
                    time.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel.Height -= 10;
                if (panel.Size == panel.MinimumSize)
                {
                    time.Stop();
                    isCollapsed = true;
                }
            }

        }
        //Xử lý sự kiện click menu
        private void timer1_Tick(object sender, EventArgs e)
        {

            time(panelQLDM, timer1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            time(panelTTNV, timer2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time(panelTKBC, timer3);
        }


        // xử lý các button 
        private void btnQLNV_Click(object sender, EventArgs e)
        {

            timer2.Start();
        }

        private void btnQLDM_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnTDCM_Click(object sender, EventArgs e)
        {
            
        }


        private void btnNhanVienChucVu_Click(object sender, EventArgs e)
        {

            moFrmCon( new frmQuanLyNhanVienChucVu());
        }
        private void btnQuaTrinhCongTac_Click(object sender, EventArgs e)
        {

            moFrmCon(new frmQuanLyQuaTrinhCongTac());
        }
        private void btnTrinhDoNgoaiNgu_Click(object sender, EventArgs e)
		{
            moFrmCon(new frmQuanLyTrinhDoNgoaiNgu());
        }
        private void btnPBCV_Click(object sender, EventArgs e)
        {
            moFrmCon(new frmInThongKePhongBanChucVu());
        }
        private void btnTDNN_Click(object sender, EventArgs e)
		{
            moFrmCon(new frmInThongKeTrinhDoNgoaiNgu());
		}
        private void labelTenFrom_Click(object sender, EventArgs e)
        {
            if(frmCon!=null)
            frmCon.Close();
            
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

