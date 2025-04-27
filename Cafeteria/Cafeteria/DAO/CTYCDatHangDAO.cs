using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class CTYCDatHangDAO
    {
        private DBConnection conn = new DBConnection();
        public CTYCDatHangDAO() { }

        public void UpdateTrangThai(int maDon, int manl)
        {
            string sqlCommand = "UPDATE CHITIETDONYCNHAPHANG SET TRANGTHAI = 'COMPLETE' "
                +"WHERE MADONDATHANG = " + maDon + "AND MANL = " + manl;
            conn.Execute(sqlCommand);
        }

        public List<CTYCDatHang> GetAllChuaDat()
        {
            string sqlCommand = "SELECT * FROM CHITIETDONYCNHAPHANG WHERE TRANGTHAI IS NULL";
            List<CTYCDatHang> list = new List<CTYCDatHang>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows)
            {
                CTYCDatHang ct = new CTYCDatHang();
                ct.MaDonYeuCau = Convert.ToInt32(row["MADONYEUCAU"]);
                ct.MaNL = Convert.ToInt32(row["MANL"]);
                ct.SoLuong = Convert.ToInt32(row["soLuong"]);
                ct.MaQC = Convert.ToInt32(row["maqc"]);
                ct.TrangThai = row["trangthai"].ToString();
                list.Add(ct);
            }
            return list;
        }
        public List<CTYCDatHang> GetAll()
        {
            string sqlCommand = "SELECT * FROM CHITIETDONYCNHAPHANG";
            List<CTYCDatHang> list = new List<CTYCDatHang>();
            DataTable dataTable = conn.Load(sqlCommand);
            foreach (DataRow row in dataTable.Rows) 
            {
                CTYCDatHang ct = new CTYCDatHang();
                ct.MaDonYeuCau = Convert.ToInt32(row["MADONYEUCAU"]);
                ct.MaNL = Convert.ToInt32(row["MANL"]);
                ct.SoLuong = Convert.ToInt32(row["soLuong"]);
                ct.MaQC = Convert.ToInt32(row["maqc"]);
                ct.TrangThai = row["trangthai"].ToString();
                list.Add(ct);
            }
            return list;
        }
    }
}
