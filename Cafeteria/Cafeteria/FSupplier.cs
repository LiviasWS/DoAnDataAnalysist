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
    public partial class FSupplier : Form
    {
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        public FSupplier()
        {
            InitializeComponent();
        }

        private void FSupplier_Load(object sender, EventArgs e)
        {
            ReloadFilter();
            ReloadFLP();
        }

        private void ReloadFLP()
        {
            flpList.Controls.Clear();
            int i = 0;
            List<NhaCungCap> nhaCungCaps = nhaCungCapDAO.getAllNhaCungCaps();
            foreach (NhaCungCap ncc in nhaCungCaps)
            {
                UCSupplierListItem uc = new UCSupplierListItem(ncc, i++);
                flpList.Controls.Add(uc);
            }
        }

        private void ReloadFilter()
        {
            UCFilterItemTextBox searchingBox = new UCFilterItemTextBox("Search", "Enter searching value");
            flpFilter.Controls.Add(searchingBox);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FGeneralInformation f = new FGeneralInformation("", "AddSupplier", "");
            f.ShowDialog();
            ReloadFLP();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
            foreach(UCSupplierListItem uc in flpList.Controls)
            {
                if(uc.GetCheckBoxValue() == true)
                {
                    NhaCungCap ncc = uc.GetNhaCungCap();
                    nhaCungCapDAO.DeleteNhaCungCap(ncc.MaNCC);
                }
            }
            ReloadFLP();
        }
    }
}
