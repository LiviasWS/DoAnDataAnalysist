using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    class ChiTietDonHangDAO
    {
        public void add(ChiTietDonHang item)
        {
            string query = string.Format("insert into ChiTietDonHang(maDonHang,maSP,soLuong) values ('{0}','{1}','{2}')", item.MaDonHang, item.MaSP, item.SoLuong);
            DBConnection dBConnection = new DBConnection();
            dBConnection.Execute(query);
        }
    }
}
