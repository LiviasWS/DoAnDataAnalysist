namespace Cafeteria
{
    partial class UCSupplierListItem
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.cbChoosen = new System.Windows.Forms.CheckBox();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.SystemColors.Window;
            this.pItem.Controls.Add(this.cbChoosen);
            this.pItem.Controls.Add(this.lblPhoneNumber);
            this.pItem.Controls.Add(this.lblAddress);
            this.pItem.Controls.Add(this.lblDescription);
            this.pItem.Controls.Add(this.lblName);
            this.pItem.Location = new System.Drawing.Point(0, 0);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(600, 40);
            this.pItem.TabIndex = 39;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblAddress.Location = new System.Drawing.Point(315, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDescription.Location = new System.Drawing.Point(439, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblName.Location = new System.Drawing.Point(56, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(158, 12);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // cbChoosen
            // 
            this.cbChoosen.AutoSize = true;
            this.cbChoosen.Location = new System.Drawing.Point(16, 14);
            this.cbChoosen.Name = "cbChoosen";
            this.cbChoosen.Size = new System.Drawing.Size(15, 14);
            this.cbChoosen.TabIndex = 14;
            this.cbChoosen.UseVisualStyleBackColor = true;
            // 
            // UCSupplierListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSupplierListItem";
            this.Size = new System.Drawing.Size(600, 40);
            this.Load += new System.EventHandler(this.UCSupplierListItem_Load);
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.CheckBox cbChoosen;
    }
}
