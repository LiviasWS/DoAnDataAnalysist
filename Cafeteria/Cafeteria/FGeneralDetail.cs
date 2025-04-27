using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FGeneralDetail : Form
    {
        private DBConnection conn = new DBConnection();
        int objectID;
        string function;
        public FGeneralDetail(int objectID, string function)
        {
            InitializeComponent();
            this.objectID = objectID;
            this.function = function;
        }

        private void rtxtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void FGeneralDetail_Load(object sender, EventArgs e)
        {
            if (this.function == "DetailHoaDon")
            {
                DetailHoaDon();
            }
        }

        private void DetailHoaDon()
        {
            string sqlCommand = "SELECT * FROM DBO.SHOW_CHITIET_HOADON(" + objectID + ");";
            lblTitle.Text = "Chi tiết hóa đơn";
            DataTable dataTable = conn.Load(sqlCommand);
            foreach(DataRow row in dataTable.Rows) 
            {
                string tennl = row["tenSP"].ToString();
                int giaTien = Convert.ToInt32(row["giaTien"]);
                int soLuong = Convert.ToInt32(row["soLuong"]);
                UCHoaDonDetailItem uc = new UCHoaDonDetailItem(tennl, giaTien, soLuong);
                flpList.Controls.Add(uc);
            }
        }

    }
}
