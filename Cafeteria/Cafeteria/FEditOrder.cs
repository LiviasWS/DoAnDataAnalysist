using Cafeteria.DAO;
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
    public partial class FEditOrder: Form
    {
        private DataRow rowToEdit;
        ChiTietDonHangDAO chiTietDonHangDAO = new ChiTietDonHangDAO();
        public FEditOrder(DataRow row)
        {
            InitializeComponent();
            rowToEdit = row;

            lbMaDH.Text = row["Ma Don Hang"].ToString();
            lbMaChiTietSP.Text = row["Ma Chi Tiet DH"].ToString();
            lbTenSP.Text = row["Ten SP"].ToString();
            lbDonGia.Text = row["Don Gia"].ToString();
            cbSoLuong.Text = row["So Luong"].ToString();
        }

        private void btnEditt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbSoLuong.Text, out int newQuantity))
            {
                rowToEdit["So Luong"] = newQuantity;
                chiTietDonHangDAO.EditQuantity(int.Parse(rowToEdit["Ma Chi Tiet DH"].ToString()), newQuantity);
                this.Close(); // Đóng sau khi sửa
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ!");
            }
        }
    }
}
