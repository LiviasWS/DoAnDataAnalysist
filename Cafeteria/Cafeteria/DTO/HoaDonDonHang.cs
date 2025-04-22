using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    class HoaDonDonHang
    {
        private int maHD;
        private int maDonHang;

        public HoaDonDonHang(int maHD, int maDonHang)
        {
            this.maHD = maHD;
            this.maDonHang = maDonHang;
        }

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
    }
}
