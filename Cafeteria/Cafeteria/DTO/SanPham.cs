using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class SanPham
    {
        public int maSP { get; set; }
        public string tenSP { get; set; }
        public int giaTien { get; set; }
        public string loaiSP { get; set; }

        public SanPham()
        {

        }

        public SanPham(int maSP, string tenSP, int giaTien, string loaiSP)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaTien = giaTien;
            this.loaiSP = loaiSP;
        }



    }
}
