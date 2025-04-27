using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class NhanVien
    {

        public int maNV { get; set; }
        public string hoTen { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public DateTime ngaySinh { get; set; }
        public string role { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public NhanVien(int maNV, string hoTen, string sdt, string diaChi, DateTime ngaySinh, string role, string userName, string password)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.role = role;
            this.userName = userName;
            this.password = password;
        }

        public NhanVien() { }

    }
}
