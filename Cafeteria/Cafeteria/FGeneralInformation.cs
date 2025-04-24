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
using static System.Net.Mime.MediaTypeNames;

namespace Cafeteria
{
    public partial class FGeneralInformation : Form
    {

        private string title;
        private string function;
        private string objectName;
        private List<string> attributes;
        public int objectID { get; set; }
        private DBConnection connection = new DBConnection();

        public FGeneralInformation(string title, string function, string objectName)
        {
            InitializeComponent();
            this.title = title;
            this.function = function;
            this.objectName = objectName;
        }

        private void FGeneralInformation_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;

            if (this.function == "Add")
            {
                AddFormMode();
            }  
            if (this.function == "ModifyProduct")
            {
                ModifyProductFormMode();
            }    
        }

        private void ModifyProductFormMode()
        {
            SanPhamDAO sanPhamDAO = new SanPhamDAO();
            SanPham sanPham = sanPhamDAO.getSanPhamFromID(objectID);
            UCGeneralInformationItem ucName = new UCGeneralInformationItem("Tên Sản Phẩm", sanPham.tenSP);
            UCGeneralInformationItem ucPrice = new UCGeneralInformationItem("Giá tiền", sanPham.giaTien.ToString());
            UCGeneralInformationItem ucType = new UCGeneralInformationItem("Loại sản phẩm", sanPham.loaiSP);
            flpList.Controls.Add(ucName);
            flpList.Controls.Add(ucPrice);
            flpList.Controls.Add(ucType);
            this.ActiveControl = lblTitle;
        }


        private void AddFormMode()
        {
            Dictionary<string, string> attributeList = getAttributes();
            foreach (KeyValuePair<string, string> kvp in attributeList) 
            {
                if (kvp.Key.StartsWith("ma") == false)
                {
                    UCGeneralInformationItem uc = new UCGeneralInformationItem(kvp.Key, "");
                    flpList.Controls.Add(uc);
                }
            }

        }

        private Dictionary<string, string> getAttributes()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string getAttributeCommand = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME = '" + objectName + "';";
            DataTable dataTable = connection.Load(getAttributeCommand);
            foreach(DataRow row in dataTable.Rows) 
            {
                string attribute = row["COLUMN_NAME"].ToString();
                string dataType = row["DATA_TYPE"].ToString();
                result.Add(attribute, dataType);
            }
            return result;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (function == "Add")
            {
                AddFunction();
            }
            if (this.function == "ModifyProduct")
            {
                ModifyProductFunction();
            }
        }

        private void ModifyProductFunction()
        {
            UCGeneralInformationItem ucName = flpList.Controls[0] as UCGeneralInformationItem;
            UCGeneralInformationItem ucPrice = flpList.Controls[1] as UCGeneralInformationItem;
            UCGeneralInformationItem ucType = flpList.Controls[2] as UCGeneralInformationItem;
            string sqlCommand = "UPDATE SanPham SET TENSP = '" + ucName.getValue()
                + "', GIATIEN = " + ucPrice.getValue() + ", LOAISP = '" + ucType.getValue() + "'" +
                " WHERE MASP = " + this.objectID + ";";
            connection.Execute(sqlCommand);
            this.Close();
        }

        private void AddFunction()
        {
            string sqlCommand = "INSERT INTO " + objectName + "(";
            Dictionary<string, string> attributes = getAttributes();
            foreach (UCGeneralInformationItem uc in flpList.Controls)
            {
                sqlCommand += uc.getAttribute() + ", ";
            }
            sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 2);
            sqlCommand += ") VALUES (";
            foreach(UCGeneralInformationItem uc in flpList.Controls)
            {
                string attribute = uc.getAttribute();
                string value = uc.getValue();
                string dataType;
                attributes.TryGetValue(attribute, out dataType);
                if (dataType == "nvarchar")
                {
                    sqlCommand += "'" + value + "', ";
                }
                else
                {
                    sqlCommand += value + ", ";
                }
            }
            sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 2);
            sqlCommand += ");";
            connection.Execute(sqlCommand);
            this.Close();
        }

        private string getIDName()
        {
            switch (objectName)
            {
                case "SanPham":
                    return "maSP";
                default:
                    return "";
                    break;
            }
        }

    }
}
