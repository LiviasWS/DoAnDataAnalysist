using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    class SanPham
    {
        private int maSP;
        private String tenSP;
        private int giaTien;
        private String loaiSP;

        public SanPham(int maSP, string tenSP, int giaTien, string loaiSP)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaTien = giaTien;
            this.loaiSP = loaiSP;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }
    }
}
