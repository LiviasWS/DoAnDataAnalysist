namespace Cafeteria
{
    partial class UCHoaDonDetailItem
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
            this.pItem = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.SystemColors.Window;
            this.pItem.Controls.Add(this.lblPrice);
            this.pItem.Controls.Add(this.lblQuantity);
            this.pItem.Controls.Add(this.lblTotalPrice);
            this.pItem.Controls.Add(this.lblName);
            this.pItem.Location = new System.Drawing.Point(0, 0);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(408, 50);
            this.pItem.TabIndex = 29;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblQuantity.Location = new System.Drawing.Point(201, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTotalPrice.Location = new System.Drawing.Point(305, 18);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 16);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "TotalCost";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblName.Location = new System.Drawing.Point(28, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(114, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // UCHoaDonDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCHoaDonDetailItem";
            this.Size = new System.Drawing.Size(408, 50);
            this.Load += new System.EventHandler(this.UCHoaDonDetailItem_Load);
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
    }
}
