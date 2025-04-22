using Cafeteria.DAO;
using Cafeteria.DTO;
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
    public partial class FOrderList: Form
    {
        private DataTable orderTable;
        private BindingSource bsOrder= new BindingSource();
        private DataTable orderDetailTable;
        private BindingSource bsOrderDetail = new BindingSource();
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        DonHangDAO donHangDAO = new DonHangDAO();
        HoaDonDonHangDAO hoaDonDonHangDAO = new HoaDonDonHangDAO();
        ChiTietDonHangDAO chiTietDonHangDAO = new ChiTietDonHangDAO();

        public FOrderList()
        {
            InitializeComponent();
            bsOrderDetail.DataSource = orderDetailTable;
            orderDetailDGV.DataSource = bsOrderDetail;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FSale sale = new FSale();
            sale.Show();
            sale.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }
        private void FOrderList_Load(object sender, EventArgs e)
        {
            orderTable = donHangDAO.getUnpaidOrders();
            bsOrder.DataSource = orderTable;
            orderDGV.DataSource = bsOrder;
            
            orderDetailTable = new DataTable();
            orderDetailTable.Columns.Add("Ma Don Hang", typeof(int));
            orderDetailTable.Columns.Add("Ma Chi Tiet DH", typeof(int));
            orderDetailTable.Columns.Add("Ten SP", typeof(string));
            orderDetailTable.Columns.Add("So Luong", typeof(int));
            orderDetailTable.Columns.Add("Don Gia", typeof(int));
        }

        private void orderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var drv = orderDGV.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            int maDonHang = Convert.ToInt32(drv.Row["maDonHang"]);
            var details = chiTietDonHangDAO.getChiTietDonHangById(maDonHang);

            int addedAmount = 0;
            foreach (DataRow r in details.Rows)
            {
                int chiTietId = Convert.ToInt32(r["Ma Chi Tiet DH"]);

                // Chỉ kiểm tra bằng Select, không dùng Rows.Find
                var existing = orderDetailTable.Select($"[Ma Chi Tiet DH] = {chiTietId}");
                if (existing.Length == 0)
                {
                    // Tạo dòng mới và map từng cột
                    DataRow newRow = orderDetailTable.NewRow();
                    newRow["Ma Don Hang"] = maDonHang;
                    newRow["Ma Chi Tiet DH"] = chiTietId;
                    newRow["Ten SP"] = r["Ten SP"];
                    newRow["So Luong"] = r["So Luong"];
                    newRow["Don Gia"] = r["Don Gia"];
                    orderDetailTable.Rows.Add(newRow);

                    // Cộng tiền tương ứng của dòng mới
                    addedAmount +=
                        Convert.ToInt32(r["So Luong"]) *
                        Convert.ToInt32(r["Don Gia"]);
                }
            }
            // update payment label
            orderDetailDGV.DataSource = orderDetailTable;
            int current = 0;
            int.TryParse(lbPayment.Text, out current);
            lbPayment.Text = (current + addedAmount).ToString();

            // scroll to last
            if (orderDetailDGV.Rows.Count > 0)
                orderDetailDGV.FirstDisplayedScrollingRowIndex = orderDetailDGV.Rows.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(DateTime.Now, 1, cbPaymentMethod.Text, "", int.Parse(lbPayment.Text));
            hoaDonDAO.add(hd);
            int maHoaDon = hoaDonDAO.getMaxId();
            hd.MaHD = maHoaDon;
            foreach (DataRow r in orderDetailTable.Rows)
            {
                
            }
            for (int i = 0; i < orderDetailDGV.Rows.Count - 1; i++)
            {
                int maDonHang = int.Parse(orderDetailDGV.Rows[i].Cells[0].Value.ToString());
                donHangDAO.Payment(maDonHang);
                if (i == 0 || ((orderDetailDGV.Rows[i].Cells[0].Value.ToString() != orderDetailDGV.Rows[i - 1].Cells[0].Value.ToString()) && i>0))
                {
                    HoaDonDonHang item = new HoaDonDonHang(maHoaDon, maDonHang);
                    hoaDonDonHangDAO.add(item);
                }
            }
            FBill formBill = new FBill(hd, orderDetailTable);
            formBill.Show();
            this.Hide();
        }

        private void orderDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var drv = orderDGV.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            DataRow row = drv.Row;
            int maDonHang = Convert.ToInt32(row["maDonHang"]);
            orderDetailTable = chiTietDonHangDAO.getChiTietDonHangById(maDonHang);
            bsOrderDetail.DataSource = orderDetailTable;
            orderDetailDGV.DataSource = bsOrderDetail;
            int totalPayment = 0;

            for (int i = 0; i < orderDetailDGV.Rows.Count - 1; i++)
            {
                int soLuong = int.Parse(orderDetailDGV.Rows[i].Cells[3].Value.ToString());
                int donGia = int.Parse(orderDetailDGV.Rows[i].Cells[4].Value.ToString());

                totalPayment += soLuong * donGia;
            }

            // Gán kết quả vào label thanh toán
            lbPayment.Text = totalPayment.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        { 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (orderDetailDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            DataGridViewRow selectedRow = orderDetailDGV.SelectedRows[0];
            DataRowView drv = selectedRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            DataRow dataRow = drv.Row;
            FEditOrder fEditOrder = new FEditOrder(dataRow);
            fEditOrder.StartPosition = FormStartPosition.CenterParent;
            fEditOrder.ShowDialog();
        }
    }
}
