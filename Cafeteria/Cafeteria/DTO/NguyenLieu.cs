using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class NguyenLieu
    {
        private int maNL;
        private string tenNL;
        public int MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }

        public NguyenLieu() { }
        public NguyenLieu(int maNL, string tenNL)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;

        }
        public override string ToString()
        {
            return $"{maNL} - {tenNL}";
        }

    }
}
