using GUI.Phan_Thanh_Trung;
using QuanLyNhanSu_Nhom6.Views;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var main = new frmQuanLyChucVu();

            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();

        }

        private static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FormClosed;
            }
        }
    }
}
