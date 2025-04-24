using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class UCGeneralInformationItem : UserControl
    {
        private string attribute;
        private string value;
        public UCGeneralInformationItem(string attribute, string value)
        {
            InitializeComponent();
            this.attribute = attribute;
            this.value = value;
        }

        private void UCGeneralInformationItem_Load(object sender, EventArgs e)
        {
            lblAttribute.Text = attribute +":";
            txtValue.Text = value;
        }

        public string getValue()
        {
            return txtValue.Text;
        }

        public string getAttribute()
        {
            return attribute;
        }

    }
}
