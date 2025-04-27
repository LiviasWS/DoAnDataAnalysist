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
    public partial class UCMaterialListItem : UserControl
    {
        private string name;
        private string unit;
        private int quantity;
        public UCMaterialListItem(string name,string unit, int quantity)
        {
            InitializeComponent();
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
        }

        private void UCMaterialListItem_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblUnit.Text = unit;
            lblQuantity.Text = quantity.ToString();
        }

        public bool GetCheckBoxValue()
        {
            if(cbChoosen.Checked == true)
                return true;
            return false;
        }

        public string GetMaterialName()
        {
            return lblName.Text;
        }

        public int GetMaterialQuantity()
        {
            return quantity;
        }

        public string GetMaterialUnit()
        {
            return lblUnit.Text;
        }

        private void cbChoosen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
