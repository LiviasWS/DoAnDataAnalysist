using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class HoaDonDAO
    {
        DBConnection conn = new DBConnection();
        public HoaDonDAO() { }

        public List<HoaDon> getAllHoaDon()
        {
            List<HoaDon> hoaDons = new List<HoaDon>();
            string sqlCommand = "SELECT * FROM HOADON";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.maHD = Convert.ToInt32(row["maHD"]);
                hoaDon.ngayTao = Convert.ToDateTime(row["ngayTao"]);
                hoaDon.idNguoiTao = Convert.ToInt32(row["idNguoiTao"]);
                hoaDon.phuongThuc = row["phuongThuc"].ToString();
                hoaDon.ghiChu = row["ghiChu"].ToString();
                hoaDon.tongHD = Convert.ToInt32(row["tongHD"]);
                hoaDons.Add(hoaDon);
            }
            return hoaDons;
        }

    }
}
