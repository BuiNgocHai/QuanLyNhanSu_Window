using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Diagnostics.Eventing.Reader;

namespace BUS
{
    public class QuanLyPhongBan_BUS
    {
        private static QuanLyPhongBan_BUS instance;
        private QuanLyPhongBan_DAO qlpb= new QuanLyPhongBan_DAO();
        public static QuanLyPhongBan_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyPhongBan_BUS();
                }

                return instance;
            }
        }
        public QuanLyPhongBan_BUS()
        {

        }

        public void hienTHiGridView(DataGridView dt)
        {
            qlpb.hienThiDT_DAO(dt);
        }
        public bool themPhongBan(GunaTextBox maPB,GunaTextBox tenPB,GunaDateTimePicker ngayTL)
        {
            string mapb = maPB.Text;
            string tenpb = tenPB.Text;
            DateTime ngaytl = ngayTL.Value;
            bool output = qlpb.themPhongBan(mapb, tenpb, ngaytl);
            return output;
        }

        public bool suaPhongBan(GunaTextBox maPB,GunaTextBox tenPB, GunaDateTimePicker ngayTL)
        {
            string mapb = maPB.Text;
            string tenpb = tenPB.Text;
            DateTime ngaytl = ngayTL.Value;
            bool output = qlpb.suaPhongBan(mapb, tenpb, ngaytl);
            return output;
        }

        public bool xoaPhongBan(GunaTextBox maPB, GunaTextBox tenPB, GunaDateTimePicker ngayTL)
        {
            string mapb = maPB.Text;
            string tenpb = tenPB.Text;
            DateTime ngaytl = ngayTL.Value;
            bool output = qlpb.xoaPhongBan(mapb, tenpb, ngaytl);
            return output;
        }

        public void timKiemPhongBan(GunaTextBox maPB,DataGridView dt)
        {
            string mapb = maPB.Text;
            qlpb.timKiemPhongBan(dt,mapb);
        }
    }
}
