using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class TrinhDoChuyenMon_DTO
    {
        private string manv;
        private string nganh;
        private string trinhDo;
        private string loaiHinhDT;
        private string truongDT;

        public TrinhDoChuyenMon_DTO()
        {

        }

        public TrinhDoChuyenMon_DTO(string manv, string nganh, string trinhDo, string loaiHinhDT, string truongDT)
        {
            this.manv = manv;
            this.nganh = nganh;
            this.trinhDo = trinhDo;
            this.loaiHinhDT = loaiHinhDT;
            this.truongDT = truongDT;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string LoaiHinhDT { get => loaiHinhDT; set => loaiHinhDT = value; }
        public string TruongDT { get => truongDT; set => truongDT = value; }
        
    }
}
