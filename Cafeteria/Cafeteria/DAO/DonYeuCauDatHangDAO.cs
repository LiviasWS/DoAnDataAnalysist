using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class DonYeuCauDatHangDAO
    {
        private DBConnection conn = new DBConnection();
        public DonYeuCauDatHangDAO() { }

        public List<DonYeuCauNhapHang> GetAllDonYeuCauNhapHang()
        {
            string sqlString = "SELECT * FROM DONYEUCAUNHAPHANG";
            DataTable dataTable = conn.Load(sqlString);
            List<DonYeuCauNhapHang> donYeuCauNhapHangs = new List<DonYeuCauNhapHang>();
            foreach (DataRow row in dataTable.Rows) 
            {
                DonYeuCauNhapHang donYeuCauNhapHang = new DonYeuCauNhapHang();
                donYeuCauNhapHang.MaDonYeuCau = Convert.ToInt32(row["MaDonYeuCau"]);
                donYeuCauNhapHang.NgayTao = Convert.ToDateTime(row["NgayTao"]);
                donYeuCauNhapHang.NguoiTao = Convert.ToInt32(row["NguoiTao"]);
                donYeuCauNhapHang.GhiChu = row["ghiChu"].ToString();
                donYeuCauNhapHang.NgayDuKienHetHang = Convert.ToDateTime(row["NgayDuKienHetHang"]);
                donYeuCauNhapHangs.Add(donYeuCauNhapHang);
            }
            return donYeuCauNhapHangs;
        }

    }
}
