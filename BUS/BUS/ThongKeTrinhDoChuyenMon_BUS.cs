using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.DAO;
using Guna.UI.WinForms;

namespace BUS.BUS
{
    public class ThongKeTrinhDoChuyenMon_BUS
    {
        public static ThongKeTrinhDoChuyenMon_BUS instance;

        public static ThongKeTrinhDoChuyenMon_BUS createInstance
        {
            get {
                if (instance == null)
                {
                    instance = new ThongKeTrinhDoChuyenMon_BUS();
                }
                return instance;
            }
        }

        public int thongKeTrinhDoChuyenMon(string strTK, GunaDataGridView dg, int kieu)
        {
            return ThongKeTrinhDoChuyenMon_Dao.createInstance.thongKeTrinhDo(strTK,dg,kieu);
    }
    }
}
