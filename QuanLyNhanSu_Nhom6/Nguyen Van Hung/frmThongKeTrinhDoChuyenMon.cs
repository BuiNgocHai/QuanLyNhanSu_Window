using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;
using QuanLyNhanSu_Nhom6.Chung;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmThongKeTrinhDoChuyenMon : Form
    {
        public frmThongKeTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(rdTrinhDo.Checked)
            {
               if(ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text,gunaDataGridView1,1) == 0)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Khong tim thay trinh do");
                    frmCanhBaoOK.Instance.ShowDialog();
                }else
                {
                    lbNgay.Text =  DateTime.Now.ToString();
                    ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 1);
                }
            }
            if(rdChuyenNganh.Checked)
            {
                if(ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 2) == 0){
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Khong tim thay chuyen nganh");
                    frmCanhBaoOK.Instance.ShowDialog();
                }else
                {
                    lbNgay.Text = DateTime.Now.ToString();
                    ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 2);
                }
            }
        }

        private void frmThongKeTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {

        }
    }
}
