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
        private NguyenLieu nguyenLieu;
        private int maNL;
        private int soLuong;
        private QuyCach quyCach;
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }

        private int maQC;
        public NLTrongKho() { }
        public NLTrongKho(NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
        public int MaNL { get { return maNL; } set {  maNL = value; } }
        public int MaQC { get { return maQC; } set { maQC = value; } }
    }
}
