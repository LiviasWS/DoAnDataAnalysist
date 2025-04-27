using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetChiTietDonDatHangByDon(int id)
        {
            string sqlCommand = string.Format("select * from v_ChiTietDonDatHang where maDonDatHang = {0}", id);
            return conn.Load(sqlCommand);
        }

    }
}
