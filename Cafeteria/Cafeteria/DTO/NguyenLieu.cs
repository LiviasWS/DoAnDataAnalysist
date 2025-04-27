using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class NguyenLieu
    {
        private int maNL;
        private string tenNL;

        public NguyenLieu() { }

        public int MaNL { get { return maNL; } set { maNL = value; } }
        public string TenNL { get { return tenNL; } set { tenNL = value; } }

    }
}
