using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DonXuatKhoDAO
    {
        DBConnection db = new DBConnection();
        public void AddDonXuatKho(DonXuatKho donXuatKho)
        {
            string query = string.Format("INSERT INTO DonXuatKho (NgayTao, NguoiTao, GhiChu, NgayXuatKho) " +
                "VALUES ('{0}', 2, N'{1}', '{2}')",
                donXuatKho.NgayTao.ToString("MM/dd/yyyy"), donXuatKho.GhiChu, donXuatKho.NgayXuatKho.ToString("MM/dd/yyyy"));
            db.Execute(query);
        }
        public int AddDonXuatKhoGetId(DonXuatKho donXuatKho)
        {
            string query = string.Format("INSERT INTO DonXuatKho (NgayTao, NguoiTao, GhiChu, NgayXuatKho) " +
                "VALUES ('{0}', 2, N'{1}', '{2}') select SCOPE_IDENTITY()",
                donXuatKho.NgayTao.ToString("MM/dd/yyyy"), donXuatKho.GhiChu, donXuatKho.NgayXuatKho.ToString("MM/dd/yyyy"));
            int id = db.ExecuteScalar(query);
            return id;
        }
        public DataTable GetAllDonXuatKho()
        {
            string query = "SELECT * FROM DonXuatKho";
            return db.Load(query);
        }
    }
}
