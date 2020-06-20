using DAO.DAO;
using DTO;
using Guna.UI.WinForms;

namespace BUS
{
    public class TrinhDoChuyenMon_BUS
    {
        private static TrinhDoChuyenMon_BUS instance;

        public static TrinhDoChuyenMon_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new TrinhDoChuyenMon_BUS();
                }

                return instance;
            }
        }

        public TrinhDoChuyenMon_BUS()
        {

        }

        public bool timKiemTrinhDoChuyenMon_BUS(GunaTextBox maNV, GunaLabel txtTenNV, GunaDataGridView gr)
        {
            HoSoNV_DTO nv = new HoSoNV_DTO
            {
                MaNV = maNV.Text
            };
            TrinhDoChuyenMon_DAO.createInstance.timKiemTrinhDoChuyenMon_DAO(nv);
            txtTenNV.Text = nv.HoTen;
            if (nv.HoTen == null)
            {
                return false;
            }
            TrinhDoChuyenMon_DAO.createInstance.hienThi(gr, nv.MaNV);
                return true;
        }

        public void hienThi(GunaDataGridView gr, GunaLabel txtMaNV)
        {
            TrinhDoChuyenMon_DAO.createInstance.hienThi(gr, txtMaNV.Text);
        }

        public int themTrinhDoChuyenMon(GunaLabel ma, GunaComboBox td, GunaComboBox lh, GunaTextBox truong, GunaTextBox ng)
        {
            TrinhDoChuyenMon_DTO tdcm = new TrinhDoChuyenMon_DTO(ma.Text, ng.Text, td.SelectedItem.ToString(), lh.SelectedItem.ToString(), truong.Text);

            return TrinhDoChuyenMon_DAO.createInstance.themTrinhDoChuyenMon(tdcm);
        }

        public int capNhapTrinhDoChuyenMon(GunaTextBox nganh,GunaComboBox td,GunaComboBox lh,GunaTextBox truong)
        {
            return TrinhDoChuyenMon_DAO.createInstance.capNhapTrinhDoChuyenMon(nganh.Text, td.SelectedItem.ToString(), lh.SelectedItem.ToString(), truong.Text);

        }

        public int xoaTrinhDoChuyenMon(GunaLabel ma,GunaTextBox nganh)
        {
            return TrinhDoChuyenMon_DAO.createInstance.xoaTrinhDoChuyenMon(nganh.Text, ma.Text);
        }
    }
}
