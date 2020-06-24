using BUS;
using QuanLyNhanSu_Nhom6.Views;
using System;
using System.Windows.Forms;
namespace GUI.Phan_Thanh_Trung
{
    public partial class frmQuanLyHoSo : Form
    {
        private QuanLyHoSo_BUS qlhs_bus = new QuanLyHoSo_BUS();
        public static string maNV = null;
        public frmQuanLyHoSo()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoSo_Load(object sender, EventArgs e)
        {
            qlhs_bus.hienThi(dtGridViewHoSo);
            qlhs_bus.loadCBBox(cbBoxMaPB);
            cbBoxGioiTinh.SelectedIndex = 0;
            btnChuyenNVCV.Enabled = false;
            btnChuyenQTCT.Enabled = false;
            btnChuyenTDCM.Enabled = false;
            btnChuyenTDNN.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            qlhs_bus.hienThi(dtGridViewHoSo);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txbEmail.Text = "";
            txbMaNV.Text = "";
            txbMatKhau.Text = "";
            txbNgaySinh.Text = "";
            txbNgayTD.Text = "";
            txbQuyen.Text = "";
            txbSoDT.Text = "";
            txbTaiKhoan.Text = "";
            txbTenNV.Text = "";
            cbBoxGioiTinh.SelectedIndex = 0;
            cbBoxMaPB.SelectedIndex = 0;
            txbMaNV.Focus();

        }

        private void dtGridViewHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
 
            try { 
                txbMaNV.Text = dtGridViewHoSo.Rows[index].Cells[0].Value.ToString();
                txbTenNV.Text = dtGridViewHoSo.Rows[index].Cells[1].Value.ToString();
                txbNgaySinh.Text = dtGridViewHoSo.Rows[index].Cells[2].Value.ToString();
                cbBoxGioiTinh.SelectedValue = dtGridViewHoSo.Rows[index].Cells[3].Value.ToString();
                txbSoDT.Text = dtGridViewHoSo.Rows[index].Cells[4].Value.ToString();
                txbEmail.Text = dtGridViewHoSo.Rows[index].Cells[5].Value.ToString();
                txbNgayTD.Text = dtGridViewHoSo.Rows[index].Cells[6].Value.ToString();
                cbBoxMaPB.SelectedValue = dtGridViewHoSo.Rows[index].Cells[7].Value.ToString();
                txbTaiKhoan.Text = dtGridViewHoSo.Rows[index].Cells[8].Value.ToString();
                txbMatKhau.Text = dtGridViewHoSo.Rows[index].Cells[9].Value.ToString();
                txbQuyen.Text = dtGridViewHoSo.Rows[index].Cells[10].Value.ToString();
            }
            catch(Exception)
            {
              
                txbEmail.Text = "";
                txbMaNV.Text = "";
                txbMatKhau.Text = "";
                txbNgaySinh.Text = "";
                txbNgayTD.Text = "";
                txbQuyen.Text = "";
                txbSoDT.Text = "";
                txbTenNV.Text = "";
                txbTaiKhoan.Text = "";

            }
            //if (dtGridViewHoSo.Rows[index].Cells[5].Value != null)
            //{
            //    txbEmail.Text = dtGridViewHoSo.Rows[index].Cells[5].Value.ToString();
            //}
            //else
            //{
            //    txbEmail.Text = "";
            //}

            //if (dtGridViewHoSo.Rows[index].Cells[0].Value != null)
            //{
            //    txbMaNV.Text = dtGridViewHoSo.Rows[index].Cells[0].Value.ToString();
            //}
            //else
            //{
            //    txbMaNV.Text = "";
            //}

            //if (dtGridViewHoSo.Rows[index].Cells[9].Value != null)
            //{
            //    txbMatKhau.Text = dtGridViewHoSo.Rows[index].Cells[9].Value.ToString();
            //}
            //else
            //{
            //    txbMatKhau.Text = "";
            //}

