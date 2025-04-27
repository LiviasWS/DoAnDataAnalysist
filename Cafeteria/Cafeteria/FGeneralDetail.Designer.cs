namespace Cafeteria
{
    partial class FGeneralDetail
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
            this.rtxtTest = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.pItem = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtTest
            // 
            this.rtxtTest.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTest.Location = new System.Drawing.Point(308, 30);
            this.rtxtTest.Name = "rtxtTest";
            this.rtxtTest.Size = new System.Drawing.Size(155, 20);
            this.rtxtTest.TabIndex = 8;
            this.rtxtTest.Text = "";
            this.rtxtTest.TextChanged += new System.EventHandler(this.rtxtTest_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(43, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 48);
            this.panel2.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(3, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.BackColor = System.Drawing.SystemColors.Control;
            this.flpList.Location = new System.Drawing.Point(43, 157);
            this.flpList.Margin = new System.Windows.Forms.Padding(0);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(420, 340);
            this.flpList.TabIndex = 5;
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.Color.SandyBrown;
            this.pItem.Controls.Add(this.lblPrice);
            this.pItem.Controls.Add(this.lblQuantity);
            this.pItem.Controls.Add(this.lblUnit);
            this.pItem.Controls.Add(this.lblName);
            this.pItem.Location = new System.Drawing.Point(43, 109);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(408, 50);
            this.pItem.TabIndex = 30;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Location = new System.Drawing.Point(114, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuantity.Location = new System.Drawing.Point(201, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnit.Location = new System.Drawing.Point(305, 18);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 16);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Total Cost";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(28, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // FGeneralDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 548);
            this.Controls.Add(this.pItem);
            this.Controls.Add(this.rtxtTest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpList);
            this.Name = "FGeneralDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGeneralDetail";
            this.Load += new System.EventHandler(this.FGeneralDetail_Load);
            this.panel2.ResumeLayout(false);
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblName;
    }
}