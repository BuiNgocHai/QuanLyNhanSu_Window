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
using QuanLyNhanSu_Nhom6.Chung;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmQuanLyTrinhDoChuyenMon : Form
    {
        public frmQuanLyTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool check = TrinhDoChuyenMon_BUS.Instance.timKiemTrinhDoChuyenMon_BUS(txtMaNhanVien,codeTenNV, gunaDataGridView1);
            codeMaNV.Text = txtMaNhanVien.Text.ToUpper();
            if (check==false )
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {                
                pl.Enabled = true;
                
            }
        }

        private void frmQuanLyTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            pl.Enabled = false;
            cbbTrinhDo.Text = "ĐẠI HỌC";
            cbbLoaiHinhDaoTao.Text = "Chính quy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNganh.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Ngành không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if (txtTruongDaoTao.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trường đào tao không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }


            int kq = TrinhDoChuyenMon_BUS.Instance.themTrinhDoChuyenMon(codeMaNV, cbbTrinhDo, cbbLoaiHinhDaoTao, txtTruongDaoTao, txtNganh);
            if(kq == 0)
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trùng ngành đào tạo");
                frmCanhBaoOK.Instance.ShowDialog();
            }
            else
            {
                TrinhDoChuyenMon_BUS.Instance.hienThi(gunaDataGridView1, codeMaNV);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNganh.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Ngành không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            if (txtTruongDaoTao.Text == "")
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Trường đào tao không được để trống");
                frmCanhBaoOK.Instance.ShowDialog();
                return;
            }

            TrinhDoChuyenMon_BUS.Instance.capNhapTrinhDoChuyenMon(txtNganh, cbbTrinhDo, cbbLoaiHinhDaoTao, txtTruongDaoTao);
            TrinhDoChuyenMon_BUS.Instance.hienThi(gunaDataGridView1, codeMaNV);
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrent = e.RowIndex;

            txtNganh.Text = gunaDataGridView1.Rows[rowCurrent].Cells[1].Value.ToString();
            cbbTrinhDo.Text = gunaDataGridView1.Rows[rowCurrent].Cells[2].Value.ToString();
            cbbLoaiHinhDaoTao.Text = gunaDataGridView1.Rows[rowCurrent].Cells[3].Value.ToString();
            txtTruongDaoTao.Text = gunaDataGridView1.Rows[rowCurrent].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(TrinhDoChuyenMon_BUS.Instance.xoaTrinhDoChuyenMon(codeMaNV,txtNganh) == 1)
            {
                TrinhDoChuyenMon_BUS.Instance.hienThi(gunaDataGridView1, codeMaNV);
            }else
            {
                frmCanhBaoOK.Instance.capNhatLoiNhan("Xoa that bai");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }

    
    }
}
