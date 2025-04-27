using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class DonXuatKho
    {
        private int maDonXuatKho;
        private DateTime ngayTao;
        private int idNguoiTao;
        private string ghiChu;
        private DateTime ngayXuatKho;
        private bool trangThai;
        public int MaDonXuatKho { get => maDonXuatKho; set => maDonXuatKho = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgayXuatKho { get => ngayXuatKho; set => ngayXuatKho = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public DonXuatKho(int maDonXuatKho, DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayXuatKho)
        {
            this.maDonXuatKho = maDonXuatKho;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayXuatKho = ngayXuatKho;
        }
        public DonXuatKho(DateTime ngayTao, int idNguoiTao, string ghiChu, DateTime ngayXuatKho)
        {
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.ghiChu = ghiChu;
            this.ngayXuatKho = ngayXuatKho;
        }
        public DonXuatKho() { }
    }
}
