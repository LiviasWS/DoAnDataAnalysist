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
using System.Windows.Forms.VisualStyles;

namespace Cafeteria
{
    public partial class FInformation2Input : Form
    {
        private string function;
        public int input1 {  get; set; }
        public int input2 { get; set; }
        private NLTrongKhoDAO nlTrongKhoDAO = new NLTrongKhoDAO();
        private NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        private QuyCachDAO quyCachDAO = new QuyCachDAO();
        private DBConnection conn = new DBConnection();
        public FInformation2Input(string function)
        {
            InitializeComponent();
            this.function = function;
        }

        private void rtxtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void FInformation2Input_Load(object sender, EventArgs e)
        {
            if (function == "ModifyMaterial")
            {
                ModifyMaterialFormMode();
            }
        }

        private void ModifyMaterialFormMode()
        {
            lblTitle.Text = "Modify Material";
            int maNL = input1;
            int maQC = input2;
            NLTrongKho nLTrongKho = nlTrongKhoDAO.GetNLTrongKho(maNL, maQC);
            NguyenLieu nguyenLieu = nguyenLieuDAO.GetNguyenLieuById(maNL);
            QuyCach quyCach = quyCachDAO.GetQuyCachByID(maQC);
            UCGeneralInformationItem ucName = new UCGeneralInformationItem("Tên nguyên liệu", nguyenLieu.TenNL);
            UCGeneralInformationItem ucQuantity = new UCGeneralInformationItem("Số lượng", nLTrongKho.SoLuong.ToString());
            UCGeneralInformationItem ucUnit = new UCGeneralInformationItem("Đơn vị", quyCach.TenQC);
            flpList.Controls.Add(ucName);
            flpList.Controls.Add(ucQuantity);
            flpList.Controls.Add(ucUnit);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.function == "ModifyMaterial")
            {
                ModifyMaterial();
            }
        }

        private void ModifyMaterial()
        {
            string[] input = new string[10];
            int i = 0;
            foreach(UCGeneralInformationItem ucItem in flpList.Controls) 
            {
                input[i++] = ucItem.getValue();
            }
            string sqlCommand = "EXEC MODIFY_NGUYENLIEU_TRONGKHO @MANL_OLD = " + input1 + 
                ", @MAQC_OLD = " + input2 + ", @TENNL = '" + input[0] 
                + "', @SOLUONG = " + input[1] + ", " + "@TENQC = '" + input[2] + "'";
            conn.Execute(sqlCommand);
            this.Close();
        }
    }
}
