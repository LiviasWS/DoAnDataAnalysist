using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria.DAO
{
    public class NhaCungCapDAO
    {
        DBConnection conn = new DBConnection();
        public NhaCungCapDAO() { }

        public NhaCungCap GetNhaCungCapByName(string tenncc)
        {
            string sqlCommand = "SELECT * FROM NHACUNGCAP WHERE TENNCC = '" + tenncc + "'";
            NhaCungCap nhaCungCap = new NhaCungCap();
            DataTable dataTable = conn.Load(sqlCommand);
            MessageBox.Show(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                nhaCungCap.MaNCC = Convert.ToInt32(row["MaNCC"]);
                nhaCungCap.TenNCC = row["TenNCC"].ToString();
                nhaCungCap.Sdt = row["SDT"].ToString();
                nhaCungCap.DiaChi = row["DiaChi"].ToString();
                nhaCungCap.MoTa = row["Mota"].ToString();
            }
            return nhaCungCap;
        }

        public void AddNhaCungCap(string tencc, string sdt, string diaChi, string moTa)
        {
            string sqlCommand = "INSERT INTO NHACUNGCAP(TENNCC, SDT, DIACHI, MOTA) VALUES ('"
                + tencc + "', '" + sdt + "', '" + diaChi + "'," + "'" + moTa + "')";
            conn.Load(sqlCommand);
        }
        public void DeleteNhaCungCap(int mancc)
        {
            string sqlCommand = "DELETE FROM NHACUNGCAP WHERE MANCC = " + mancc;
            conn.Load(sqlCommand);
        }
        public List<NhaCungCap> getAllNhaCungCaps()
        {
            string sqlCommand = "SELECT * FROM NHACUNGCAP";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows) 
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.MaNCC = Convert.ToInt32(row["MaNCC"]);
                nhaCungCap.TenNCC = row["TenNCC"].ToString();
                nhaCungCap.Sdt = row["SDT"].ToString();
                nhaCungCap.DiaChi = row["DiaChi"].ToString();
                nhaCungCap.MoTa = row["Mota"].ToString();
                nhaCungCaps.Add(nhaCungCap);
            }
            return nhaCungCaps;
        }
    }
}
