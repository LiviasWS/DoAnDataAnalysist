using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    class DonHang
    {
        private int maDonHang;
        private int ban;
        private DateTime ngayTao;
        private int idNguoiTao;
        private String ghiChu;
        private String trangThai;

        public DonHang(int maDonHang, int ban, DateTime ngayTao, int idNguoiTao, string ghiChu, string trangThai)
        {
            this.maDonHang = maDonHang;
            this.ban = ban;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
        }
        public DonHang(int ban, DateTime ngayTao, int idNguoiTao, string ghiChu, string trangThai)
        {
            this.ban = ban;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
        }

        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public int Ban { get => ban; set => ban = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
