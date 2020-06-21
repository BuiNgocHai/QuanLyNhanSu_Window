using System;
using System.Windows.Forms;
using BUS;
using BUS.BUS;


using QuanLyNhanSu_Nhom6.Chung;
namespace QuanLyNhanSu_Nhom6.Views
{
	public partial class frmQuanLyQuaTrinhCongTac : Form
    {
        public frmQuanLyQuaTrinhCongTac()
        {
            InitializeComponent();
        }


        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyQuaTrinhCongTac_Load(object sender, EventArgs e)
        {
            gunaPanel1.Enabled = false;

            QuanLyQuaTrinhCongTac_BUS.Instance.layDLCombox_BUS(cbTenCV);

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool kt = QuanLyQuaTrinhCongTac_BUS.Instance.layThongTinHoSo_BUS(txtMaNV, codeMaNV, codeTenNV);
            if (kt)
            {
                gunaPanel1.Enabled = true;
                QuanLyQuaTrinhCongTac_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
            else if (kt == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy nhân viên này!");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }
        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

		private void btnThem_Click(object sender, EventArgs e)
		{
            bool thucthi = QuanLyQuaTrinhCongTac_BUS.Instance.themNVCV_BUS(codeMaNV, cbTenCV, dtTuNgay, dtDenNgay, gunaTextBox1);
            if (thucthi == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trùng ngày bắt đầu");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thêm thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyQuaTrinhCongTac_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
        }

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
            bool kt = QuanLyQuaTrinhCongTac_BUS.Instance.capnhatNVCV_BUS(codeMaNV, cbTenCV, dtTuNgay, dtDenNgay, gunaTextBox1);
            if (kt == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Ngày bắt đầu không được sửa");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Sửa thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyQuaTrinhCongTac_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }

        }

		private void btnXoa_Click(object sender, EventArgs e)
		{
            frmShowDialogYN.Instance.capNhatLoiNhan("Bạn có muốn xoá không?");
            DialogResult rs = frmShowDialogYN.Instance.ShowDialog();
            if (rs == DialogResult.Yes)
            {
                bool kt = QuanLyQuaTrinhCongTac_BUS.Instance.xoaNVCV_BUS(codeMaNV, dtTuNgay);
                if (kt == false)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Xóa thành công");
                    frmCanhBaoOK.Instance.ShowDialog();
                    QuanLyQuaTrinhCongTac_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
                }
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtMaNV.Text = gunaDataGridView1.Rows[index].Cells["maChucVu"].Value.ToString();
                dtTuNgay.Value = DateTime.Parse(gunaDataGridView1.Rows[index].Cells["tuNgay"].Value.ToString());
                dtDenNgay.Value = DateTime.Parse(gunaDataGridView1.Rows[index].Cells["denNgay"].Value.ToString());
                gunaTextBox1.Text = gunaDataGridView1.Rows[index].Cells["NOICT"].Value.ToString();
                cbTenCV.Text = gunaDataGridView1.Rows[index].Cells["tenChucVu"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

		private void gunaPictureBox1_Click_2(object sender, EventArgs e)
		{

		}
	}
}
