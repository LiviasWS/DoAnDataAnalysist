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
    public partial class FDanhSachDon : Form
    {
        NguyenLieuDAO nguyenLieuDAO = new NguyenLieuDAO();
        QuyCachDAO quyCachDAO = new QuyCachDAO();
        NLTrongKhoDAO nLTrongKhoDAO = new NLTrongKhoDAO();
        DonYeuCauNhapHangDAO donYeuCauDatHangDAO = new DonYeuCauNhapHangDAO();
        DonNhapKhoDAO donNhapKhoDAO = new DonNhapKhoDAO();
        DonXuatKhoDAO donXuatKhoDAO = new DonXuatKhoDAO();
        DSYeuCauNhapHangDAO dsYeuCauDatHangDAO = new DSYeuCauNhapHangDAO();
        DSXuatKhoDAO dsXuatKhoDAO = new DSXuatKhoDAO();
        DSNhapKhoDAO dsNhapKhoDAO = new DSNhapKhoDAO();
        public FDanhSachDon()
        {
            InitializeComponent();

            Form_Load();
        }
        private void Form_Load()
        {
            DataTable dt = donYeuCauDatHangDAO.GetAllDonYeuCauDatHang();
            dGVDonYCNhapHang.DataSource = dt;
            dt = donNhapKhoDAO.GetAllDonNhapKho();
            dGVDonNhapKho.DataSource = dt;
            dt = donXuatKhoDAO.GetAllDonXuatKho();
            dGVDonXuatKho.DataSource = dt;
            btnXacNhan.Visible = false;
        }

        private void dGVDonYCNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int t = dGVDonYCNhapHang.CurrentCell.RowIndex;
            if(t == dGVDonYCNhapHang.Rows.Count - 1) return;
            int id = int.Parse(dGVDonYCNhapHang.Rows[t].Cells[0].Value.ToString());
            DataTable dt = dsYeuCauDatHangDAO.GetDSYeuCauDatHangByDon(id);
            lblId.Text = dGVDonYCNhapHang.Rows[t].Cells[0].Value.ToString();
            lblNgayTao.Text = "Ngay Tao Don " + DateTime.Parse(dGVDonYCNhapHang.Rows[t].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
            lblGhiChu.Text = "Ghi Chu " + dGVDonYCNhapHang.Rows[t].Cells[3].Value.ToString();
            lblNgayTrienKhai.Text = "Ngay Du Kien Het Hang " + DateTime.Parse(dGVDonYCNhapHang.Rows[t].Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
            lblTongTien.Visible = false;
            dt.Columns.Remove("MaDonYeuCau");
            dGVDSNguyenLieu.DataSource = dt;
        }

        private void dGVDonXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int t = dGVDonXuatKho.CurrentCell.RowIndex;
            if (t == dGVDonXuatKho.Rows.Count - 1) return;
            int id = int.Parse(dGVDonXuatKho.Rows[t].Cells[0].Value.ToString());
            DataTable dt = dsXuatKhoDAO.GetDSXuatKhoByDon(id);
            lblId.Text = dGVDonXuatKho.Rows[t].Cells[0].Value.ToString();
            lblNgayTao.Text = "Ngay Tao Don " + DateTime.Parse(dGVDonXuatKho.Rows[t].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
            lblGhiChu.Text = "Ghi Chu " + dGVDonXuatKho.Rows[t].Cells[3].Value.ToString();
            lblNgayTrienKhai.Text = "Ngay Xuat Kho " + DateTime.Parse(dGVDonXuatKho.Rows[t].Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
            lblTongTien.Visible = false;
            dt.Columns.Remove("MaDonXuatKho");
            if(dGVDonXuatKho.Rows[t].Cells[5].Value.ToString() == "True")
            {
                btnXacNhan.Visible = false;
            }
            else
            {
                btnXacNhan.Visible = true;
            }
            dGVDSNguyenLieu.DataSource = dt;
        }

        private void dGVDonNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            int t = dGVDonNhapKho.CurrentCell.RowIndex;
            if (t == dGVDonNhapKho.Rows.Count - 1) return;
            int id = int.Parse(dGVDonNhapKho.Rows[t].Cells[0].Value.ToString());
            DataTable dt = dsNhapKhoDAO.GetDSNhapKhoByDon(id);
            lblId.Text = dGVDonNhapKho.Rows[t].Cells[0].Value.ToString();
            lblNgayTao.Text = "Ngay Tao Don " + DateTime.Parse(dGVDonNhapKho.Rows[t].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
            lblGhiChu.Text = "Ghi Chu " + dGVDonNhapKho.Rows[t].Cells[3].Value.ToString();
            lblNgayTrienKhai.Text = "Ngay Nhap Kho " + DateTime.Parse(dGVDonNhapKho.Rows[t].Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
            lblTongTien.Visible = true;
            lblTongTien.Text = "Tong Tien " + dGVDonNhapKho.Rows[t].Cells[5].Value.ToString() + " VND";
            dt.Columns.Remove("MaDonNhapKho");
            dGVDSNguyenLieu.DataSource = dt;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            DonXuatKho donXuatKho = donXuatKhoDAO.FindById(id);
            donXuatKho.TrangThai = true;
            donXuatKhoDAO.EditDonXuatKho(donXuatKho);
            DataTable dt = dsXuatKhoDAO.GetDSXuatKhoByDon(id);
            foreach (DataRow item in dt.Rows)
            {
                NguyenLieu nguyenLieu = nguyenLieuDAO.FindByName(item["TenNL"].ToString());
                int soLuong = int.Parse(item["SoLuong"].ToString());
                QuyCach quyCach = quyCachDAO.FindByName(item["TenQC"].ToString());
                NLTrongKho nLTrongKho = nLTrongKhoDAO.FindNLTrongKho(nguyenLieu, quyCach);
                if (nLTrongKho != null)
                {
                    nLTrongKho.SoLuong -= soLuong;
                    nLTrongKhoDAO.EditNLTrongKho(nLTrongKho);
                }
                else
                {
                    MessageBox.Show("Nguyen lieu khong ton tai trong kho");
                    return;
                }
            }
            Form_Load();
        }
    }
}
