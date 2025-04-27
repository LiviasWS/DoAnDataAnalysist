using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class DonYeuCauDatHang
    {
        private int maDonYeuCau;
        private DateTime ngayTao;
        private int idNguoiTao;
        private string ghiChu;
        private DateTime ngayDuKienHetHang;
        public int MaDonYeuCau { get => maDonYeuCau; set => maDonYeuCau = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgayDuKienHetHang { get => ngayDuKienHetHang; set => ngayDuKienHetHang = value; }
        public DonYeuCauDatHang(int maDonYeuCau, DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayDuKienHetHang)
        {
            this.maDonYeuCau = maDonYeuCau;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayDuKienHetHang = ngayDuKienHetHang;
        }
        public DonYeuCauDatHang(DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayDuKienHetHang)
        {
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayDuKienHetHang = ngayDuKienHetHang;
        }
        public DonYeuCauDatHang() { }
    }
}
