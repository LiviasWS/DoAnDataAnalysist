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
using System.Web;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FNhapKho : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nLTrongKhoDAO = new NLTrongKhoDAO();
        List<DSNhapKho> dSNhapKhos = new List<DSNhapKho>();
        DonNhapKhoDAO donNhapKhoDAO = new DonNhapKhoDAO();
        DSNhapKhoDAO dSNhapKhoDAO  = new DSNhapKhoDAO();
        DonDatHangDAO donDatHangDAO = new DonDatHangDAO();
        ChiTietDonDatHangDAO chiTietDonDatHangDAO = new ChiTietDonDatHangDAO();
        int id = 0;
        int tongtien = 0;
        public FNhapKho()
        {
            InitializeComponent();
            Load_DonDatHang();
            Load_Combobox();
            Load_DSNhapKho();
        }
        private void Load()
        {
            DataTable dt = new DataTable();
            dGVDSNhapKho.DataSource = dt;
        }
        private void Load_DonDatHang()
        {
            DataTable dt = donDatHangDAO.GetAllDonDatHang();
            dGVDonDatHang.DataSource = dt;
        }
        private void Load_DSNhapKho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten Nguyen Lieu");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Quy Cach");
            foreach (var item in dSNhapKhos)
            {
                dt.Rows.Add(item.NguyenLieu.TenNL, item.SoLuong, item.QuyCach.TenQC);
            }
            dGVDSNhapKho.DataSource = dt;
        }
        private void Load_Combobox()
        {
            DataTable dt = quyCachDAO.GetAllQuyCach();
            foreach (DataRow item in dt.Rows)
            {
                string tenQC = item["TenQC"].ToString();
                cbbQuyCach.Items.Add(tenQC);
            }
            dt = nguyenLieuDAO.GetAllNguyenLieu();
            foreach (DataRow item in dt.Rows)
            {
                string tenNL = item["TenNL"].ToString();
                cbbTenNL.Items.Add(tenNL);
            }
            
        }
        private void dGVDonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load();
            if (e.RowIndex == -1) return;
            int t = dGVDonDatHang.CurrentCell.RowIndex;
            if (t == dGVDonDatHang.Rows.Count - 1) return;
            id = int.Parse(dGVDonDatHang.Rows[t].Cells[0].Value.ToString());
            tongtien = int.Parse(dGVDonDatHang.Rows[t].Cells[3].Value.ToString());
            txtTongTien.Text = tongtien.ToString();
            DataTable dt = chiTietDonDatHangDAO.GetChiTietDonDatHangByDon(id);
            dt.Columns.Remove("MaDonDatHang");
            dSNhapKhos = new List<DSNhapKho>();
            foreach (DataRow item in dt.Rows)
            {
                DSNhapKho dSNhapKho = new DSNhapKho();
                dSNhapKho.NguyenLieu = nguyenLieuDAO.FindByName(item["TenNL"].ToString());
                dSNhapKho.SoLuong = int.Parse(item["SoLuong"].ToString());
                dSNhapKho.QuyCach = quyCachDAO.FindByName(item["TenQC"].ToString());
                dSNhapKhos.Add(dSNhapKho);
            }
            Load_DSNhapKho();
        }

        private void dGVDSNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVDSNhapKho.CurrentCell.RowIndex;
            if (t == dGVDonDatHang.Rows.Count - 1) return;
            cbbTenNL.Text = dGVDSNhapKho.Rows[t].Cells[0].Value.ToString();
            txtSoLuong.Text = dGVDSNhapKho.Rows[t].Cells[1].Value.ToString();
            cbbQuyCach.Text = dGVDSNhapKho.Rows[t].Cells[2].Value.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            DSNhapKho dSNhapKho = dSNhapKhos.Find(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if(dSNhapKho != null)
            {
                if(dSNhapKho.SoLuong < int.Parse(soLuong))
                {
                    MessageBox.Show("So luong vuot qua don dat hang");
                    return;
                }
                dSNhapKho.SoLuong = int.Parse(soLuong);
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach nhap kho");
                return;
            }
            Load_DSNhapKho();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            DSNhapKho dSNhapKho = dSNhapKhos.Find(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (dSNhapKho != null)
            {
                dSNhapKhos.Remove(dSNhapKho);
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach nhap kho");
                return;
            }
            Load_DSNhapKho();
        }
        private bool Check(string tenNL, string soLuong, string tenQC)
        {
            if (string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(tenQC))
            {
                MessageBox.Show("Vui long nhap du thong tin");
                return false;
            }
            if (int.TryParse(soLuong, out int sl) == false)
            {
                MessageBox.Show("So luong phai la so");
                return false;
            }
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach(DSNhapKho item in dSNhapKhos)
            {
                NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(item.NguyenLieu, item.QuyCach);
                if(nLTrongKho == null)
                {
                    MessageBox.Show("Cach luu nguyen lieu khong ton tai trong kho, vui long them vao truoc khi nhap kho");
                    return;
                }
            }
            DonNhapKho donNhapKho = new DonNhapKho(DateTime.Now, 2, txtGhiChu.Text, dateTimePicker1.Value, 0);
            donNhapKho.MaDonDatHang = id;
            donNhapKho.MaDonNhapKho = donNhapKhoDAO.AddDonNhapKhoGetId(donNhapKho);
            foreach (DSNhapKho item in dSNhapKhos)
            {
                item.DonNhapKho = donNhapKho;
                NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(item.NguyenLieu, item.QuyCach);
                if(nLTrongKho != null)
                {
                    nLTrongKho.SoLuong += item.SoLuong;
                    nLTrongKhoDAO.EditNLTrongKho(nLTrongKho);
                }
                dSNhapKhoDAO.AddDSNhapKho(item);
            }
            donNhapKho.TongGiaTri = int.Parse(txtTongTien.Text);
            donNhapKhoDAO.EditDonNhapKho(donNhapKho);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FDanhSachDon fDanhSachDon = new FDanhSachDon();
            fDanhSachDon.ShowDialog();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            string tien = txtTongTien.Text;
            if (string.IsNullOrEmpty(tien))
            {
                txtTongTien.Text = "0";
                return;
            }
            if (!int.TryParse(tien, out int giatien))
            {
                MessageBox.Show("Vui long nhap so tien hop le");
                return;
            }
            if (giatien > tongtien)
            {
                MessageBox.Show("So tien vuot qua so tien trong don dat hang");
                return;
            }
            txtTongTien.Text = giatien.ToString();

        }
    }
}
