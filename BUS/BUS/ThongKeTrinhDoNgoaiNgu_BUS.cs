using DAO;
using DTO;
using Guna.UI.WinForms;
using System;
using System.Windows.Forms;
namespace BUS
{
    public class ThongKeTrinhDoNgoaiNgu_BUS
    {
        private static ThongKeTrinhDoNgoaiNgu_BUS instance;

        public static ThongKeTrinhDoNgoaiNgu_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ThongKeTrinhDoNgoaiNgu_BUS();
                }

                return instance;
            }
        }

        public ThongKeTrinhDoNgoaiNgu_BUS()
        {

        }
        public void layDLNgoaiNgu_BUS(GunaComboBox cb)
        {
            ThongKeTrinhDoNgoaiNgu_DAO.Instance.layDLNgoaiNgu_DAO(cb);
        }


    }
}
