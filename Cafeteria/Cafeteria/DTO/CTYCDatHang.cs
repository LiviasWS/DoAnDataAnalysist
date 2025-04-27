using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    public class CTYCDatHang
    {
        private int maDonYeuCau;
        private int maNL;
        private int soLuong;
        private int maQC;
        private string trangThai;
        public CTYCDatHang() 
        {
            
        }

        public int MaDonYeuCau { get { return maDonYeuCau; } set {  maDonYeuCau = value; } }
        public int MaNL { get {  return maNL; } set { maNL = value; } }
        public int SoLuong { get {  return soLuong; } set {  soLuong = value; } }
        public int MaQC { get { return maQC; } set { maQC = value; } }
        public string TrangThai { get { return trangThai; } set { trangThai = value; } }

    }
}