            //if (dtGridViewHoSo.Rows[index].Cells[2].Value != null)
            //{
            //    txbNgaySinh.Text = dtGridViewHoSo.Rows[index].Cells[2].Value.ToString();
            //}
            //else
            //{
            //    txbNgaySinh.Text = "";
            //}

            //if (dtGridViewHoSo.Rows[index].Cells[6].Value != null)
            //{
            //    txbNgayTD.Text = dtGridViewHoSo.Rows[index].Cells[6].Value.ToString();
            //}
            //else
            //{
            //    txbNgayTD.Text = "";
            //}
            //if (dtGridViewHoSo.Rows[index].Cells[10].Value != null)
            //{
            //    txbQuyen.Text = dtGridViewHoSo.Rows[index].Cells[10].Value.ToString();
            //}
            //else
            //{
            //    txbQuyen.Text = "";
            //}
            //if (dtGridViewHoSo.Rows[index].Cells[4].Value != null)
            //{
            //    txbSoDT.Text = dtGridViewHoSo.Rows[index].Cells[4].Value.ToString();
            //}
            //else
            //{
            //    txbSoDT.Text = "";
            //}
            //if (dtGridViewHoSo.Rows[index].Cells[8].Value != null)
            //{
            //    txbTaiKhoan.Text = dtGridViewHoSo.Rows[index].Cells[8].Value.ToString();
            //}
            //else
            //{
            //    txbTaiKhoan.Text = "";
            //}
            //if (dtGridViewHoSo.Rows[index].Cells[1].Value != null)
            //{
            //    txbTenNV.Text = dtGridViewHoSo.Rows[index].Cells[1].Value.ToString();
            //}
            //else
            //{
            //    txbTenNV.Text = "";
            //}
            //cbBoxGioiTinh.SelectedValue = dtGridViewHoSo.Rows[index].Cells[3].Value.ToString();
            //cbBoxMaPB.SelectedValue = dtGridViewHoSo.Rows[index].Cells[7].Value.ToString();
            btnChuyenNVCV.Enabled = true;
            btnChuyenQTCT.Enabled = true;
            btnChuyenTDCM.Enabled = true;
            btnChuyenTDNN.Enabled = true;
            maNV = txbMaNV.Text;
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            bool output = qlhs_bus.themHoSoNhanVien(txbMaNV, txbTenNV, txbNgaySinh, cbBoxGioiTinh, txbSoDT, txbEmail, txbNgayTD, cbBoxMaPB, txbTaiKhoan, txbMatKhau, txbQuyen);
            if (output)
            {
                DialogResult k = MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                DialogResult k = MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            bool output = qlhs_bus.suaHoSoNhanVien(txbMaNV, txbTenNV, txbNgaySinh, cbBoxGioiTinh, txbSoDT, txbEmail, txbNgayTD, cbBoxMaPB, txbTaiKhoan, txbMatKhau, txbQuyen);
            if (output)
            {
                DialogResult k = MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                DialogResult k = MessageBox.Show("Sửa không thành công", "Thông báo");
            }
        }

        private void btnTimKiemHoSo_Click(object sender, EventArgs e)
        {
            qlhs_bus.timKiemHoSoNhanVien(dtGridViewHoSo, txbMaNV);
        }

        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Việc xóa có thể gây mất mát dữ liệu ở các bảng liên quan. Bạn có chắc chắn muốn xóa không?", "Thông báo");
            if (k == DialogResult.OK)
            {
                bool output = qlhs_bus.xoaHoSoNhanVien(txbMaNV);
                if (output)
                {
                    DialogResult k1 = MessageBox.Show("Xoá thành công", "Thông báo");
                }
                else
                {
                    DialogResult k1 = MessageBox.Show("Xoá không thành công", "Thông báo");
                }
            }

        }

        private void btnChuyenNVCV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVienChucVu frm = new frmQuanLyNhanVienChucVu();
            frm.txtMaNV.Text = maNV;
            frm.ShowDialog();
            
        }

        private void btnChuyenTDCM_Click(object sender, EventArgs e)
        {

        }
    }
}
