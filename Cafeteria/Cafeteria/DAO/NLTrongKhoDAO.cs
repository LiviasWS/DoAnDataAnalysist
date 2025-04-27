using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class NLTrongKhoDAO
    {
        DBConnection db = new DBConnection();
        public void AddNLTrongKho(NLTrongKho nlTrongKho)
        {
            string query = string.Format("INSERT INTO NLTrongKho (MaNL, SoLuong, MaQC) VALUES ({0}, {1}, {2})", nlTrongKho.NguyenLieu.MaNL, nlTrongKho.SoLuong, nlTrongKho.QuyCach.MaQC);
            db.Execute(query);
        }
        public void EditNLTrongKho(NLTrongKho nlTrongKho)
        {
            string query = string.Format("UPDATE NLTrongKho SET SoLuong = {0} WHERE MaQC = {1} AND MaNL = {2}", nlTrongKho.SoLuong, nlTrongKho.QuyCach.MaQC, nlTrongKho.NguyenLieu.MaNL);
            db.Execute(query);
        }
        public NLTrongKho FindNLTrongKho(NguyenLieu nguyenLieu, QuyCach quyCach)
        {
            string query = string.Format("SELECT * FROM NLTrongKho WHERE MaNL = {0} AND MaQC = {1}", nguyenLieu.MaNL, quyCach.MaQC);
            DataTable dt = db.Load(query);
            if (dt.Rows.Count > 0)
            {
                return new NLTrongKho(nguyenLieu, (int)dt.Rows[0][1], quyCach);
            }
            return null;
        }
        public DataTable GetAllNLTrongKho()
        {
            string query = "SELECT * FROM v_NLTrongKho";
            return db.Load(query);
        }
        public List<NguyenLieu> LoadNguyenLieu()
        {
            string query = string.Format("SELECT nl.MaNL, nl.tenNL FROM NLTrongKho nltk JOIN NguyenLieu nl ON nltk.MaNL = nl.MaNL");
            DataTable dt = db.Load(query);
            List<NguyenLieu> nguyenLieus = new List<NguyenLieu>();
            foreach (DataRow item in dt.Rows)
            {
                NguyenLieu nguyenLieu = new NguyenLieu();
                nguyenLieu.MaNL = (int)item[0];
                nguyenLieu.TenNL = item[1].ToString();
                nguyenLieus.Add(nguyenLieu);
            }
            return nguyenLieus;
        }
    }
}
