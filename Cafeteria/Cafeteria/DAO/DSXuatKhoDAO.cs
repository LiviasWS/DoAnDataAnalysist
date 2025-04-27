using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class DSXuatKhoDAO
    {
        DBConnection db = new DBConnection();
        public void AddDSXuatKho(DSXuatKho dsXuatKho)
        {
            string query = string.Format("INSERT INTO ChiTietDonXuatKho (MaDonXuatKho, MaNL, SoLuong, MaQC) VALUES ({0}, {1}, {2}, {3})",
                dsXuatKho.DonXuatKho.MaDonXuatKho, dsXuatKho.NguyenLieu.MaNL, dsXuatKho.SoLuong, dsXuatKho.QuyCach.MaQC);
            db.Execute(query);
        }
        public DataTable GetDSXuatKhoByDon(int id)
        {
            string query = string.Format("select * from v_ChiTietDonXuatKho where MaDonXuatKho = {0}", id);
            return db.Load(query);
        }
    }
}
