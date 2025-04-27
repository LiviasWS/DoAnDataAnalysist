namespace Cafeteria
{
    partial class UCYeuCauNhapHangItem
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
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.SystemColors.Control;
            this.pItem.Controls.Add(this.lblOutOfStock);
            this.pItem.Controls.Add(this.lblNote);
            this.pItem.Controls.Add(this.lblCreateDate);
            this.pItem.Location = new System.Drawing.Point(0, 0);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(606, 55);
            this.pItem.TabIndex = 15;
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblOutOfStock.Location = new System.Drawing.Point(418, 19);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(108, 16);
            this.lblOutOfStock.TabIndex = 13;
            this.lblOutOfStock.Text = "Out of stock Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblNote.Location = new System.Drawing.Point(262, 19);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 16);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Note";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCreateDate.Location = new System.Drawing.Point(39, 19);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(79, 16);
            this.lblCreateDate.TabIndex = 10;
            this.lblCreateDate.Text = "Create Date";
            // 
            // UCYeuCauNhapHangItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCYeuCauNhapHangItem";
            this.Size = new System.Drawing.Size(606, 55);
            this.Load += new System.EventHandler(this.UCYeuCauNhapHangItem_Load);
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblCreateDate;
    }
}
