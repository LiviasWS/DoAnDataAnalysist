using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class DonDatHang
    {
        private int maDDH;
        private int maNCC;
        private DateTime ngayTao;
        private int tongGiaTri;
        private DateTime ngayGiao;
        private string ghiChu;

        public DonDatHang() { }

        public int MaDDH { get { return maDDH; } set { maDDH = value; } }
        public int MaNCC { get {  return maNCC; } set { maNCC = value; } }
        public DateTime NgayTao { get { return ngayTao; } set { ngayTao = value; } }
        public int TongGiaTri { get {  return tongGiaTri; } set {  tongGiaTri = value; } }
        public DateTime NgayGiao { get {  return ngayGiao; } set { ngayGiao = value; } }
        public string GhiChu { get {  return ghiChu; } set {  ghiChu = value; } }

    }
}
