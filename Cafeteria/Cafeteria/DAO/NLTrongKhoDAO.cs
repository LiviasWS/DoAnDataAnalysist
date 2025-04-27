using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class NLTrongKhoDAO
    {
        private DBConnection conn = new DBConnection();
        public NLTrongKhoDAO() { }

        public NLTrongKho GetNLTrongKho(int maNL, int maQC)
        {
            string sqlString = "SELECT * FROM NLTRONGKHO WHERE MANL = " + maNL + " AND MAQC = " + maQC;
            NLTrongKho nlTrongKho = new NLTrongKho();
            DataTable dataTable = conn.Load(sqlString);
            foreach(DataRow row in dataTable.Rows)
            {
                nlTrongKho.MaNL = Convert.ToInt32(row["MaNL"]);
                nlTrongKho.SoLuong = Convert.ToInt32(row["SoLuong"]);
                nlTrongKho.MaQC = Convert.ToInt32(row["MaQC"]);
            }
            return nlTrongKho;
        }

        public List<NLTrongKho> getAllNLTrongKho()
        {
            string sqlCommand = "SELECT * FROM NLTrongKho;";
            List<NLTrongKho> nLTrongKhos = new List<NLTrongKho>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach(DataRow row in dataTable.Rows) 
            {
                NLTrongKho nLTrongKho = new NLTrongKho();
                nLTrongKho.MaNL = Convert.ToInt32(row["MaNL"]);
                nLTrongKho.SoLuong = Convert.ToInt32(row["SoLuong"]);
                nLTrongKho.MaQC = Convert.ToInt32(row["MaQC"]);
                nLTrongKhos.Add(nLTrongKho);
            }
            return nLTrongKhos;
        }

    }
}
