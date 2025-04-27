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

    public partial class FYeuCauNhapHang : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nLTrongKhoDAO = new NLTrongKhoDAO();
        List<DSYeuCauNhapHang> yeuCauNhapHangs = new List<DSYeuCauNhapHang>();
        DSYeuCauNhapHangDAO dsYeuCauDatHangDAO = new DSYeuCauNhapHangDAO();
        DonYeuCauNhapHang donYeuCauDatHang = new DonYeuCauNhapHang();
        DonYeuCauNhapHangDAO donYeuCauDatHangDAO = new DonYeuCauNhapHangDAO();
        DataTable dtsearch = new DataTable();
        public FYeuCauNhapHang()
        {
            InitializeComponent();
            Form_Load();
            Load_Combobox();
            Load_DSYeuCau();
        }
        private void Form_Load()
        {
            DataTable dt = nLTrongKhoDAO.GetAllNLTrongKho();
            dtsearch = dt;
            dGVNLTrongKho.DataSource = dt;
        }
        private void Load_Combobox()
        {
            DataTable dt = quyCachDAO.GetAllQuyCach();
            foreach (DataRow item in dt.Rows)
            {
                string tenQC = item["TenQC"].ToString();
                cbbQC.Items.Add(tenQC);
            }
            dt = nguyenLieuDAO.GetAllNguyenLieu();
            foreach (DataRow item in dt.Rows)
            {
                string tenNL = item["TenNL"].ToString();
                cbbTenNL.Items.Add(tenNL);
            }
        }
        private void Load_DSYeuCau()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten Nguyen Lieu");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Quy Cach");
            foreach(var item in yeuCauNhapHangs)
            {
                dt.Rows.Add(item.NguyenLieu.TenNL, item.SoLuong, item.QuyCach.TenQC);
            }
            dGVYCNhapHang.DataSource = dt;
        }
        private void dGVNLTrongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVNLTrongKho.CurrentCell.RowIndex;
            cbbTenNL.Text = dGVNLTrongKho.Rows[t].Cells[0].Value.ToString();
            cbbQC.Text = dGVNLTrongKho.Rows[t].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQC.Text;
            if(Check(tenNL, soLuong, tenQC) == false) return;
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            DSYeuCauNhapHang yeuCauNhapHang = yeuCauNhapHangs.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (yeuCauNhapHang != null)
            {
                yeuCauNhapHang.SoLuong += int.Parse(soLuong);
            }
            else
            {
                yeuCauNhapHang = new DSYeuCauNhapHang();
                yeuCauNhapHang.NguyenLieu = nguyenLieu;
                yeuCauNhapHang.SoLuong = int.Parse(soLuong);
                yeuCauNhapHang.QuyCach = quyCach;
                yeuCauNhapHangs.Add(yeuCauNhapHang);
            }
            Load_DSYeuCau();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQC.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            DSYeuCauNhapHang yeuCauNhapHang = yeuCauNhapHangs.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (yeuCauNhapHang != null)
            {
                yeuCauNhapHang.SoLuong = int.Parse(soLuong);
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach yeu cau");
                return;
            }
            Load_DSYeuCau();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQC.Text;
            if(Check(tenNL, soLuong, tenQC) == false) return;
            DSYeuCauNhapHang yeuCauNhapHang = yeuCauNhapHangs.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (yeuCauNhapHang != null)
            {
                yeuCauNhapHangs.Remove(yeuCauNhapHang);
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach yeu cau");
            }
            Load_DSYeuCau();
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
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            if (nguyenLieu is null)
            {
                MessageBox.Show("Nguyen lieu khong ton tai");
                return false;
            }
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            if (quyCach is null)
            {
                MessageBox.Show("Quy cach khong ton tai");
                return false;
            }
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            donYeuCauDatHang = new DonYeuCauNhapHang(DateTime.Now, 2, txtGhiChu.Text, dateTimePicker1.Value);
            donYeuCauDatHang.MaDonYeuCau = donYeuCauDatHangDAO.AddDonYeuCauDatHangGetId(donYeuCauDatHang);
            foreach (DSYeuCauNhapHang item in yeuCauNhapHangs)
            {
                item.DonYeuCauDatHang = donYeuCauDatHang;
                dsYeuCauDatHangDAO.AddDSYeuCauDatHang(item);
            }
            MessageBox.Show("Da gui yeu cau dat hang thanh cong");
        }

        private void dGVYCNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVYCNhapHang.CurrentCell.RowIndex;
            cbbTenNL.Text = dGVYCNhapHang.Rows[t].Cells[0].Value.ToString();
            txtSoLuong.Text = dGVYCNhapHang.Rows[t].Cells[1].Value.ToString();
            cbbQC.Text = dGVYCNhapHang.Rows[t].Cells[2].Value.ToString();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = dtsearch.AsEnumerable()
                .Where(row => row.Field<string>("TenNL").ToLower().Contains(keyword));
            if (filtered.Any())
                dGVNLTrongKho.DataSource = filtered.CopyToDataTable();
            else
                dGVNLTrongKho.DataSource = null;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FDanhSachDon fDanhSachDon = new FDanhSachDon();
            fDanhSachDon.ShowDialog();
        }
    }
}
