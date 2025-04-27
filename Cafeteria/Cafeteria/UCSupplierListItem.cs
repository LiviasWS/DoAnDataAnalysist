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
    public partial class UCSupplierListItem : UserControl
    {
        private NhaCungCap nhaCungCap;
        private int count;
        public UCSupplierListItem(NhaCungCap nhaCungCap, int count)
        {
            InitializeComponent();
            this.nhaCungCap = nhaCungCap;
            this.count = count;
        }

        private void UCSupplierListItem_Load(object sender, EventArgs e)
        {
            if ((this.count % 2) == 0)
            {
                pItem.BackColor = Color.White;
            }
            else
            {
                pItem.BackColor = Color.WhiteSmoke;
            }
            lblName.Text = nhaCungCap.TenNCC;
            lblAddress.Text = nhaCungCap.DiaChi;
            lblPhoneNumber.Text = nhaCungCap.Sdt;
            lblDescription.Text = nhaCungCap.MoTa;
        }

        public NhaCungCap GetNhaCungCap()
        {
            return nhaCungCap;
        }

        public bool GetCheckBoxValue()
        {
            if(cbChoosen.Checked)
            {
                return true;
            }
            return false;
        }

    }
}
