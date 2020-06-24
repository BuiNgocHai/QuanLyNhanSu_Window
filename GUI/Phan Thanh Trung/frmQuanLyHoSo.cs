using BUS;
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
            dtPickerNS.Value = DateTime.Now;
            dtPickerNTD.Value = DateTime.Now;
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
                dtPickerNS.Value = Convert.ToDateTime(dtGridViewHoSo.Rows[index].Cells[2].Value);
                cbBoxGioiTinh.SelectedValue = dtGridViewHoSo.Rows[index].Cells[3].Value.ToString();
                txbSoDT.Text = dtGridViewHoSo.Rows[index].Cells[4].Value.ToString();
                txbEmail.Text = dtGridViewHoSo.Rows[index].Cells[5].Value.ToString();
                dtPickerNTD.Value = Convert.ToDateTime(dtGridViewHoSo.Rows[index].Cells[6].Value);
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
                dtPickerNS.Value = DateTime.Now;
                dtPickerNTD.Value = DateTime.Now;
                txbQuyen.Text = "";
                txbSoDT.Text = "";
                txbTenNV.Text = "";
                txbTaiKhoan.Text = "";

            }
            btnChuyenNVCV.Enabled = true;
            btnChuyenQTCT.Enabled = true;
            btnChuyenTDCM.Enabled = true;
            btnChuyenTDNN.Enabled = true;
            maNV = txbMaNV.Text;
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            bool output = qlhs_bus.themHoSoNhanVien(txbMaNV, txbTenNV, dtPickerNS, cbBoxGioiTinh, txbSoDT, txbEmail, dtPickerNTD, cbBoxMaPB, txbTaiKhoan, txbMatKhau, txbQuyen);
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
            bool output = qlhs_bus.suaHoSoNhanVien(txbMaNV, txbTenNV, dtPickerNS, cbBoxGioiTinh, txbSoDT, txbEmail, dtPickerNTD, cbBoxMaPB, txbTaiKhoan, txbMatKhau, txbQuyen);
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
    }
}
