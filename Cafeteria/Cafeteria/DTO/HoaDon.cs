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

        public HoaDon()
        {

        }

    }
}
