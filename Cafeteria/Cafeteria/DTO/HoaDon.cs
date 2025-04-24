using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class HoaDon
    {
        public int maHD { get; set; }
        public DateTime ngayTao { get; set; }
        public int idNguoiTao { get; set; }
        public string phuongThuc { get; set; }
        public string ghiChu { get; set; }
        public int tongHD { get; set; }

        public HoaDon() { }

        public HoaDon(int maHD, DateTime ngayTao, int idNguoiTao, string phuongThuc, string ghiChu, int tongHD)
        {
            this.maHD = maHD;
            this.ngayTao = ngayTao;
            this.idNguoiTao = idNguoiTao;
            this.phuongThuc = phuongThuc;
            this.ghiChu = ghiChu;
            this.tongHD = tongHD;
        }
        public HoaDon(DateTime ngayTao, int idNguoiTao, string phuongThuc, string ghiChu, int tongHD)
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
        public int TongHD { get => tongHD; set => tongHD = value; }
    }
}
