using DAO;
using Guna.UI.WinForms;


namespace BUS
{
    public class DangNhap_BUS
    {
        private static DangNhap_BUS instance;

        public static DangNhap_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DangNhap_BUS();
                }

                return instance;
            }
        }

        public DangNhap_BUS()
        {

        }

        public int dangNhap_BUS(GunaTextBox txtTaiKhoan, GunaTextBox txtMatKhau)//, GunaLabel lb, GunaButton btn1, GunaButton btn2)
        {
            int kt = DangNhap_DAO.Instance.dangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (kt == 1)
            {
                return 1;
            }
            else if (kt == 2)
            {
                return 2;
            }
            return 0;
        }
    }
}
