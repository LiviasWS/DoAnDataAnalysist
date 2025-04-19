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
    public partial class FSale : Form
    {
        public FSale()
        {
            InitializeComponent();
        }

        private void FSale_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FLogin formLogin = new FLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FBill formBill = new FBill();
            formBill.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FDetailSP formSP = new FDetailSP();
            formSP.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FEditSP formEdit = new FEditSP();
            formEdit.Show();
        }
    }
}
