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

        public SanPham(int maSP, string tenSP, int giaTien)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaTien = giaTien;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
    }
}
