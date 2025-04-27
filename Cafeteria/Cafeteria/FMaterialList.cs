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
    public partial class FMaterialList : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nlTrongKhoDAO = new NLTrongKhoDAO();
        DBConnection conn = new DBConnection();
        public FMaterialList()
        {
            InitializeComponent();
        }

        private void FMaterialList_Load(object sender, EventArgs e)
        {
            ReloadFilter();
            List<NLTrongKho> nLTrongKhos = nlTrongKhoDAO.getAllNLTrongKho();
            reLoadFLP(nLTrongKhos);
            this.ActiveControl = lblTitle;
        }

        private void ReloadFilter()
        {
            flpFilter.Controls.Clear();
            UCFilterItemTextBox ucSearching = new UCFilterItemTextBox("Seach", "Enter value to find");
            UCFilterItemCheckBoxList ucFilterTenQC = new UCFilterItemCheckBoxList("Unit", quyCachDAO.getAllTenQC());
            flpFilter.Controls.Add(ucSearching);
            flpFilter.Controls.Add(ucFilterTenQC);
        }

        private void reLoadFLP(List<NLTrongKho> nLTrongKhos)
        {  
            flpList.Controls.Clear();
            foreach(NLTrongKho nLTrongKho in nLTrongKhos) 
            {
                NguyenLieu nguyenLieu = nguyenLieuDAO.GetNguyenLieuById(nLTrongKho.MaNL);
                QuyCach quyCach = quyCachDAO.GetQuyCachByID(nLTrongKho.MaQC);
                UCMaterialListItem uc = new UCMaterialListItem(nguyenLieu.TenNL, quyCach.TenQC, nLTrongKho.SoLuong);
                flpList.Controls.Add(uc);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FGeneralInformation f = new FGeneralInformation("", "AddMaterial", "");
            f.ShowDialog();
            ReloadFilter();
            reLoadFLP(nlTrongKhoDAO.getAllNLTrongKho());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(UCMaterialListItem uc in flpList.Controls)
            {
                if (uc.GetCheckBoxValue() == true)
                {
                    string sqlCommand = "EXEC DELETE_NGUYENLIEU @TENNL = '" + uc.GetMaterialName() + "', @TENQC = '" + uc.GetMaterialUnit() + "'";
                    conn.Execute(sqlCommand);
                }
            }
            reLoadFLP(nlTrongKhoDAO.getAllNLTrongKho());
            ReloadFilter();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            foreach (UCMaterialListItem uc in flpList.Controls)
            {
                if (uc.GetCheckBoxValue() == true)
                {
                    FInformation2Input f = new FInformation2Input("ModifyMaterial");
                    string tenNL = uc.GetMaterialName();
                    string tenQC = uc.GetMaterialUnit();
                    NguyenLieu nguyenLieu = nguyenLieuDAO.GetNguyenLieuByName(tenNL);
                    QuyCach quyCach = quyCachDAO.GetQuyCachByName(tenQC);
                    f.input1 = nguyenLieu.MaNL;
                    f.input2 = quyCach.MaQC;
                    f.ShowDialog();
                }
            }
            ReloadFilter();
            reLoadFLP(nlTrongKhoDAO.getAllNLTrongKho());
        }
    }
}
