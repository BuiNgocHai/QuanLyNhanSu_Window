﻿using QuanLyNhanSu_Nhom6.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new frmQLDanhMucPhongBan();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
            
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
