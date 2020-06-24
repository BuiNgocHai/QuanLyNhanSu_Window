using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
  public  class QuanLyNhanVienChucVu_DTO
    {
        
        private string maNV;
        private string maCV;
        private DateTime tuNgay;
        private string denNgay;

        public QuanLyNhanVienChucVu_DTO()
        {
                
        }

        public QuanLyNhanVienChucVu_DTO(string maNV, string maCV, DateTime tuNgay, string denNgay)
        {
            this.maNV = maNV;
            this.maCV = maCV;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public string DenNgay { get => denNgay; set => denNgay = value; }
    }
}
