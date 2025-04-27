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
        private DBConnection conn = new DBConnection();
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
            int mancc = nhaCungCap.MaNCC;
            DateTime ngayGiao = DateTime.Now;
            DateTime ngayNhan = dtpCompleteDate.Value;
            NhaCungCap ncc = nhaCungCapDAO.GetNhaCungCapByName(cbbNhaCungCap.Text);
            string sqlCommand1 = "INSERT INTO DonDatHang (MANCC, NGAYTAO, TONGGIATRI, NGAYGIAO, GHICHU) VALUES (" + mancc + ",'" +
                ngayNhan + "', " + txtTongGiaTri.Text + ", '" + ngayGiao + "', '" + txtGhiChu.Text + "')";
            conn.Execute(sqlCommand1);
            foreach (CTYCDatHang ct in list)
            {
                int maNL = ct.MaNL;
                int maQC = ct.MaQC;
                int maDYC = ct.MaDonYeuCau;
                string sqlCommand2 = "EXEC ADD_CHITIET_DONDATHANG @MANL = " + maNL + ", @SOLUONG =" + txtTongGiaTri.Text + ", @MAQC =" + maQC + ", @MADYC = " + maDYC;
                conn.Execute(sqlCommand2);
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
