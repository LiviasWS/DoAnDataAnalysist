namespace Cafeteria
{
    partial class FSaleDashboard
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msItemSale = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemSaleOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.msMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemMaterialList = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.pButtonList = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.materialRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemMakeOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.Color.Peru;
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSale,
            this.msMaterial,
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.msMainMenu.Size = new System.Drawing.Size(884, 40);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msItemSale
            // 
            this.msItemSale.AutoSize = false;
            this.msItemSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSaleOverview});
            this.msItemSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msItemSale.ForeColor = System.Drawing.SystemColors.Window;
            this.msItemSale.Name = "msItemSale";
            this.msItemSale.Size = new System.Drawing.Size(122, 36);
            this.msItemSale.Text = "Sale";
            this.msItemSale.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // msItemSaleOverview
            // 
            this.msItemSaleOverview.Name = "msItemSaleOverview";
            this.msItemSaleOverview.Size = new System.Drawing.Size(163, 22);
            this.msItemSaleOverview.Text = "Sale Overview";
            this.msItemSaleOverview.Click += new System.EventHandler(this.msItemSaleOverview_Click);
            // 
            // msMaterial
            // 
            this.msMaterial.AutoSize = false;
            this.msMaterial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemMaterialList,
            this.materialRequestToolStripMenuItem,
            this.msItemMakeOrder});
            this.msMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMaterial.ForeColor = System.Drawing.SystemColors.Window;
            this.msMaterial.Name = "msMaterial";
            this.msMaterial.Size = new System.Drawing.Size(110, 36);
            this.msMaterial.Text = "Material";
            // 
            // msItemMaterialList
            // 
            this.msItemMaterialList.Name = "msItemMaterialList";
            this.msItemMaterialList.Size = new System.Drawing.Size(180, 22);
            this.msItemMaterialList.Text = "Material List";
            this.msItemMaterialList.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.msItemMaterialList.Click += new System.EventHandler(this.msItemMaterialList_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.AutoSize = false;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemProductList});
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // msItemProductList
            // 
            this.msItemProductList.Name = "msItemProductList";
            this.msItemProductList.Size = new System.Drawing.Size(180, 22);
            this.msItemProductList.Text = "Product List";
            this.msItemProductList.Click += new System.EventHandler(this.msItemProductList_Click);
            // 
            // pButtonList
            // 
            this.pButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pButtonList.Location = new System.Drawing.Point(247, 107);
            this.pButtonList.Name = "pButtonList";
            this.pButtonList.Size = new System.Drawing.Size(612, 10);
            this.pButtonList.TabIndex = 2;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.SystemColors.Control;
            this.flpFilter.Location = new System.Drawing.Point(25, 71);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(189, 570);
            this.flpFilter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(247, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 19);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(243, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sale Overvirew";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(247, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 55);
            this.panel2.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Location = new System.Drawing.Point(531, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Total";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNote.Location = new System.Drawing.Point(404, 19);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 16);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Note";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPaymentMethod.Location = new System.Drawing.Point(208, 19);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(122, 16);
            this.lblPaymentMethod.TabIndex = 11;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(39, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // flpList
            // 
            this.flpList.Location = new System.Drawing.Point(247, 201);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(612, 413);
            this.flpList.TabIndex = 8;
            // 
            // materialRequestToolStripMenuItem
            // 
            this.materialRequestToolStripMenuItem.Name = "materialRequestToolStripMenuItem";
            this.materialRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialRequestToolStripMenuItem.Text = "Material Request";
            this.materialRequestToolStripMenuItem.Click += new System.EventHandler(this.materialRequestToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.AutoSize = false;
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSupplierList});
            this.supplierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // msItemSupplierList
            // 
            this.msItemSupplierList.Name = "msItemSupplierList";
            this.msItemSupplierList.Size = new System.Drawing.Size(180, 22);
            this.msItemSupplierList.Text = "Supplier List";
            this.msItemSupplierList.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // msItemMakeOrder
            // 
            this.msItemMakeOrder.Name = "msItemMakeOrder";
            this.msItemMakeOrder.Size = new System.Drawing.Size(180, 22);
            this.msItemMakeOrder.Text = "Make Order";
            this.msItemMakeOrder.Click += new System.EventHandler(this.makeỎderToolStripMenuItem_Click);
            // 
            // FSaleDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pButtonList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpFilter);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FSaleDashboard";
            this.Load += new System.EventHandler(this.FSaleDashboard_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msItemSale;
        private System.Windows.Forms.Panel pButtonList;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem msMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem msItemSaleOverview;
        private System.Windows.Forms.ToolStripMenuItem msItemMaterialList;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msItemProductList;
        private System.Windows.Forms.ToolStripMenuItem materialRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msItemSupplierList;
        private System.Windows.Forms.ToolStripMenuItem msItemMakeOrder;
    }
}