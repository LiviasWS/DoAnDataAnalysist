using Cafeteria.DTO;
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
        DBConnection conn = new DBConnection();
        public SanPhamDAO() { }

        public List<string> getAllLoaiSP()
        {
            List<string> result = new List<string>();
            string sqlCommand = "SELECT DISTINCT LOAISP FROM SANPHAM";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                result.Add(row["loaiSP"].ToString());
            }    
            return result;
        }

        public List<SanPham> getAllSanPham() 
        {
            List<SanPham> sanPhams = new List<SanPham>();
            string sqlCommand = "SELECT * FROM SANPHAM";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanpham = new SanPham();
                sanpham.maSP = Convert.ToInt32(row["maSP"]); 
                sanpham.tenSP = row["tenSP"].ToString();
                sanpham.giaTien = Convert.ToInt32(row["giaTien"]);
                sanpham.loaiSP = row["loaiSP"].ToString();
                sanPhams.Add(sanpham);
            }
            return sanPhams;
        }

        public SanPham getSanPhamFromID(int ID)
        {
            SanPham sanPham = new SanPham();
            string sqlCommand = "SELECT * FROM SANPHAM WHERE MASP = " + ID + ";";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                sanPham.maSP = Convert.ToInt32(row["maSP"]);
                sanPham.tenSP = row["tenSP"].ToString();
                sanPham.giaTien = Convert.ToInt32(row["giaTien"]);
                sanPham.loaiSP = row["loaiSP"].ToString();
            }
            return sanPham;
        }

    }
}
