using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public   class HoSoNV_DTO
    {
        private string maNV;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh ;
        private string sDT;
        private string email;
        private DateTime ngayTD;
        private string maPB;
        private string taiKhoan;
        private string matKhau;
        private string quyen;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgayTD { get => ngayTD; set => ngayTD = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }

        public HoSoNV_DTO(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string sDT, string email, DateTime ngayTD, string maPB, string taiKhoan, string matKhau, string quyen)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
            this.Email = email;
            this.NgayTD = ngayTD;
            this.MaPB = maPB;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.Quyen = quyen;
        }

        public HoSoNV_DTO()
        {

        }
    }

}
