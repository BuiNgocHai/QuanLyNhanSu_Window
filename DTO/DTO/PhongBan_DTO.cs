using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan_DTO
    {
        public string maPB { get; set; }
        public string tenPB { get; set; }
        public DateTime ngayTL { get; set; }
        public PhongBan_DTO(string maPB, string tenPB, DateTime ngayTL)
        {
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.ngayTL = ngayTL;
        }
        public PhongBan_DTO()
        {

        }
    }
}
