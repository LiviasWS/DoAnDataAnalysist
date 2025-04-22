using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    class HoaDonDonHangDAO
    {
        DBConnection dBConn = new DBConnection();
        public void add(HoaDonDonHang item)
        {
            string query = string.Format("insert into HoaDon_DonHang(maHD, maDonHang) values ('{0}','{1}')", item.MaHD, item.MaDonHang);
            dBConn.Execute(query);
        }
    }
}
