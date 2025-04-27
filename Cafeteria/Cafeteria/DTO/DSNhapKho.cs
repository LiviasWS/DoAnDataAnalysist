using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class DSNhapKho
    {
        private NguyenLieu nguyenLieu;
        private int soLuong;
        private QuyCach quyCach;
        private DonNhapKho donNhapKho;
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }
        public DonNhapKho DonNhapKho { get => donNhapKho; set => donNhapKho = value; }
        public DSNhapKho(DonNhapKho donNhapKho, NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.donNhapKho = donNhapKho;
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
        public DSNhapKho() { }
    }
}
