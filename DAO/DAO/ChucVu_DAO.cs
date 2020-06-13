using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ChucVu_DAO
    {
        private static ChucVu_DAO chucVu_Dao;

        public static ChucVu_DAO createInstance
        {
            get
            {
                if(chucVu_Dao == null)
                {
                    chucVu_Dao = new ChucVu_DAO();
                }
                return chucVu_Dao;
            }
        }

        public ChucVu_DAO()
        {

        }


    }
}
