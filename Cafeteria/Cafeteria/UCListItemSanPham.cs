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
    public partial class UCListItemSanPham : UserControl
    {

        int count;
        public SanPham sanPham { get; set; }
        public event EventHandler SanPhamChanged;

        public UCListItemSanPham(int count, SanPham sanPham)
        {
            InitializeComponent();
            this.count = count;
            this.sanPham = sanPham;
        }

        private void UCListItem_Load(object sender, EventArgs e)
        {
            if((this.count%2)==0)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }

            lblName.Text = sanPham.tenSP;
            lblPrice.Text = sanPham.giaTien.ToString();
            lblType.Text = sanPham.loaiSP;

        }

        public bool getCheckBoxStatus()
        {
            if (cbChoosen.Checked) 
            {
                return true;
            }
            return false;
        }

        private void cbChoosen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
