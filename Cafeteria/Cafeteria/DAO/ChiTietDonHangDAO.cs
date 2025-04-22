using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    class ChiTietDonHangDAO
    {
        DBConnection dBConnection = new DBConnection();
        public void add(ChiTietDonHang item)
        {
            string query = string.Format("insert into ChiTietDonHang(maDonHang,maSP,soLuong) values ('{0}','{1}','{2}')", item.MaDonHang, item.MaSP, item.SoLuong);
            dBConnection.Execute(query);
        }
        public DataTable getChiTietDonHangById(int maDonHang)
        {
            string query = string.Format("select maDonHang as [Ma Don Hang], maChiTietDonHang as [Ma Chi Tiet DH], tenSP as [Ten SP], soLuong as [So Luong], giaTien as [Don Gia] from ChiTietDonHang  inner join SanPham on ChiTietDonHang.maSP= SanPham.maSP where maDonHang= '{0}'",maDonHang);
            return dBConnection.Load(query);
        }
        public void DeleteChiTietDH(int maChiTietDH)
        {
            string query = string.Format("delete ChiTietDonHang where maChiTietDonHang= '{0}'", maChiTietDH);
            dBConnection.Execute(query);
        }
        public void EditQuantity(int maChiTietDonHang, int soLuong)
        {
            string query = string.Format("update ChiTietDonHang set soLuong = '{0}' where maChiTietDonHang ='{1}'", soLuong, maChiTietDonHang);
            dBConnection.Execute(query);
        }
    }
}
