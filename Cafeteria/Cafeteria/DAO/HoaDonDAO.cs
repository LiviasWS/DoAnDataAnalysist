using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class HoaDonDAO
    class HoaDonDAO
    {
        DBConnection conn = new DBConnection();
        public HoaDonDAO() { }

        public List<HoaDon> getAllHoaDon()
        DBConnection dBConn = new DBConnection();
        public void add(HoaDon item)
        {
            List<HoaDon> hoaDons = new List<HoaDon>();
            string sqlCommand = "SELECT * FROM HOADON";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            string time = item.NgayTao.ToString("yyyy-MM-dd HH:mm:ss");
            string query = string.Format("insert into HoaDon(ngayTao,idNguoitao, phuongThuc, ghiChu, tongHD) values ('{0}','{1}','{2}','{3}','{4}')", time, item.IdNguoiTao, item.PhuongThuc, item.GhiChu, item.TongHD);
            dBConn.Execute(query);
        }
        public int getMaxId()
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.maHD = Convert.ToInt32(row["maHD"]);
                hoaDon.ngayTao = Convert.ToDateTime(row["ngayTao"]);
                hoaDon.idNguoiTao = Convert.ToInt32(row["idNguoiTao"]);
                hoaDon.phuongThuc = row["phuongThuc"].ToString();
                hoaDon.ghiChu = row["ghiChu"].ToString();
                hoaDon.tongHD = Convert.ToInt32(row["tongHD"]);
                hoaDons.Add(hoaDon);
            string query = string.Format("SELECT max(maHD) from HoaDon");
            object ob = dBConn.GetScalar(query);
            return int.Parse(ob.ToString());
            }
            return hoaDons;
        public void UpdateNote(HoaDon item)
        {
            string query = string.Format("update HoaDon set ghiChu = '{0}' where maHD='{1}'",item.GhiChu, item.MaHD);
            dBConn.Execute(query);
        }

    }
}
