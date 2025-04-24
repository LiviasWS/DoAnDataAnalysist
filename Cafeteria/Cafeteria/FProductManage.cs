using Cafeteria.DAO;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FProductManage : Form
    {

        DBConnection conn = new DBConnection();
        SanPhamDAO sanPhamDAO = new SanPhamDAO();

        public FProductManage()
        {
            InitializeComponent();
        }

        private void FProductManage_Load(object sender, EventArgs e)
        {
            UCFilterItemTextBox searchingBox = new UCFilterItemTextBox("Search", "Enter searching value");
            UCFilterItemCheckBoxList typeFilter = new UCFilterItemCheckBoxList("Product Types", sanPhamDAO.getAllLoaiSP());
            flpFilter.Controls.Add(searchingBox);
            flpFilter.Controls.Add(typeFilter);
            reLoadFLP();
        }

        private void reLoadFLP()
        {
            List<SanPham> sanPhams = sanPhamDAO.getAllSanPham();
            flpList.Controls.Clear();
            int count = 0;
            foreach (SanPham sanPham in sanPhams)
            {
                UCListItemSanPham item = new UCListItemSanPham(count, sanPham);
                flpList.Controls.Add(item);
                count++;
            }
            this.ActiveControl = lblTitle;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FGeneralInformation fGeneralInformation = new FGeneralInformation("Add new product", "Add", "SanPham");
            fGeneralInformation.ShowDialog();
            FProductManage fProductManage = new FProductManage();
            fProductManage.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlCommand = "DELETE FROM SANPHAM WHERE ";
            foreach(UCListItemSanPham uc in flpList.Controls)
            {
                if(uc.getCheckBoxStatus() == true)
                {
                    sqlCommand += "maSP = " + uc.sanPham.maSP + " OR ";
                }
            }
            sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 4);
            sqlCommand += ";";
            conn.Execute(sqlCommand);
            reLoadFLP();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            foreach(UCListItemSanPham uc in flpList.Controls)
            {
                if (uc.getCheckBoxStatus() == true)
                {
                    FGeneralInformation fGeneralInformation = new FGeneralInformation("Modify Product Information", "ModifyProduct", "SanPham");
                    fGeneralInformation.objectID = uc.sanPham.maSP;
                    fGeneralInformation.ShowDialog();
                }    
            }    
            reLoadFLP();
        }
    }
}
