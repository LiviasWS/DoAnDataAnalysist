using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class DonDatHangDAO
    {
        DBConnection conn = new DBConnection();
        public DonDatHangDAO() { }
        public void AddDonDatHang(int maNCC, DateTime ngayTao, int tongGiaTri, DateTime ngayGiao, string ghiChu)
        {
            string sqlCommand = "INSERT INTO DONDATHANG(MANCC, NGAYTAO, NGAYGIAO, TONGGIATRI, GHICHU)"
                + "VALUES(" + maNCC + ", '" + ngayTao + "', '" + ngayGiao + "', "
                + tongGiaTri + ", '" + ghiChu + "'";
            conn.Execute(sqlCommand);
        }

        public int GetIDDonDatHang()
        {
            string sqlCommand = "SELECT MAX(MADONDATHANG) as MAX_ID FROM DONDATHANG";
            int id = 0;
            DataTable dataTable = conn.Load(sqlCommand);
            foreach(DataRow dr in dataTable.Rows) 
            {
                id = Convert.ToInt32(dr["MADONDATHANG"]);
            }
            return id;
        }
        public DataTable GetAllDonDatHang()
        {
            string sqlCommand = "SELECT * FROM DONDATHANG";
            return conn.Load(sqlCommand);
        }

    }
}
