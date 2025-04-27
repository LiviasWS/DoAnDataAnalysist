using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class UCHoaDonDetailItem : UserControl
    {
        private DbConnection conn;
        private string tenNl;
        private int giaTien;
        private int soLuong;
        private int tongTien;

        public UCHoaDonDetailItem(string tenNl, int giaTien, int soLuong)
        {
            InitializeComponent();
            this.tenNl = tenNl;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
        }

        private void UCHoaDonDetailItem_Load(object sender, EventArgs e)
        {
            tongTien = giaTien * soLuong;
            lblName.Text = tenNl;
            lblPrice.Text = giaTien.ToString();
            lblQuantity.Text = soLuong.ToString();
            lblTotalPrice.Text = tongTien.ToString();
        }
    }
}
