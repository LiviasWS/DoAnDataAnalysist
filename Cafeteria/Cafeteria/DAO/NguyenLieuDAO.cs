using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DAO
{
    internal class NguyenLieuDAO
    {
        DBConnection db = new DBConnection();
        public void AddNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = string.Format("INSERT INTO NguyenLieu (TenNL) VALUES ('{0}')",nguyenLieu.TenNL);
            db.Execute(query);
        }
        public int AddNguyenLieuGetId(NguyenLieu nguyenLieu)
        {
            string query = string.Format("INSERT INTO NguyenLieu (TenNL) VALUES ('{0}') select SCOPE_IDENTITY()", nguyenLieu.TenNL);
            int id = db.ExecuteScalar(query);
            return id;
        }
        public DataTable GetAllNguyenLieu()
        {
            string query = "SELECT * FROM NguyenLieu";
            return db.Load(query);
        }
        public NguyenLieu FindByName(string name)
        {
            string query = string.Format("SELECT * FROM NguyenLieu WHERE tenNL = '{0}'", name);
            DataTable dt = db.Load(query);
            NguyenLieu nguyenLieu = new NguyenLieu();
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    nguyenLieu.MaNL = (int)item[0];
                    nguyenLieu.TenNL = item[1].ToString();
                }
                return nguyenLieu;
            }
            return null;
        }
        public NguyenLieu FindById(int id)
        {
            string query = string.Format("SELECT * FROM NguyenLieu WHERE MaNL = {0}", id);
            DataTable dt = db.Load(query);
            NguyenLieu nguyenLieu = new NguyenLieu();
            if( dt.Rows.Count > 0 )
            {
                foreach (DataRow item in dt.Rows)
                {
                    nguyenLieu.MaNL = (int)item[0];
                    nguyenLieu.TenNL = item[1].ToString();
                }
                return nguyenLieu;
            }
            return null;
        }
        public int GetCount()
        {
            string query = "SELECT Count(*) FROM NguyenLieu";
            DataTable dt = db.Load(query);
            return (int)dt.Rows[0][0];
        }
    }
}
