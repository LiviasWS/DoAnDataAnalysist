using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DonNhapKhoDAO
    {
        DBConnection db = new DBConnection();
        public void AddDonNhapKho(DonNhapKho donNhapKho)
        {
            string query = string.Format("INSERT INTO DonNhapKho (NgayTao, NguoiTao, GhiChu, NgayNhapKho, GiaTriDonNhap) VALUES ('{0}', 2,N'{1}','{2}',{3})",
                donNhapKho.NgayTao.ToString("MM/dd/yyyy"), donNhapKho.GhiChu, donNhapKho.NgayNhapKho.ToString("MM/dd/yyyy"), donNhapKho.TongGiaTri);
            db.Execute(query);
        }
        public int AddDonNhapKhoGetId(DonNhapKho donNhapKho)
        {
            string query = string.Format("INSERT INTO DonNhapKho (NgayTao, NguoiTao, GhiChu, NgayNhapKho, GiaTriDonNhap) VALUES ('{0}', 2,N'{1}','{2}',{3}) select SCOPE_IDENTITY()",
                donNhapKho.NgayTao.ToString("MM/dd/yyyy"), donNhapKho.GhiChu, donNhapKho.NgayNhapKho.ToString("MM/dd/yyyy"), donNhapKho.TongGiaTri);
            int id = db.ExecuteScalar(query);
            return id;
        }
        public void EditDonNhapKho(DonNhapKho donNhapKho)
        {
            string query = string.Format("UPDATE DonNhapKho SET GiaTriDonNhap = {0} WHERE MaDonNhapKho = {1}",
                donNhapKho.TongGiaTri, donNhapKho.MaDonNhapKho);
            db.Execute(query);
        }
        public DataTable GetAllDonNhapKho()
        {
            string query = "SELECT * FROM DonNhapKho";
            return db.Load(query);
        }
    }
}
