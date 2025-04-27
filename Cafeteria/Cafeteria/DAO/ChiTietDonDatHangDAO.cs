using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class ChiTietDonDatHangDAO
    {
        DBConnection conn = new DBConnection();
        public ChiTietDonDatHangDAO() { }
        public void Add_ChiTietDonDatHang(ChiTietDonDatHang chiTiet)
        {
            string sqlCommand = "INSERT INTO CHITIETDONDATHANG(MADDH, MANL, SOLUONG)" +
                "VALUES(" + chiTiet.Maddh + ", " + chiTiet.Manl + ", " + chiTiet.Soluong + ")";
            conn.Execute(sqlCommand);
        }



    }
}
