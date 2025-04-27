using Cafeteria.DAO;
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
    public partial class FDatNguyenLieu : Form
    {
        private CTYCDatHangDAO cTYCDatHangDAO = new CTYCDatHangDAO();
        public FDatNguyenLieu()
        {
            InitializeComponent();
        }

        private void FDatNguyenLieu_Load(object sender, EventArgs e)
        {
            List<CTYCDatHang> list = cTYCDatHangDAO.GetAllChuaDat();
            ReloadFLP(list);
        }

        private void ReloadFLP(List<CTYCDatHang> list)
        {
            flpList.Controls.Clear();
            int i = 0;
            foreach(CTYCDatHang ct in list)
            {
                UCDatHangItem uc = new UCDatHangItem(ct, i++);
                flpList.Controls.Add(uc);
            }
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            List<CTYCDatHang> list = new List<CTYCDatHang>();
            foreach(UCDatHangItem uc in flpList.Controls)
            {
                if(uc.GetCheckBoxValue())
                {
                    CTYCDatHang ct = uc.GetCTYCDatHang();
                    list.Add(ct);
                }
            }
            FThongTinDatHang f = new FThongTinDatHang(list);
            f.ShowDialog();
            ReloadFLP(cTYCDatHangDAO.GetAllChuaDat());
        }
    }
}
