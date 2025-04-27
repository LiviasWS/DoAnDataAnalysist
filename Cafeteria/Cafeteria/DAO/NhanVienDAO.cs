using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class NhanVienDAO
    {

        DBConnection conn = new DBConnection();

        public NhanVienDAO() 
        {
            
        }

        public NhanVien getNhanVienByID(int id)
        {
            string sqlString = "SELECT * FROM NHANVIEN WHERE ID = " + id + ";";
            DataTable dataTable = conn.Load(sqlString);
            NhanVien nhanVien = new NhanVien();
            foreach (DataRow row in dataTable.Rows) 
            {
                nhanVien.maNV = Convert.ToInt32(row["id"]);
                nhanVien.hoTen = row["hoTen"].ToString();
                nhanVien.sdt = row["sdt"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();
                nhanVien.ngaySinh = Convert.ToDateTime(row["ngaySinh"]);
                nhanVien.role = row["role"].ToString();
                nhanVien.userName = row["username"].ToString();
                nhanVien.password = row["password"].ToString();
            }
            return nhanVien;
        }

    }
}
