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
    public partial class FEditSP : Form
    {
        private DataRow rowToEdit;
        public FEditSP(DataRow row)
        {
            InitializeComponent();
            rowToEdit = row;

            ucSp.lbMaSp.Text = row["maSP"].ToString();
            ucSp.lbTenSp.Text = row["tenSP"].ToString();
            ucSp.lbGiaTien.Text = row["giaTien"].ToString();
            ucSp.cbSoLuong.Text = row["soLuong"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ucSp.cbSoLuong.Text, out int newQuantity))
            {
                rowToEdit["soLuong"] = newQuantity;
                this.Close(); // Đóng sau khi sửa
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ!");
            }
        }
    }
}
