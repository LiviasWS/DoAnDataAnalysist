using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class DonYeuCauNhapHang
    {
        private int maDonYeuCau;
        private DateTime ngayTao;
        private int nguoiTao;
        private string ghiChu;
        private DateTime ngayDuKienHetHang;

        public DonYeuCauNhapHang() { }

        public int MaDonYeuCau { get {  return maDonYeuCau; } set {  maDonYeuCau = value; } }
        public DateTime NgayTao { get {  return ngayTao; } set {  ngayTao = value; } }
        public int NguoiTao { get { return nguoiTao; } set {  nguoiTao = value; } }
        public string GhiChu { get {  return ghiChu; } set {  ghiChu = value; } }
        public DateTime NgayDuKienHetHang { get { return ngayDuKienHetHang; } set { ngayDuKienHetHang = value; } }
        public DonYeuCauNhapHang(int maDonYeuCau, DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayDuKienHetHang)
        {
            this.maDonYeuCau = maDonYeuCau;
            this.ngayTao = ngayTao;
            this.NguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayDuKienHetHang = ngayDuKienHetHang;
        }
        public DonYeuCauNhapHang(DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayDuKienHetHang)
        {
            this.ngayTao = ngayTao;
            this.NguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayDuKienHetHang = ngayDuKienHetHang;
        }
    }
}
