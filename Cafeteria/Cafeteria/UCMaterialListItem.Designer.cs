namespace Cafeteria
{
    partial class UCMaterialListItem
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
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbChoosen = new System.Windows.Forms.CheckBox();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.SystemColors.Window;
            this.pItem.Controls.Add(this.cbChoosen);
            this.pItem.Controls.Add(this.lblQuantity);
            this.pItem.Controls.Add(this.lblUnit);
            this.pItem.Controls.Add(this.lblName);
            this.pItem.Location = new System.Drawing.Point(0, 0);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(600, 40);
            this.pItem.TabIndex = 28;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblQuantity.Location = new System.Drawing.Point(266, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUnit.Location = new System.Drawing.Point(410, 12);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(30, 16);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblName.Location = new System.Drawing.Point(125, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // cbChoosen
            // 
            this.cbChoosen.AutoSize = true;
            this.cbChoosen.Location = new System.Drawing.Point(42, 14);
            this.cbChoosen.Name = "cbChoosen";
            this.cbChoosen.Size = new System.Drawing.Size(15, 14);
            this.cbChoosen.TabIndex = 10;
            this.cbChoosen.UseVisualStyleBackColor = true;
            this.cbChoosen.CheckedChanged += new System.EventHandler(this.cbChoosen_CheckedChanged);
            // 
            // UCMaterialListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMaterialListItem";
            this.Size = new System.Drawing.Size(600, 40);
            this.Load += new System.EventHandler(this.UCMaterialListItem_Load);
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbChoosen;
    }
}
