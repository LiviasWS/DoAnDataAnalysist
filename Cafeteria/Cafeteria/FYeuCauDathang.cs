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
    public partial class FYeuCauDathang : Form
    {
        private DonYeuCauDatHangDAO donYeuCauDatHangDAO = new DonYeuCauDatHangDAO();
        public FYeuCauDathang()
        {
            InitializeComponent();
        }

        private void FYeuCauDathang_Load(object sender, EventArgs e)
        {
            ReloadFilter();
            ReloadFLP();
        }

        private void ReloadFLP()
        {
            flpList.Controls.Clear();
            List<DonYeuCauNhapHang> donYeuCauNhapHangs = donYeuCauDatHangDAO.GetAllDonYeuCauNhapHang();
            int i = 0;
            foreach(DonYeuCauNhapHang donYeuCauNhapHang in donYeuCauNhapHangs)
            {
                UCYeuCauNhapHangItem uc = new UCYeuCauNhapHangItem(donYeuCauNhapHang, i++);
                flpList.Controls.Add(uc);
            }
        }

        private void ReloadFilter()
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
        }

    }
}
