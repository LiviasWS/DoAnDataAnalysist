using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class NLTrongKho
    {
        private int maNL;
        private int soLuong;
        private int maQC;
        public NLTrongKho() { }
        public int MaNL { get { return maNL; } set {  maNL = value; } }
        public int SoLuong { get {  return soLuong; } set {  soLuong = value; } }
        public int MaQC { get { return maQC; } set { maQC = value; } }
    }
}
