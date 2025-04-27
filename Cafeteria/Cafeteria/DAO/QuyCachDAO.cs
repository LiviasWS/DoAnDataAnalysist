using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class QuyCachDAO
    {
        DBConnection conn = new DBConnection();
        public QuyCachDAO() { }

        public List<String> getAllTenQC()
        {
            string sqlCommand = "SELECT DISTINCT TENQC FROM QUYCACH;";
            List<String> list = new List<String>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row["TENQC"].ToString());
            }
            return list;
        }

        public List<QuyCach> getAllQuyCach()
        {
            string sqlCommand = "SELECT * FROM QUYCACH;";
            List<QuyCach> quyCachs = new List<QuyCach>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach(DataRow row in dataTable.Rows)
            {
                QuyCach quyCach = new QuyCach();
                quyCach.MaQC = Convert.ToInt32(row["MaQC"]);
                quyCach.TenQC = row["TenQC"].ToString();
                quyCachs.Add(quyCach);
            }
            return quyCachs;
        }

        public QuyCach GetQuyCachByID(int maQC)
        {
            string sqlCommand = "SELECT * FROM QUYCACH WHERE MaQC = " + maQC + ";";
            QuyCach quyCach = new QuyCach();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows) 
            {
                quyCach.MaQC = maQC;
                quyCach.TenQC = row["tenQC"].ToString();
            }
            return quyCach;
        }

        public QuyCach GetQuyCachByName(string name)
        {
            string sqlCommand = "SELECT * FROM QUYCACH WHERE TENQC = '" + name + "';";
            QuyCach quyCach = new QuyCach();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                quyCach.MaQC = Convert.ToInt32(row["MaQC"]);
                quyCach.TenQC = name;
            }
            return quyCach;
        }

    }
}
