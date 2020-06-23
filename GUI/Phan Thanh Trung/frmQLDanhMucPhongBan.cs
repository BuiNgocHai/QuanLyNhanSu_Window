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
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQLDanhMucPhongBan : Form
    {
        private QuanLyPhongBan_BUS qlpb_bus = new QuanLyPhongBan_BUS();
        public frmQLDanhMucPhongBan()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQLDanhMucPhongBan_Load(object sender, EventArgs e)
        {
            qlpb_bus.hienTHiGridView(dtGridViewPhongBan);
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridViewPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try {
                txbMaPhongBan.Text = dtGridViewPhongBan.Rows[index].Cells[0].Value.ToString();
                txbTenPhongBan.Text = dtGridViewPhongBan.Rows[index].Cells[1].Value.ToString();
                txbNgayThanhLap.Text = dtGridViewPhongBan.Rows[index].Cells[2].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txbMaPhongBan.Text = "";
            txbTenPhongBan.Text = "";
            txbNgayThanhLap.Text = "";
            txbMaPhongBan.Focus();
        }

        private void dtGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                txbMaPhongBan.Text = dtGridViewPhongBan.Rows[index].Cells[0].Value.ToString();
                txbTenPhongBan.Text = dtGridViewPhongBan.Rows[index].Cells[1].Value.ToString();
                txbNgayThanhLap.Text = dtGridViewPhongBan.Rows[index].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            bool ans = qlpb_bus.themPhongBan(txbMaPhongBan, txbTenPhongBan, txbNgayThanhLap);
            if(ans)
            {
                DialogResult k = MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                DialogResult k = MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }

        private void btnSuaPhongBan_Click(object sender, EventArgs e)
        {
            bool ans = qlpb_bus.suaPhongBan(txbMaPhongBan, txbTenPhongBan, txbNgayThanhLap);
            if (ans)
            {
                DialogResult k = MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                DialogResult k = MessageBox.Show("Sửa không thành công", "Thông báo");
            }
        }

        private void btnXoaPhongBan_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Việc xóa có thể gây mất mát dữ liệu ở các bảng liên quan.Bạn có chắc chắn muốn xóa không?", "Thông báo");
            if (k == DialogResult.OK)
            {
                bool ans = qlpb_bus.xoaPhongBan(txbMaPhongBan, txbTenPhongBan, txbNgayThanhLap);
                if (ans)
                {
                    DialogResult k1 = MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    DialogResult k1 = MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
            else
            {
                return;
            }
        }

        private void btnBoTimPhongBan_Click(object sender, EventArgs e)
        {
            qlpb_bus.hienTHiGridView(dtGridViewPhongBan);
        }

        private void btnTimKiemPhongBan_Click(object sender, EventArgs e)
        {
            qlpb_bus.timKiemPhongBan(txbMaPhongBan, dtGridViewPhongBan);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
