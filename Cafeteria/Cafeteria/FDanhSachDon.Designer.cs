namespace Cafeteria
{
    partial class FDanhSachDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVDSNguyenLieu = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVDonYCNhapHang = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVDonXuatKho = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGVDonNhapKho = new System.Windows.Forms.DataGridView();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNgayTrienKhai = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNguyenLieu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonYCNhapHang)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonXuatKho)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDSNguyenLieu
            // 
            this.dGVDSNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDSNguyenLieu.Location = new System.Drawing.Point(311, 172);
            this.dGVDSNguyenLieu.Name = "dGVDSNguyenLieu";
            this.dGVDSNguyenLieu.Size = new System.Drawing.Size(421, 266);
            this.dGVDSNguyenLieu.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(286, 441);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVDonYCNhapHang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Don YC Nhap Hang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGVDonYCNhapHang
            // 
            this.dGVDonYCNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDonYCNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dGVDonYCNhapHang.Name = "dGVDonYCNhapHang";
            this.dGVDonYCNhapHang.Size = new System.Drawing.Size(278, 419);
            this.dGVDonYCNhapHang.TabIndex = 0;
            this.dGVDonYCNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDonYCNhapHang_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGVDonXuatKho);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Don Xuat Kho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGVDonXuatKho
            // 
            this.dGVDonXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDonXuatKho.Location = new System.Drawing.Point(0, 0);
            this.dGVDonXuatKho.Name = "dGVDonXuatKho";
            this.dGVDonXuatKho.Size = new System.Drawing.Size(278, 415);
            this.dGVDonXuatKho.TabIndex = 0;
            this.dGVDonXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDonXuatKho_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dGVDonNhapKho);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(278, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Don Nhap Kho";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dGVDonNhapKho
            // 
            this.dGVDonNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDonNhapKho.Location = new System.Drawing.Point(0, 0);
            this.dGVDonNhapKho.Name = "dGVDonNhapKho";
            this.dGVDonNhapKho.Size = new System.Drawing.Size(278, 415);
            this.dGVDonNhapKho.TabIndex = 0;
            this.dGVDonNhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDonNhapKho_CellClick);
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(326, 29);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(35, 13);
            this.lblNgayTao.TabIndex = 5;
            this.lblNgayTao.Text = "label1";
            // 
            // lblNgayTrienKhai
            // 
            this.lblNgayTrienKhai.AutoSize = true;
            this.lblNgayTrienKhai.Location = new System.Drawing.Point(326, 64);
            this.lblNgayTrienKhai.Name = "lblNgayTrienKhai";
            this.lblNgayTrienKhai.Size = new System.Drawing.Size(35, 13);
            this.lblNgayTrienKhai.TabIndex = 6;
            this.lblNgayTrienKhai.Text = "label2";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(326, 100);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(35, 13);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "label3";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(326, 135);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(35, 13);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "label4";
            // 
            // FDanhSachDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblNgayTrienKhai);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dGVDSNguyenLieu);
            this.Name = "FDanhSachDon";
            this.Text = "FDanhSachHDYCNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNguyenLieu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonYCNhapHang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonXuatKho)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDonNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVDSNguyenLieu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dGVDonXuatKho;
        private System.Windows.Forms.DataGridView dGVDonNhapKho;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblNgayTrienKhai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVDonYCNhapHang;
    }
}