using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class ChiTietDonDatHang
    {
        private int maddh;
        private int manl;
        private int soluong;
        private int maqc;
        public ChiTietDonDatHang() { }

        public int Maddh { get { return maddh; } set { maddh = value; } }
        public int Manl { get {  return manl; } set {  manl = value; } }
        public int Soluong { get {  return soluong; } set {  soluong = value; } }

        public int Maqc { get { return maqc; } set { maqc = value; } }

    }
}
