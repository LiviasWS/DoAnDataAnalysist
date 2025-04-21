using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    class ChiTietDonHang
    {
        private int maChiTietDonHang;
        private int maDonHang;
        private int maSP;
        private int soLuong;

        public ChiTietDonHang(int maChiTietDonHang, int maDonHang, int maSP, int soLuong)
        {
            this.MaChiTietDonHang = maChiTietDonHang;
            this.MaDonHang = maDonHang;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }
        public ChiTietDonHang(int maDonHang, int maSP, int soLuong)
        {
            this.MaChiTietDonHang = maChiTietDonHang;
            this.MaDonHang = maDonHang;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }

        public int MaChiTietDonHang { get => maChiTietDonHang; set => maChiTietDonHang = value; }
        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
