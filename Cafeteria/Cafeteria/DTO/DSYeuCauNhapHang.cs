using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class DSYeuCauNhapHang
    {
        DonYeuCauNhapHang donYeuCauDatHang;
        NguyenLieu nguyenLieu;
        int soLuong;
        QuyCach quyCach;
        public DSYeuCauNhapHang(DonYeuCauNhapHang donYeuCauDatHang,NguyenLieu nguyenLieu, int soLuong, QuyCach quyCach)
        {
            this.donYeuCauDatHang = donYeuCauDatHang;
            this.nguyenLieu = nguyenLieu;
            this.soLuong = soLuong;
            this.quyCach = quyCach;
        }
        public DSYeuCauNhapHang() { }
        public NguyenLieu NguyenLieu { get => nguyenLieu; set => nguyenLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public QuyCach QuyCach { get => quyCach; set => quyCach = value; }
        public DonYeuCauNhapHang DonYeuCauDatHang { get => donYeuCauDatHang; set => donYeuCauDatHang = value; }
    }
}
