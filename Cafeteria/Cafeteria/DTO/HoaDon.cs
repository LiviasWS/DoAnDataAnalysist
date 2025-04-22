using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class HoaDon
    {
        private int maHD;
        private DateTime ngayTao;
        private int idNguoiTao;
        private String phuongThuc;
        private String ghiChu;
        private double tongHD;

        public HoaDon(int maHD, DateTime ngayTao, int idNguoiTao, string phuongThuc, string ghiChu, double tongHD)
        {
            this.maHD = maHD;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.phuongThuc = phuongThuc;
            this.ghiChu = ghiChu;
            this.tongHD = tongHD;
        }
        public HoaDon(DateTime ngayTao, int idNguoiTao, string phuongThuc, string ghiChu, double tongHD)
        {
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.phuongThuc = phuongThuc;
            this.ghiChu = ghiChu;
            this.tongHD = tongHD;
        }

        public int MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }
        public string PhuongThuc { get => phuongThuc; set => phuongThuc = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public double TongHD { get => tongHD; set => tongHD = value; }
    }
}
