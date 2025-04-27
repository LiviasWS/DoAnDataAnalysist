using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class NguyenLieuDAO
    {

        DBConnection conn = new DBConnection();

        public NguyenLieuDAO() { }

        public List<NguyenLieu> getAllNguyenLieu()
        {
            List<NguyenLieu> nguyenLieus = new List<NguyenLieu>();
            string sqlCommand = "SELECT * FROM NGUYENLIEU";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                NguyenLieu nguyenLieu = new NguyenLieu();
                nguyenLieu.MaNL = Convert.ToInt32(row["maNL"]);
                nguyenLieu.TenNL = row["tenNL"].ToString();
                nguyenLieus.Add(nguyenLieu);
            }
            return nguyenLieus;
        }

        public NguyenLieu GetNguyenLieuById(int id)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            string sqlString = "SELECT * FROM NGUYENLIEU WHERE MANL = " + id + ";";
            DataTable dataTable = conn.Load(sqlString);
            foreach(DataRow row in dataTable.Rows)
            {
                nguyenLieu.MaNL = id;
                nguyenLieu.TenNL = row["tenNL"].ToString();
            }
            return nguyenLieu;
        }

        public NguyenLieu GetNguyenLieuByName(string name)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            string sqlString = "SELECT * FROM NGUYENLIEU WHERE TENNL = '" + name + "';";
            DataTable dataTable = conn.Load(sqlString);
            foreach (DataRow row in dataTable.Rows)
            {
                nguyenLieu.MaNL = Convert.ToInt32(row["MaNL"]);
                nguyenLieu.TenNL = name;
            }
            return nguyenLieu;
        }

    }
}
