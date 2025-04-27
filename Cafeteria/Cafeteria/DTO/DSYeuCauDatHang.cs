using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class DSYeuCauDatHang
    {
        DonYeuCauDatHang donYeuCauDatHang;
        NguyenLieu nguyenLieu;
        int soLuong;
        QuyCach quyCach;
        public DSYeuCauDatHang(DonYeuCauDatHang donYeuCauDatHang,NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.donYeuCauDatHang = donYeuCauDatHang;
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
        public DSYeuCauDatHang() { }
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }
        public DonYeuCauDatHang DonYeuCauDatHang { get => donYeuCauDatHang; set => donYeuCauDatHang = value; }
    }
}
