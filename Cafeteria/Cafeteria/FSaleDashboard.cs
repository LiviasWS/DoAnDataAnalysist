using Cafeteria.DAO;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FSaleDashboard : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        List<HoaDon> hoaDons = new List<HoaDon>();
        public FSaleDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FSaleDashboard_Load(object sender, EventArgs e)
        {
            List<string> mouthList = new List<string>();
            mouthList.Add("January");
            mouthList.Add("Febulary");
            mouthList.Add("March");
            mouthList.Add("April");
            mouthList.Add("May");
            mouthList.Add("June");
            mouthList.Add("July");
            mouthList.Add("August");
            mouthList.Add("September");
            mouthList.Add("October");
            mouthList.Add("November");
            mouthList.Add("December");
            UCFilterItemTextBox searchingBox = new UCFilterItemTextBox("Search", "Enter searching value");
            UCFilterItemTextBox dayFilterBox = new UCFilterItemTextBox("Day", "Enter day value");
            UCFilterItemCheckBoxList mounthFilterBox = new UCFilterItemCheckBoxList("Mounth", mouthList);
            UCFilterItemTextBox yearFilterBox = new UCFilterItemTextBox("Year", "Enter year value");
            flpFilter.Controls.Add(searchingBox);
            flpFilter.Controls.Add(dayFilterBox);
            flpFilter.Controls.Add(mounthFilterBox);
            flpFilter.Controls.Add(yearFilterBox);
            this.ActiveControl = label1;
            this.hoaDons = hoaDonDAO.getAllHoaDon();
            reLoadFLP();
        }

        private void reLoadFLP()
        {
            int i = 0;
            foreach(HoaDon hoaDon in this.hoaDons)
            {
                UCInvoiceItem uc = new UCInvoiceItem(hoaDon, i++);
                flpList.Controls.Add(uc);
            }    
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductManage fProductManage = new FProductManage();
            this.Hide();
            fProductManage.ShowDialog();
            this.Show();
        }

    }
}
