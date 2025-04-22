using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    class DonHangDAO
    {
        DBConnection dBConnection = new DBConnection();
        public void add(DonHang item)
        {
            string ngay = item.NgayTao.ToString("yyyy-MM-dd HH:mm:ss");
            string query = string.Format("insert into DonHang(ban,ngayTao,idNguoiTao,ghiChu, trangThai) values ('{0}','{1}','{2}','{3}','{4}')", item.Ban, ngay, item.IdNguoiTao, item.GhiChu, item.TrangThai);
            dBConnection.Execute(query);
        }
        public void Payment(int maDonHang)
        {
            string query = string.Format("update DonHang set trangThai='Da Thanh Toan' where maDonHang= '{0}'", maDonHang);
            dBConnection.Execute(query);
        }
        public int getMaxId()
        {
            string query = string.Format("SELECT max(maDonHang) from DonHang");
            object ob= dBConnection.GetScalar(query);
            return int.Parse(ob.ToString());
        }
        public DataTable getUnpaidOrders()
        {
            string query = String.Format("select * from DonHang where trangThai= 'Chua Thanh Toan'");
            DataTable dt = dBConnection.Load(query);
            return dt;
        }
        public DataTable getOrderList()
        {
            string query = String.Format("select * from DonHang ");
            DataTable dt = dBConnection.Load(query);
            return dt;
        }
        public DataTable getOrderByBill(int maHD)
        {
            string query = String.Format("select * from DonHang inner join HoaDon_DonHang on DonHang.maDonHang=HoaDon_DonHang.maDonHang where maHD = '{0}'", maHD);
            DataTable dt = dBConnection.Load(query);
            return dt;
        }
    }
}
