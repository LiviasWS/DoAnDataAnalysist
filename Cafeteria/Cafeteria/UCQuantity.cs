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
    public partial class UCQuantity : UserControl
    {
        
        public UCQuantity()
        {
            InitializeComponent();
        }
        public Label lbTenSp
        {
            get { return ucLbTenSP; }
            set { ucLbTenSP = value; }
        }
        public Label lbMaSp
        {
            get { return ucLbMaSP; }
            set { ucLbMaSP = value; }
        }
        public Label lbGiaTien
        {
            get { return ucLbGiaTien; }
            set { ucLbGiaTien = value; }
        }
        public ComboBox cbSoLuong
        {
            get { return ucCbSoLuong; }
            set { ucCbSoLuong = value; }
        }
    }
}
