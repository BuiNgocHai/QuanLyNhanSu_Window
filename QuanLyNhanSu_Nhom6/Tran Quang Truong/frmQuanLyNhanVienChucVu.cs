using BUS;
using QuanLyNhanSu_Nhom6.Chung;
using System;
using System.Windows.Forms;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQuanLyNhanVienChucVu : Form
    {

        private static frmQuanLyNhanVienChucVu instance;
        public static frmQuanLyNhanVienChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmQuanLyNhanVienChucVu();
                }

                return instance;
            }
        }

        public frmQuanLyNhanVienChucVu()
        {
            InitializeComponent();
          
        }

        private void frmQuanLyNhanVienChucVu_Load(object sender, EventArgs e)
        {
            gunaPanel1.Enabled = false;
            
            QuanLyNhanVienChucVu_BUS.Instance.layDLCombox_BUS(cbTenCV);


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool kt = QuanLyNhanVienChucVu_BUS.Instance.layThongTinHoSo_BUS(txtMaNV, codeMaNV, codeTenNV);
            if (kt)
            {
                gunaPanel1.Enabled = true;
                QuanLyNhanVienChucVu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
            else if (kt == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy nhân viên này!");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool thucthi = QuanLyNhanVienChucVu_BUS.Instance.themNVCV_BUS(codeMaNV, cbTenCV, dtTuNgay, dtDenNgay);
            if (thucthi == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trùng ngày bắt đầu");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thêm thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyNhanVienChucVu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }

        }

        private void cbTenCV_SelectedValueChanged(object sender, EventArgs e)
        {
            codeMaCV.Text = cbTenCV.SelectedValue.ToString();

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                codeMaCV.Text = gunaDataGridView1.Rows[index].Cells["maChucVu"].Value.ToString();
                cbTenCV.Text = gunaDataGridView1.Rows[index].Cells["tenChucVu"].Value.ToString();
                dtTuNgay.Value = DateTime.Parse(gunaDataGridView1.Rows[index].Cells["tuNgay"].Value.ToString());
                dtDenNgay.Value = DateTime.Parse(gunaDataGridView1.Rows[index].Cells["denNgay"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool kt = QuanLyNhanVienChucVu_BUS.Instance.capnhatNVCV_BUS(codeMaNV, codeMaCV, dtTuNgay, dtDenNgay);
            if (kt == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Ngày bắt đầu không được sửa");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Sửa thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyNhanVienChucVu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmShowDialogYN.Instance.capNhatLoiNhan("Bạn có muốn xoá không?");
            DialogResult rs =  frmShowDialogYN.Instance.ShowDialog();
            if(rs == DialogResult.Yes)
            {
                bool kt = QuanLyNhanVienChucVu_BUS.Instance.xoaNVCV_BUS(codeMaNV, codeMaCV, dtTuNgay);
                if (kt == false)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    QuanLyNhanVienChucVu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
                }
            }
            
        }

       
    }
}
