using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DSNhapKhoDAO
    {
        DBConnection db = new DBConnection();
        public void AddDSNhapKho(DSNhapKho dsNhapKho)
        {
            string query = string.Format("INSERT INTO ChiTietDonNhapKho (MaDonNhapKho, MaNL, SoLuong, MaQC) VALUES ({0}, {1}, {2}, {3})",
                dsNhapKho.DonNhapKho.MaDonNhapKho, dsNhapKho.NguyenLieu.MaNL, dsNhapKho.SoLuong, dsNhapKho.QuyCach.MaQC);
            db.Execute(query);
        }
        public DataTable GetDSNhapKhoByDon(int id)
        {
            string query = string.Format("select * from v_ChiTietDonNhapKho where MaDonNhapKho = {0}", id);
            return db.Load(query);
        }
    }
}
