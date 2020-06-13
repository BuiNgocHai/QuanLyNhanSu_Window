using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChucVu_DTO
    {
        private string maCV;
        private string tenCV;
        private float heSoPhuCap;
        public ChucVu_DTO()
        {

        }

        public ChucVu_DTO(string maCV, string tenCV,float hspv)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.heSoPhuCap = hspv;
        }

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public float HeSoPhuCap { get => heSoPhuCap; set => heSoPhuCap = value; }
    }
}
