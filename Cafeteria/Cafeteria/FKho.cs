using Cafeteria.DAO;
using Cafeteria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FKho : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nLTrongKhoDAO = new NLTrongKhoDAO();
        public FKho()
        {
            InitializeComponent();
            Form_Load();
            Load_Combobox();
        }
        private void Form_Load()
        {
            DataTable dt = nLTrongKhoDAO.GetAllNLTrongKho();
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNL = txtTenNL.Text;
            string soLuong = txtSL.Text;
            string tenQC = cbbQC.Text;
            if(string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(tenQC))
            {
                MessageBox.Show("Vui long nhap du thong tin");
                return;
            }
            if(int.TryParse(soLuong, out int sl) == false)
            {
                MessageBox.Show("So luong phai la so");
                return;
            }
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            if (nguyenLieu is null)
            {
                nguyenLieu = new NguyenLieu();
                nguyenLieu.TenNL = tenNL;
                nguyenLieu.MaNL = nguyenLieuDAO.AddNguyenLieuGetId(nguyenLieu);
            }
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            if(quyCach is null)
            {
                quyCach = new QuyCach();
                quyCach.TenQC = tenQC;
                quyCach.MaQC = quyCachDAO.AddQuyCachGetId(quyCach);
            }
            NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(nguyenLieu, quyCach);
            if (nLTrongKho != null)
            {
                nLTrongKho.SoLuong += int.Parse(soLuong);
                nLTrongKhoDAO.EditNLTrongKho(nLTrongKho);
            }
            else
            {
                nLTrongKho = new NLTrongKho();
                nLTrongKho.NguyenLieu = nguyenLieu;
                nLTrongKho.SoLuong = int.Parse(soLuong);
                nLTrongKho.QuyCach = quyCach;
                nLTrongKhoDAO.AddNLTrongKho(nLTrongKho);
            }
            Form_Load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tenNL = txtTenNL.Text;
            string soLuong = txtSL.Text;
            string tenQC = cbbQC.Text;
            if (string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(tenQC))
            {
                MessageBox.Show("Vui long nhap du thong tin");
                return;
            }
            if (int.TryParse(soLuong, out int sl) == false)
            {
                MessageBox.Show("So luong phai la so");
                return;
            }
            NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(tenNL);
            if (nguyenLieu is null)
            {
                MessageBox.Show("Khong tim thay nguyen lieu");
                return;
            }
            QuyCach quyCach = quyCachDAO.FindByName(tenQC);
            if (quyCach is null)
            {
                MessageBox.Show("Khong tim thay quy cach");
                return;
            }
            NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(nguyenLieu, quyCach);
            if (nLTrongKho is null)
            {
                MessageBox.Show("Chua ton tai trong kho");
                return;
            }
            nLTrongKhoDAO.EditNLTrongKho(nLTrongKho);
            Form_Load();
        }

        private void dGVNLTrongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVNLTrongKho.CurrentCell.RowIndex;
            txtTenNL.Text = dGVNLTrongKho.Rows[t].Cells[0].Value.ToString();
            txtSL.Text = dGVNLTrongKho.Rows[t].Cells[1].Value.ToString();
            cbbQC.Text = dGVNLTrongKho.Rows[t].Cells[2].Value.ToString();
        }
        private void btnList_Click_1(object sender, EventArgs e)
        {
            FDanhSachDon fDanhSachDon = new FDanhSachDon();
            fDanhSachDon.Show();
            this.Hide();
        }
    }
}
