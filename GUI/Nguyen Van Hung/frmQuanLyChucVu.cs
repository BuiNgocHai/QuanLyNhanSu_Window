using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using QuanLyNhanSu_Nhom6.Chung;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQuanLyChucVu : Form
    {
        public frmQuanLyChucVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyChucVu_Load(object sender, EventArgs e)
        {
            ChucVu_BUS.createInstance.hienThiDuLieu(gunaDataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaChucVu.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Mã không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if(txtTenChucVu.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Tên không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if(!Regex.IsMatch(txtHeSoPhuCap.Text, "[0-9]+\\.?[0-9]*"))
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Hệ số phụ cấp không hợp lệ...");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            int result = ChucVu_BUS.createInstance.themChucVu_BUS(txtMaChucVu, txtTenChucVu, txtHeSoPhuCap);
            if (result == 0)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thêm thất bại");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thêm thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                ChucVu_BUS.createInstance.hienThiDuLieu(gunaDataGridView1);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ChucVu_BUS.createInstance.hienThiDuLieu(gunaDataGridView1);
        }



        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtMaChucVu.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Mã không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if (txtTenChucVu.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Tên không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if (!Regex.IsMatch(txtHeSoPhuCap.Text, "[0-9]+\\.?[0-9]*"))
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Hệ số phụ cấp không hợp lệ...");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            int result = ChucVu_BUS.createInstance.capNhapDuLieu(txtMaChucVu, txtTenChucVu, txtHeSoPhuCap);
            if (result == 0)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("cap nhat thất bại");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                ChucVu_BUS.createInstance.hienThiDuLieu(gunaDataGridView1);
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrent = e.RowIndex;

            txtMaChucVu.Text = gunaDataGridView1.Rows[rowCurrent].Cells[0].Value.ToString();
            txtTenChucVu.Text = gunaDataGridView1.Rows[rowCurrent].Cells[1].Value.ToString();
            txtHeSoPhuCap.Text = gunaDataGridView1.Rows[rowCurrent].Cells[2].Value.ToString();
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChucVu_BUS.createInstance.xoaDuLieu(txtMaChucVu);
            txtMaChucVu.Clear();
            txtTenChucVu.Clear();
            txtHeSoPhuCap.Clear();
            ChucVu_BUS.createInstance.hienThiDuLieu(gunaDataGridView1);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ChucVu_BUS.createInstance.timKiem(txtMaChucVu, gunaDataGridView1);
        }
    }
}
