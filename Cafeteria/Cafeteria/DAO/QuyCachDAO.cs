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
        DBConnection db = new DBConnection();
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
        public void AddQuyCach(QuyCach quyCach)
        {
            string query = string.Format("INSERT INTO QuyCach (TenQC) VALUES ('{0}')", quyCach.TenQC);
            db.Execute(query);
        }
        public int AddQuyCachGetId(QuyCach quyCach)
        {
            string query = string.Format("INSERT INTO QuyCach (TenQC) VALUES ('{0}') select SCOPE_IDENTITY()", quyCach.TenQC);
            int id = db.ExecuteScalar(query);
            return id;
        }
        public DataTable GetAllQuyCach()
        {
            string query = "SELECT * FROM QuyCach";
            return db.Load(query);
        }
        public QuyCach FindByName(string name)
        {
            string query = string.Format("SELECT * FROM QuyCach WHERE TenQC = '{0}'", name);
            DataTable dt = db.Load(query);
            QuyCach quyCach = new QuyCach();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    quyCach.MaQC = (int)item[0];
                    quyCach.TenQC = item[1].ToString();
                }
                return quyCach;
            }
            return null;
        }
        public QuyCach FindById(int id)
        {
            string query = string.Format("SELECT * FROM QuyCach WHERE MaQC = {0}", id);
            DataTable dt = db.Load(query);
            QuyCach quyCach = new QuyCach();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    quyCach.MaQC = (int)item[0];
                    quyCach.TenQC = item[1].ToString();
                }
                return quyCach;
            }
            return null;
        }
        public int GetCount()
        {
            string query = "SELECT Count(*) FROM QuyCach";
            DataTable dt = db.Load(query);
            return (int)dt.Rows[0][0];
        }

    }
}
