using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class SanPhamDAO
    {
        DBConnection dBConn = new DBConnection();
        public DataTable getMenu(string key="")
        {
            string query = String.Format("select * from SanPham where tenSP like '%{0}%'", key);
            DataTable dt = dBConn.Load(query);
            return dt;
        }
    }
}
