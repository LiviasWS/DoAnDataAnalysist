
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DonYeuCauNhapHangDAO
    {
        DBConnection db = new DBConnection();
        public void AddDonYeuCauDatHang(DonYeuCauNhapHang donYeuCau)
        {
            string query = string.Format("INSERT INTO DonYeuCauNhapHang (NgayTao, NguoiTao, GhiChu, NgayDuKienHetHang) " +
                "VALUES ('{0}', {1}, N'{2}', '{3}')",donYeuCau.NgayTao, donYeuCau.IdNguoiTao, donYeuCau.GhiChu,donYeuCau.NgayDuKienHetHang);
            db.Execute(query);
        }
        public int AddDonYeuCauDatHangGetId(DonYeuCauNhapHang donYeuCau)
        {
            string query = string.Format("INSERT INTO DonYeuCauNhapHang (NgayTao, NguoiTao, GhiChu, NgayDuKienHetHang) " +
               "VALUES ('{0}', 2, N'{1}', '{2}') select SCOPE_IDENTITY()",
               donYeuCau.NgayTao.ToString("MM/dd/yyyy"), donYeuCau.GhiChu, donYeuCau.NgayDuKienHetHang.ToString("MM/dd/yyyy"));
            int id = db.ExecuteScalar(query);
            return id;
        }
        public DataTable GetAllDonYeuCauDatHang()
        {
            string query = "SELECT * FROM DonYeuCauNhapHang";
            return db.Load(query);
        }
    }
}
