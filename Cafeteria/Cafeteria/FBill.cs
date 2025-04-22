using Cafeteria.DAO;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FBill : Form
    {
        private HoaDon hoaDon;
        private DataTable orderDetailTable;
        public HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }
        public DataTable OrderDetailTable { get => orderDetailTable; set => orderDetailTable = value; }

        public FBill(HoaDon hd, DataTable orderDetailTable)
        {
            InitializeComponent();
            this.HoaDon = hd;
            this.orderDetailTable = orderDetailTable;
        }

        private void FBill_Load(object sender, EventArgs e)
        {
            orderDetailDGV.DataSource = orderDetailTable;
            lblDate.Text = hoaDon.NgayTao.ToString();
            lblTotal.Text = hoaDon.TongHD.ToString();
            switch (hoaDon.PhuongThuc)
            {
                case "Cash":
                    rbtnCash.Checked = true;
                    break;
                case "E-wallet":
                    rBtnEwallet.Checked = true;
                    break;
                default:
                    rBtnCreditCard.Checked = true;
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FOrderList fOrderList = new FOrderList();
            fOrderList.Show();
            this.Hide();
        }

        private void btnPaymentConfirm_Click(object sender, EventArgs e)
        {
            hoaDon.GhiChu = tbNote.Text;
            HoaDonDAO hoaDonDao = new HoaDonDAO();
            hoaDonDao.UpdateNote(hoaDon);
            MessageBox.Show("Payment Success!");
            FOrderList fOrderList = new FOrderList();
            fOrderList.Show();
            this.Hide();
        }
    }
}
