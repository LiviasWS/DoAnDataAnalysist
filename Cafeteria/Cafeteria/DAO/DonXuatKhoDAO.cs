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
            string query = string.Format("INSERT INTO DonXuatKho (NgayTao, NguoiTao, GhiChu, NgayXuatKho, trangthai) " +
                "VALUES ('{0}', 2, N'{1}', '{2}', 0)",
                donXuatKho.NgayTao.ToString("MM/dd/yyyy"), donXuatKho.GhiChu, donXuatKho.NgayXuatKho.ToString("MM/dd/yyyy"));
            db.Execute(query);
        }
        public int AddDonXuatKhoGetId(DonXuatKho donXuatKho)
        {
            string query = string.Format("INSERT INTO DonXuatKho (NgayTao, NguoiTao, GhiChu, NgayXuatKho, trangthai) " +
                "VALUES ('{0}', 2, N'{1}', '{2}', 0) select SCOPE_IDENTITY()",
                donXuatKho.NgayTao.ToString("MM/dd/yyyy"), donXuatKho.GhiChu, donXuatKho.NgayXuatKho.ToString("MM/dd/yyyy"));
            int id = db.ExecuteScalar(query);
            return id;
        }
        public void EditDonXuatKho(DonXuatKho donXuatKho)
        {
            string query = string.Format("UPDATE DonXuatKho SET trangthai = {0} WHERE MaDonXuatKho = {1}",
                donXuatKho.TrangThai == true ? 1 : 0, donXuatKho.MaDonXuatKho);
            db.Execute(query);
        }
        public DonXuatKho FindById(int id)
        {
            string query = string.Format("SELECT * FROM DonXuatKho WHERE MaDonXuatKho = {0}", id);
            DataTable dt = db.Load(query);
            if (dt.Rows.Count > 0)
            {
                DonXuatKho donXuatKho = new DonXuatKho();
                donXuatKho.MaDonXuatKho = (int)dt.Rows[0][0];
                donXuatKho.NgayTao = (DateTime)dt.Rows[0][1];
                donXuatKho.IdNguoiTao = (int)dt.Rows[0][2];
                donXuatKho.GhiChu = dt.Rows[0][3].ToString();
                donXuatKho.NgayXuatKho = (DateTime)dt.Rows[0][4];
                donXuatKho.TrangThai = (bool)dt.Rows[0][5];
                return donXuatKho;
            }
            return null;
        }
        public DataTable GetAllDonXuatKho()
        {
            string query = "SELECT * FROM DonXuatKho";
            return db.Load(query);
        }
    }
}
