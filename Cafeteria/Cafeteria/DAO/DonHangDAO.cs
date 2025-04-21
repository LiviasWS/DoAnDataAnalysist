using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    class DonHangDAO
    {
        public void add(DonHang item)
        {
            string ngay = item.NgayTao.ToString("yyyy-MM-dd HH:mm:ss");
            string query = string.Format("insert into DonHang(ban,ngayTao,idNguoiTao,ghiChu) values ('{0}','{1}','{2}','{3}')", item.Ban, ngay, item.IdNguoiTao, item.GhiChu);
            DBConnection dBConnection = new DBConnection();
            dBConnection.Execute(query);
        }
        public int getMaxId()
        {
            string query = string.Format("SELECT max(maDonHang) from DonHang");
            DBConnection dBConnection = new DBConnection();
            object ob= dBConnection.GetScalar(query);
            return int.Parse(ob.ToString());
        }
    }
}
