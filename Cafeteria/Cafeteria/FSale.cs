using Cafeteria.DAO;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FSale : Form
    {
        private DataTable orderTable;
        private BindingSource bsOrder;
        BindingSource menuList = new BindingSource();
        private DataTable menuTable;
        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        DonHangDAO donHangDAO = new DonHangDAO();
        ChiTietDonHangDAO chiTietDonHangDAO = new ChiTietDonHangDAO();
        public FSale()
        {
            InitializeComponent();
        }

        private void FSale_Load(object sender, EventArgs e)
        {
            DataTable menu = sanPhamDAO.getMenu();
            menuList.DataSource = menu;
            menuDGV.DataSource = menuList;
            orderTable = new DataTable();
            orderTable.Columns.Add("maSP", typeof(int));
            orderTable.Columns.Add("tenSP", typeof(string));
            orderTable.Columns.Add("giaTien", typeof(decimal));
            orderTable.Columns.Add("soLuong", typeof(int));
            bsOrder = new BindingSource { DataSource = orderTable };
            orderDGV.AutoGenerateColumns = true;
            orderDGV.DataSource = bsOrder;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FLogin formLogin = new FLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FDetailSP formSP = new FDetailSP();
            formSP.Show();
        }
        private void menuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var drv = menuDGV.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;
            DataRow row = drv.Row;
            int maSP = Convert.ToInt32(row["maSP"]);
            string tenSP = row["tenSP"].ToString();
            decimal giaTien = Convert.ToDecimal(row["giaTien"]);
            // Tạo dòng mới cho order và thêm
            var found = orderTable.Select($"maSP = {maSP}");
            if (found.Length > 0)
            {
                // Nếu có rồi thì chỉ tăng số lượng
                int curQty = Convert.ToInt32(found[0]["soLuong"]);
                found[0]["soLuong"] = curQty + 1;
                paymentAmout.Text = (int.Parse(paymentAmout.Text) + giaTien).ToString();
            }
            else
            {
                // Nếu chưa có thì thêm dòng mới với soLuong = 1
                var newRow = orderTable.NewRow();
                newRow["maSP"] = maSP;
                newRow["tenSP"] = tenSP;
                newRow["giaTien"] = giaTien;
                newRow["soLuong"] = 1;
                orderTable.Rows.Add(newRow);
                paymentAmout.Text = (int.Parse(paymentAmout.Text)+giaTien).ToString();
            }

            // Tuỳ chọn: cuộn tới dòng mới
            orderDGV.FirstDisplayedScrollingRowIndex = orderDGV.Rows.Count - 1;

        }

        private void orderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void orderDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            DataGridViewRow selectedRow = orderDGV.SelectedRows[0];
            DataRowView drv = selectedRow.DataBoundItem as DataRowView;
            if (drv == null) return;

            DataRow dataRow = drv.Row;

            FEditSP fEditSP = new FEditSP(dataRow);
            fEditSP.StartPosition = FormStartPosition.CenterParent;
            fEditSP.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FOrderList list = new FOrderList();
            list.Show();
            list.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang(int.Parse(cbTable.Text), DateTime.Now, 1, "", "Chua Thanh Toan");
            donHangDAO.add(donHang);
            int maDonHang = donHangDAO.getMaxId();
            foreach (DataRow r in orderTable.Rows)
            {
                ChiTietDonHang chiTietDonHang = new ChiTietDonHang(maDonHang, int.Parse(r[0].ToString()), int.Parse(r[3].ToString()));
                chiTietDonHangDAO.add(chiTietDonHang);
            }
            orderTable.Clear();
            MessageBox.Show("Order Success !");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (orderDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            DataGridViewRow selectedRow = orderDGV.SelectedRows[0];
            DataRowView drv = selectedRow.DataBoundItem as DataRowView;
            if (drv == null) return;

            DataRow dataRow = drv.Row;

            FEditSP fEditSP = new FEditSP(dataRow);
            fEditSP.StartPosition = FormStartPosition.CenterParent;
            fEditSP.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (orderDGV.CurrentRow == null) return;

            var drv = orderDGV.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            drv.Row.Delete();
            bsOrder.EndEdit();
        }
    }
}
