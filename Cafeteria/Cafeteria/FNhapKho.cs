using Cafeteria.DAO;
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
        public FNhapKho()
        {
            InitializeComponent();
            Load_DonNhapHang();
            Load_Combobox();
        }
        private void Load_DonNhapHang()
        {

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
        private void Load_DSNhapKho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten Nguyen Lieu");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Quy Cach");
            dt.Columns.Add("Gia Tien");
            dt.Columns.Add("Tong Tien");
            foreach (var item in dSNhapKhos)
            {
                dt.Rows.Add(item.NguyenLieu.TenNL, item.SoLuong, item.QuyCach.TenQC, item.GiaTien, item.GiaTien * item.SoLuong);
            }
            dGVDSNhapKho.DataSource = dt;
        }
        private void dGVDonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVDonNhapHang.CurrentCell.RowIndex;
        }

        private void dGVDSNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int t = dGVDonNhapHang.CurrentCell.RowIndex;
            cbbTenNL.Text = dGVDSNhapKho.Rows[t].Cells[0].Value.ToString();
            txtSoLuong.Text = dGVDSNhapKho.Rows[t].Cells[1].Value.ToString();
            txtGiaTiem.Text = dGVDSNhapKho.Rows[t].Cells[3].Value.ToString();
            cbbQuyCach.Text = dGVDSNhapKho.Rows[t].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            string giaTien = txtGiaTiem.Text;
            if (Check(tenNL, soLuong, tenQC, giaTien) == false) return;
            NguyenLieu nguyenLieu = new NguyenLieu(0,tenNL);
            QuyCach quyCach = new QuyCach(0,tenQC);
            DSNhapKho dSNhapKho = dSNhapKhos.Find(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if (dSNhapKho != null)
            {
                dSNhapKho.SoLuong += int.Parse(soLuong);
                if(dSNhapKho.GiaTien != int.Parse(giaTien))
                {
                    MessageBox.Show("Gia tien khong khop");
                    return;
                }
            }
            else
            {
                dSNhapKho = new DSNhapKho();
                dSNhapKho.NguyenLieu = nguyenLieu;
                dSNhapKho.QuyCach = quyCach;
                dSNhapKho.SoLuong = int.Parse(soLuong);
                dSNhapKho.GiaTien = int.Parse(giaTien);
                dSNhapKhos.Add(dSNhapKho);
            }
            Load_DSNhapKho();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tenNL = cbbTenNL.Text;
            string soLuong = txtSoLuong.Text;
            string tenQC = cbbQuyCach.Text;
            string giaTien = txtGiaTiem.Text;
            if (Check(tenNL, soLuong, tenQC, giaTien) == false) return;
            DSNhapKho dSNhapKho = dSNhapKhos.Find(x => x.NguyenLieu.TenNL == tenNL && x.QuyCach.TenQC == tenQC);
            if(dSNhapKho != null)
            {
                dSNhapKho.SoLuong = int.Parse(soLuong);
                dSNhapKho.GiaTien = int.Parse(giaTien);
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
            string giaTien = txtGiaTiem.Text;
            if (Check(tenNL, soLuong, tenQC, giaTien) == false) return;
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
        private bool Check(string tenNL, string soLuong, string tenQC, string giaTien)
        {
            if (string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(tenQC) || string.IsNullOrEmpty(giaTien))
            {
                MessageBox.Show("Vui long nhap du thong tin");
                return false;
            }
            if (int.TryParse(soLuong, out int sl) == false)
            {
                MessageBox.Show("So luong phai la so");
                return false;
            }
            if (int.TryParse(giaTien, out int gt) == false)
            {
                MessageBox.Show("Gia tien phai la so");
                return false;
            }
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DonNhapKho donNhapKho = new DonNhapKho(DateTime.Now, 2, txtGhiChu.Text, dateTimePicker1.Value, 0);
            donNhapKho.MaDonNhapKho = donNhapKhoDAO.AddDonNhapKhoGetId(donNhapKho);
            int tongtien = 0;
            foreach (DSNhapKho item in dSNhapKhos)
            {
                item.DonNhapKho = donNhapKho;
                NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(item.NguyenLieu, item.QuyCach);
                if(nLTrongKho != null)
                {
                    nLTrongKho.SoLuong += item.SoLuong;
                    nLTrongKhoDAO.EditNLTrongKho(nLTrongKho);
                }
                else
                {
                    NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(item.NguyenLieu.TenNL);
                    if(nguyenLieu == null)
                    {
                        nguyenLieu = new NguyenLieu();
                        nguyenLieu.TenNL = item.NguyenLieu.TenNL;
                        nguyenLieu.MaNL = nguyenLieuDAO.AddNguyenLieuGetId(nguyenLieu);
                    }
                    QuyCach quyCach = quyCachDAO.FindByName(item.QuyCach.TenQC);
                    if (quyCach == null)
                    {
                        quyCach = new QuyCach();
                        quyCach.TenQC = item.QuyCach.TenQC;
                        quyCach.MaQC = quyCachDAO.AddQuyCachGetId(quyCach);
                    }
                    nLTrongKho = new NLTrongKho();
                    nLTrongKho.NguyenLieu = nguyenLieu;
                    nLTrongKho.SoLuong = item.SoLuong;
                    nLTrongKho.QuyCach = quyCach;
                    nLTrongKhoDAO.AddNLTrongKho(nLTrongKho);
                    item.NguyenLieu = nguyenLieu;
                    item.QuyCach = quyCach;
                }
                dSNhapKhoDAO.AddDSNhapKho(item);
                tongtien += item.GiaTien * item.SoLuong;
                donNhapKho.TongGiaTri = tongtien;
            }
            donNhapKhoDAO.EditDonNhapKho(donNhapKho);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FDanhSachDon fDanhSachDon = new FDanhSachDon();
            fDanhSachDon.ShowDialog();
        }
    }
}
