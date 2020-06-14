using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhongBan_DTO
    {
        private string maPhongBan { get; set; }
        private string tenPhongBan { get; set; }
        private DateTime ngayThanhLap { get; set; }

        public PhongBan_DTO()
        {

        }
        public PhongBan_DTO(string mapb,string tenpb, DateTime ntl)
        {
            this.maPhongBan = mapb;
            this.tenPhongBan = tenpb;
            this.ngayThanhLap = ntl;
        }
    }
}
