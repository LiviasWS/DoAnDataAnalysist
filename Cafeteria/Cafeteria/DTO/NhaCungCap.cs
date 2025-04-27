using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class NhaCungCap
    {
        private int maNCC;
        private string tenNCC;
        private string sdt;
        private string diaChi;
        private string moTa;
        public NhaCungCap() { }
        public int MaNCC { get { return maNCC; } set { maNCC = value; } }
        public string TenNCC { get { return tenNCC; } set {  tenNCC = value; } }
        public string Sdt { get {  return sdt; } set {  sdt = value; } }
        public string DiaChi { get {  return diaChi; } set {  diaChi = value; } }
        public string MoTa { get {  return moTa; } set {  moTa = value; } }
    }
}
