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
    public partial class UCInvoiceItem : UserControl
    {
        private HoaDon hoaDon;
        private int count;
        public UCInvoiceItem(HoaDon hoaDon, int count)
        {
            InitializeComponent();
            this.hoaDon = hoaDon;
            this.count = count;
        }

        private void UCInvoiceItem_Load(object sender, EventArgs e)
        {
            if ((this.count % 2) == 0)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }

            lblDate.Text = hoaDon.ngayTao.ToLongDateString();
            lblPaymentMethod.Text = hoaDon.phuongThuc.ToString();
            lblNote.Text = hoaDon.ghiChu.ToString();
            lblPrice.Text = hoaDon.tongHD.ToString();
        }

        private void UCInvoiceItem_Click(object sender, EventArgs e)
        {
            FGeneralDetail f = new FGeneralDetail(hoaDon.maHD, "DetailHoaDon");
            f.ShowDialog();
        }
    }
}
