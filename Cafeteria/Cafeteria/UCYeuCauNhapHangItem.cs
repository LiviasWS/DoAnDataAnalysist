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
    public partial class UCYeuCauNhapHangItem : UserControl
    {
        private DonYeuCauNhapHang donYeuCauNhapHang;
        private int count;
        public UCYeuCauNhapHangItem(DonYeuCauNhapHang donYeuCauNhapHang, int count)
        {
            InitializeComponent();
            this.donYeuCauNhapHang = donYeuCauNhapHang;
            this.count = count;
        }

        private void UCYeuCauNhapHangItem_Load(object sender, EventArgs e)
        {
            if ((this.count % 2) == 0)
            {
                pItem.BackColor = Color.White;
            }
            else
            {
                pItem.BackColor = Color.WhiteSmoke;
            }
            lblCreateDate.Text = donYeuCauNhapHang.NgayTao.ToString();
            lblNote.Text = donYeuCauNhapHang.GhiChu.ToString();
            lblOutOfStock.Text = donYeuCauNhapHang.NgayDuKienHetHang.ToString();
        }
    }
}
