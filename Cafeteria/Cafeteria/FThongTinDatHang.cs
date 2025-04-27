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
    public partial class FThongTinDatHang : Form
    {
        private List<CTYCDatHang> list;
        public FThongTinDatHang(List<CTYCDatHang> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DonDatHangDAO donDatHangDAO = new DonDatHangDAO();
            NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
            ChiTietDonDatHangDAO chiTietDonDatHangDAO = new ChiTietDonDatHangDAO();
            CTYCDatHangDAO cTYCDatHangDAO = new CTYCDatHangDAO();
            NhaCungCap nhaCungCap = nhaCungCapDAO.GetNhaCungCapByName(cbbNhaCungCap.Text);

            donDatHangDAO.AddDonDatHang(nhaCungCap.MaNCC, DateTime.Now, Convert.ToInt32(txtTongGiaTri.Text),
                Convert.ToDateTime(dtpCompleteDate), txtGhiChu.Text);
            foreach(CTYCDatHang ct in list)
            {
                ChiTietDonDatHang ctDH = new ChiTietDonDatHang();
                ctDH.Maddh = donDatHangDAO.GetIDDonDatHang();
                ctDH.Manl = ct.MaNL;
                ctDH.Soluong = ct.MaNL;
                chiTietDonDatHangDAO.Add_ChiTietDonDatHang(ctDH);
                cTYCDatHangDAO.UpdateTrangThai(ct.MaDonYeuCau, ct.MaNL);
            }
            
        }

        private void FThongTinDatHang_Load(object sender, EventArgs e)
        {
            List<NhaCungCap> nccList = new NhaCungCapDAO().getAllNhaCungCaps();
            foreach(NhaCungCap n in nccList)
            {
                cbbNhaCungCap.Items.Add(n.TenNCC); 
            }
        }
    }
}
