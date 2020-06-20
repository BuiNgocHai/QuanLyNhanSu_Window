using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using DAO;
using DTO;

using System.Windows.Forms;
namespace BUS
{
    public class ChucVu_BUS
    {
        public static ChucVu_BUS instance;

        public static ChucVu_BUS createInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVu_BUS();
                }
                return instance;
            }
        }

        public ChucVu_BUS()
        {

        }

        public int themChucVu_BUS(GunaTextBox txtMa,GunaTextBox txtTen,GunaTextBox hspc)
        {
            ChucVu_DTO cv = new ChucVu_DTO(txtMa.Text.ToUpper(),txtTen.Text.ToUpper(),Single.Parse(hspc.Text));
            return ChucVu_DAO.createInstance.themChucVu(cv);

        }

        public void hienThiDuLieu(GunaDataGridView gr)
        {
            ChucVu_DAO.createInstance.hienThiDuLieu(gr);
        }

        public int capNhapDuLieu(GunaTextBox ma,GunaTextBox ten,GunaTextBox hspc)
        {
             return ChucVu_DAO.createInstance.capNhatChucVu(ma.Text, ten.Text, Single.Parse(hspc.Text));
        }

        public void xoaDuLieu(GunaTextBox ma){
            ChucVu_DAO.createInstance.xoaChucVu(ma.Text);
        }


        public void timKiem(GunaTextBox ma,DataGridView gr)
        {
            ChucVu_DAO.createInstance.timkiem(ma.Text,gr);
        }
    }
}
