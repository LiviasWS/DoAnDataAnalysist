using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class NLTrongKho
    {
        private NguyenLieu nguyenLieu;
        private int soLuong;
        private QuyCach quyCach;
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }
        public NLTrongKho() { }
        public NLTrongKho(NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
    }
}
