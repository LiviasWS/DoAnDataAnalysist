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
        public ChiTietDonDatHang() { }

        public int Maddh { get { return maddh; } set { maddh = value; } }
        public int Manl { get {  return manl; } set {  manl = value; } }
        public int Soluong { get {  return soluong; } set {  soluong = value; } }

    }
}
