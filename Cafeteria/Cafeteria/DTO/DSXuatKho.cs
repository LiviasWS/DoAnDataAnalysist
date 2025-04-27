using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class DSXuatKho
    {
        private NguyenLieu nguyenLieu;
        private int soLuong;
        private QuyCach quyCach;
        private DonXuatKho donXuatKho;
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }
        public DonXuatKho DonXuatKho { get => donXuatKho; set => donXuatKho = value; }
        public DSXuatKho(DonXuatKho donXuatKho, NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.donXuatKho = donXuatKho;
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
        public DSXuatKho() { }
    }
}
