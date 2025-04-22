namespace Cafeteria
{
    partial class UCQuantity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucLbTenSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCbSoLuong = new System.Windows.Forms.ComboBox();
            this.ucLbGiaTien = new System.Windows.Forms.Label();
            this.ucLbMaSP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.ucLbTenSP);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 71);
            this.panel2.TabIndex = 18;
            // 
            // ucLbTenSP
            // 
            this.ucLbTenSP.AutoSize = true;
            this.ucLbTenSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLbTenSP.ForeColor = System.Drawing.Color.White;
            this.ucLbTenSP.Location = new System.Drawing.Point(120, 21);
            this.ucLbTenSP.Name = "ucLbTenSP";
            this.ucLbTenSP.Size = new System.Drawing.Size(149, 31);
            this.ucLbTenSP.TabIndex = 5;
            this.ucLbTenSP.Text = "Matcha latte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã sản phẩm";
            // 
            // ucCbSoLuong
            // 
            this.ucCbSoLuong.FormattingEnabled = true;
            this.ucCbSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ucCbSoLuong.Location = new System.Drawing.Point(245, 182);
            this.ucCbSoLuong.Name = "ucCbSoLuong";
            this.ucCbSoLuong.Size = new System.Drawing.Size(38, 24);
            this.ucCbSoLuong.TabIndex = 16;
            this.ucCbSoLuong.Text = "1";
            // 
            // ucLbGiaTien
            // 
            this.ucLbGiaTien.AutoSize = true;
            this.ucLbGiaTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLbGiaTien.Location = new System.Drawing.Point(241, 145);
            this.ucLbGiaTien.Name = "ucLbGiaTien";
            this.ucLbGiaTien.Size = new System.Drawing.Size(64, 20);
            this.ucLbGiaTien.TabIndex = 15;
            this.ucLbGiaTien.Text = "hiện giá";
            // 
            // ucLbMaSP
            // 
            this.ucLbMaSP.AutoSize = true;
            this.ucLbMaSP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLbMaSP.Location = new System.Drawing.Point(241, 104);
            this.ucLbMaSP.Name = "ucLbMaSP";
            this.ucLbMaSP.Size = new System.Drawing.Size(64, 20);
            this.ucLbMaSP.TabIndex = 14;
            this.ucLbMaSP.Text = "hiện mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng";
            // 
            // UCQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucCbSoLuong);
            this.Controls.Add(this.ucLbGiaTien);
            this.Controls.Add(this.ucLbMaSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "UCQuantity";
            this.Size = new System.Drawing.Size(394, 238);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ucLbTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ucCbSoLuong;
        private System.Windows.Forms.Label ucLbGiaTien;
        private System.Windows.Forms.Label ucLbMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
