using System;
using System.Windows.Forms;
using BUS;
using BUS.BUS;
using QuanLyNhanSu_Nhom6.Chung;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQuanLyTrinhDoNgoaiNgu : Form
    {
        public frmQuanLyTrinhDoNgoaiNgu()
        {
            InitializeComponent();
        }

		private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
        private void frmQuanLyTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            gunaPanel1.Enabled = false;

            QuanLyTrinhDoNgoaiNgu_BUS.Instance.layDLCombox_BUS(cbNgoaiNgu);

        }
        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
            bool kt = QuanLyTrinhDoNgoaiNgu_BUS.Instance.layThongTinHoSo_BUS(txtMaNV, codeMaNV, codeTenNV);
            if (kt)
            {
                gunaPanel1.Enabled = true;
                QuanLyTrinhDoNgoaiNgu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
            else if (kt == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy nhân viên này!");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }

		private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                int index = e.RowIndex;
                txtMaNV.Text = gunaDataGridView1.Rows[index].Cells["manhanvien"].Value.ToString();
                cbNgoaiNgu.Text = gunaDataGridView1.Rows[index].Cells["ngoaingu"].Value.ToString();
                txtTrinhDo.Text = gunaDataGridView1.Rows[index].Cells["trinhDo"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

		private void btnThem_Click(object sender, EventArgs e)
		{
            bool thucthi = QuanLyTrinhDoNgoaiNgu_BUS.Instance.themNVCV_BUS(codeMaNV, cbNgoaiNgu, txtTrinhDo);
            if (thucthi == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Nhân viên không tồn tại");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else if (codeMaNV.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Mã Nhân Viên Không Được Trống");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else if (txtTrinhDo.Text == ""){
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trình Độ Không Được Trống");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Thêm thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyTrinhDoNgoaiNgu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
        }

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
            bool thucthi = QuanLyTrinhDoNgoaiNgu_BUS.Instance.capnhatNVCV_BUS(codeMaNV, cbNgoaiNgu, txtTrinhDo);
            if (thucthi == false)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Nhân viên không tồn tại");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else if (codeMaNV.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Mã Nhân Viên Không Được Trống");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else if (txtTrinhDo.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trình Độ Không Được Trống");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Sửa thành công");
                frmCanhBaoOK.Instance.ShowDialog();
                QuanLyTrinhDoNgoaiNgu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
            }
        }

		private void btnXoa_Click(object sender, EventArgs e)
		{
            frmShowDialogYN.Instance.capNhatLoiNhan("Bạn có muốn xoá không?");
            DialogResult rs = frmShowDialogYN.Instance.ShowDialog();
            if (rs == DialogResult.Yes)
            {
                bool thucthi = QuanLyTrinhDoNgoaiNgu_BUS.Instance.xoaNVCV_BUS(codeMaNV, cbNgoaiNgu, txtTrinhDo);
                if (thucthi == false)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Nhân viên không tồn tại");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else if (codeMaNV.Text == "")
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Mã Nhân Viên Không Được Trống");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Xóa thành công");
                    frmCanhBaoOK.Instance.ShowDialog();
                    QuanLyTrinhDoNgoaiNgu_BUS.Instance.layDLTable_BUS(gunaDataGridView1, codeMaNV);
                }
            }
        }
	}
}
