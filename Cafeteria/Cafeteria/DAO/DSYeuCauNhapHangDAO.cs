using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DSYeuCauNhapHangDAO
    {
        DBConnection db = new DBConnection();
        public void AddDSYeuCauDatHang(DSYeuCauNhapHang dsYeuCau)
        {
            string query = string.Format("INSERT INTO ChiTietDonYCNhapHang (MaDonYeuCau, MaNL, SoLuong, MaQC) VALUES ({0}, {1}, {2}, {3})", 
                dsYeuCau.DonYeuCauDatHang.MaDonYeuCau, dsYeuCau.NguyenLieu.MaNL, dsYeuCau.SoLuong, dsYeuCau.QuyCach.MaQC);
            db.Execute(query);
        }
        public DataTable GetDSYeuCauDatHangByDon(int id)
        {
            string query = string.Format("select * from v_ChiTietDonYeuCau where MaDonYeuCau = {0}", id);
            return db.Load(query);
        }
    }
}
