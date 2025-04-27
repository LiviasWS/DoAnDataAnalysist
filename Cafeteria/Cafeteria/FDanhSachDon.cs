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
        DonYeuCauDatHangDAO donYeuCauDatHangDAO = new DonYeuCauDatHangDAO();
        DonNhapKhoDAO donNhapKhoDAO = new DonNhapKhoDAO();
        DonXuatKhoDAO donXuatKhoDAO = new DonXuatKhoDAO();
        DSYeuCauDatHangDAO dsYeuCauDatHangDAO = new DSYeuCauDatHangDAO();
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
        }

        private void dGVDonYCNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int t = dGVDonYCNhapHang.CurrentCell.RowIndex;
            if(t == dGVDonYCNhapHang.Rows.Count - 1) return;
            int id = int.Parse(dGVDonYCNhapHang.Rows[t].Cells[0].Value.ToString());
            DataTable dt = dsYeuCauDatHangDAO.GetDSYeuCauDatHangByDon(id);
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
            lblNgayTao.Text = "Ngay Tao Don " + DateTime.Parse(dGVDonXuatKho.Rows[t].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
            lblGhiChu.Text = "Ghi Chu " + dGVDonXuatKho.Rows[t].Cells[3].Value.ToString();
            lblNgayTrienKhai.Text = "Ngay Xuat Kho " + DateTime.Parse(dGVDonXuatKho.Rows[t].Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
            lblTongTien.Visible = false;
            dt.Columns.Remove("MaDonXuatKho");
            dGVDSNguyenLieu.DataSource = dt;
        }

        private void dGVDonNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            int t = dGVDonNhapKho.CurrentCell.RowIndex;
            if (t == dGVDonNhapKho.Rows.Count - 1) return;
            int id = int.Parse(dGVDonNhapKho.Rows[t].Cells[0].Value.ToString());
            DataTable dt = dsNhapKhoDAO.GetDSNhapKhoByDon(id);
            lblNgayTao.Text = "Ngay Tao Don " + DateTime.Parse(dGVDonNhapKho.Rows[t].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
            lblGhiChu.Text = "Ghi Chu " + dGVDonNhapKho.Rows[t].Cells[3].Value.ToString();
            lblNgayTrienKhai.Text = "Ngay Nhap Kho " + DateTime.Parse(dGVDonNhapKho.Rows[t].Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
            lblTongTien.Visible = true;
            lblTongTien.Text = "Tong Tien " + dGVDonNhapKho.Rows[t].Cells[5].Value.ToString() + " VND";
            dt.Columns.Remove("MaDonNhapKho");
            dGVDSNguyenLieu.DataSource = dt;
        }
    }
}
