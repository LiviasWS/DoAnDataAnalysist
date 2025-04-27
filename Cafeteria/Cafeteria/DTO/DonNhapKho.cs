using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class DonNhapKho
    {
        private int maDonNhapKho;
        private DateTime ngayTao;
        private int nguoiTao;
        private string ghiChu;
        private DateTime ngayNhapKho;
        private int tongGiaTri;
        private int maDonDatHang;
        public int MaDonNhapKho { get => maDonNhapKho; set => maDonNhapKho = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int NguoiTao { get => nguoiTao; set => nguoiTao = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgayNhapKho { get => ngayNhapKho; set => ngayNhapKho = value; }
        public int TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
        public int MaDonDatHang { get => maDonDatHang; set => maDonDatHang = value; }
        public DonNhapKho(int maDonNhapKho, DateTime ngayTao, int nguoiTao, string ghiChu, DateTime ngayNhapKho, int tongGiaTri)
        {
            this.maDonNhapKho = maDonNhapKho;
            this.ngayTao = ngayTao;
            this.nguoiTao = nguoiTao;
            this.ghiChu = ghiChu;
            this.ngayNhapKho = ngayNhapKho;
            this.tongGiaTri = tongGiaTri;
        }
        public DonNhapKho(DateTime ngayTao, int nguoiTao, string ghiChu, DateTime ngayNhapKho, int tongGiaTri)
        {
            this.ngayTao = ngayTao;
            this.nguoiTao = nguoiTao;
            this.ghiChu = ghiChu;
            this.ngayNhapKho = ngayNhapKho;
            this.tongGiaTri = tongGiaTri;
        }
        public DonNhapKho() { }
    }
}
