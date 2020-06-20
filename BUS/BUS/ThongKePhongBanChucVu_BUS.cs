using DAO.DAO;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
   public class ThongKePhongBanChucVu_BUS
    {
        private static ThongKePhongBanChucVu_BUS instance;

        public static ThongKePhongBanChucVu_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ThongKePhongBanChucVu_BUS();
                }

                return instance;
            }
        }

        public void layDLTenPhongBan_BUS(GunaComboBox cb)
        {
            ThongKePhongBanChucVu_DAO.Instance.layDLTenPhongBan_DAO(cb);
        }
    }
}
