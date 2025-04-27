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
    public partial class UCDatHangItem : UserControl
    {
        private CTYCDatHang ct;
        int count;
        private NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        private QuyCachDAO quyCachDAO = new QuyCachDAO();
        public UCDatHangItem(CTYCDatHang ct, int count)
        {
            InitializeComponent();
            this.ct = ct;
            this.count = count;
        }

        private void UCDatHangItem_Load(object sender, EventArgs e)
        {
            if ((this.count % 2) == 0)
            {
                pItem.BackColor = Color.White;
            }
            else
            {
                pItem.BackColor = Color.WhiteSmoke;
            }
            QuyCach quyCach = quyCachDAO.GetQuyCachByID(ct.MaQC);
            NguyenLieu nguyenLieu = nguyenLieuDAO.GetNguyenLieuById(ct.MaNL);
            lblName.Text = nguyenLieu.TenNL;
            lblQuantity.Text = ct.SoLuong.ToString();
            lblUnit.Text = quyCach.TenQC.ToString();
        }

        public CTYCDatHang GetCTYCDatHang()
        {
            return ct;
        }

        public bool GetCheckBoxValue()
        {
            if (cbChoosen.Checked)
                return true;
            else return false;
        }

    }
}
