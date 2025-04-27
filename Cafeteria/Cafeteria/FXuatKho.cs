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

    public partial class FXuatKho : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nLTrongKhoDAO = new NLTrongKhoDAO();
        List<DSXuatKho> dSXuatKhos = new List<DSXuatKho>();
        DSXuatKhoDAO dSXuatKhoDAO = new DSXuatKhoDAO();
        DonXuatKhoDAO donXuatKhoDAO = new DonXuatKhoDAO();
        DataTable dtsearch = new DataTable();
        public FXuatKho()
        {
            InitializeComponent();
            Load_Combobox();
            Form_Load();
            Load_DSXuatKho();
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
                cbbQuyCach.Items.Add(tenQC);
            }
            dt = nguyenLieuDAO.GetAllNguyenLieu();
            foreach (DataRow item in dt.Rows)
            {
                string tenNL = item["TenNL"].ToString();
                comboBox1.Items.Add(tenNL);
            }
        }
        private void Load_DSXuatKho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten Nguyen Lieu");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Quy Cach");
            foreach (var item in dSXuatKhos)
            {
                dt.Rows.Add(item.NguyenLieu.TenNL, item.SoLuong, item.QuyCach.TenQC);
            }
            dGVDSXuatKho.DataSource = dt;
        }
        private void dGVNLTrongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVNLTrongKho.CurrentCell.RowIndex;
            comboBox1.Text = dGVNLTrongKho.Rows[t].Cells[0].Value.ToString();
            cbbQuyCach.Text = dGVNLTrongKho.Rows[t].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNL = comboBox1.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            DSXuatKho dSXuatKho = dSXuatKhos.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(nguyenLieu, quyCach);
            if (dSXuatKho != null)
            {
                dSXuatKho.SoLuong += int.Parse(soLuong);
                if (nLTrongKho.SoLuong < dSXuatKho.SoLuong)
                {
                    MessageBox.Show("So luong trong kho khong du");
                    return;
                }
            }
            else
            {
                dSXuatKho = new DSXuatKho();
                dSXuatKho.NguyenLieu = nguyenLieu;
                dSXuatKho.QuyCach = quyCach;
                dSXuatKho.SoLuong = int.Parse(soLuong);
                if (nLTrongKho.SoLuong < dSXuatKho.SoLuong)
                {
                    MessageBox.Show("So luong trong kho khong du");
                    return;
                }
                dSXuatKhos.Add(dSXuatKho);
            }
            Load_DSXuatKho();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tenNL = comboBox1.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            DSXuatKho dSXuatKho = dSXuatKhos.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(nguyenLieu, quyCach);
            if (dSXuatKho != null)
            {
                dSXuatKho.SoLuong = int.Parse(soLuong);
                if(nLTrongKho.SoLuong < dSXuatKho.SoLuong)
                {
                    MessageBox.Show("So luong trong kho khong du");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach xuat kho");
                return;
            }
            Load_DSXuatKho();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string tenNL = comboBox1.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            if (Check(tenNL, soLuong, tenQC) == false) return;
            DSXuatKho dSXuatKho = dSXuatKhos.FirstOrDefault(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (dSXuatKho != null)
            {
                dSXuatKhos.Remove(dSXuatKho);
            }
            else
            {
                MessageBox.Show("Nguyen lieu khong ton tai trong danh sach xuat kho");
                return;
            }
            Load_DSXuatKho();
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
            DonXuatKho donXuatKho = new DonXuatKho(DateTime.Now, 2, txtGhiChu.Text, dateTimePicker1.Value);
            donXuatKho.MaDonXuatKho = donXuatKhoDAO.AddDonXuatKhoGetId(donXuatKho);
            foreach (DSXuatKho item in dSXuatKhos)
            {
                item.DonXuatKho = donXuatKho;
                dSXuatKhoDAO.AddDSXuatKho(item);
            }
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
