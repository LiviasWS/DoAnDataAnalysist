namespace Cafeteria
{
    partial class FYeuCauDathang
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
            this.materialRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.pButtonList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemMaterialList = new System.Windows.Forms.ToolStripMenuItem();
            this.msMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemSaleOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemSale = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.pItem = new System.Windows.Forms.Panel();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.pItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRequestToolStripMenuItem
            // 
            this.materialRequestToolStripMenuItem.Name = "materialRequestToolStripMenuItem";
            this.materialRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialRequestToolStripMenuItem.Text = "Material Request";
            // 
            // flpList
            // 
            this.flpList.Location = new System.Drawing.Point(247, 204);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(612, 413);
            this.flpList.TabIndex = 15;
            // 
            // pButtonList
            // 
            this.pButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pButtonList.Location = new System.Drawing.Point(247, 110);
            this.pButtonList.Name = "pButtonList";
            this.pButtonList.Size = new System.Drawing.Size(612, 10);
            this.pButtonList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(243, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Material Request ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(247, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 19);
            this.panel1.TabIndex = 12;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.SystemColors.Control;
            this.flpFilter.Location = new System.Drawing.Point(25, 74);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(189, 570);
            this.flpFilter.TabIndex = 11;
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
            this.msItemProductList.Size = new System.Drawing.Size(150, 22);
            this.msItemProductList.Text = "Product List";
            // 
            // msItemMaterialList
            // 
            this.msItemMaterialList.Name = "msItemMaterialList";
            this.msItemMaterialList.Size = new System.Drawing.Size(180, 22);
            this.msItemMaterialList.Text = "Material List";
            this.msItemMaterialList.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // msMaterial
            // 
            this.msMaterial.AutoSize = false;
            this.msMaterial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemMaterialList,
            this.materialRequestToolStripMenuItem});
            this.msMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMaterial.ForeColor = System.Drawing.SystemColors.Window;
            this.msMaterial.Name = "msMaterial";
            this.msMaterial.Size = new System.Drawing.Size(122, 36);
            this.msMaterial.Text = "Material";
            // 
            // msItemSaleOverview
            // 
            this.msItemSaleOverview.Name = "msItemSaleOverview";
            this.msItemSaleOverview.Size = new System.Drawing.Size(163, 22);
            this.msItemSaleOverview.Text = "Sale Overview";
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
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.Color.Peru;
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSale,
            this.msMaterial,
            this.productToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.msMainMenu.Size = new System.Drawing.Size(884, 40);
            this.msMainMenu.TabIndex = 9;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // pItem
            // 
            this.pItem.BackColor = System.Drawing.Color.BurlyWood;
            this.pItem.Controls.Add(this.lblOutOfStock);
            this.pItem.Controls.Add(this.lblNote);
            this.pItem.Controls.Add(this.lblCreateDate);
            this.pItem.Location = new System.Drawing.Point(247, 149);
            this.pItem.Margin = new System.Windows.Forms.Padding(0);
            this.pItem.Name = "pItem";
            this.pItem.Size = new System.Drawing.Size(606, 55);
            this.pItem.TabIndex = 16;
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOutOfStock.Location = new System.Drawing.Point(418, 19);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(125, 16);
            this.lblOutOfStock.TabIndex = 13;
            this.lblOutOfStock.Text = "Out of stock Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNote.Location = new System.Drawing.Point(262, 19);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 16);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Note";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCreateDate.Location = new System.Drawing.Point(39, 19);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(90, 16);
            this.lblCreateDate.TabIndex = 10;
            this.lblCreateDate.Text = "Create Date";
            // 
            // FYeuCauDathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.pItem);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.pButtonList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpFilter);
            this.Controls.Add(this.msMainMenu);
            this.Name = "FYeuCauDathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FYeuCauDathang";
            this.Load += new System.EventHandler(this.FYeuCauDathang_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.pItem.ResumeLayout(false);
            this.pItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem materialRequestToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Panel pButtonList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msItemProductList;
        private System.Windows.Forms.ToolStripMenuItem msItemMaterialList;
        private System.Windows.Forms.ToolStripMenuItem msMaterial;
        private System.Windows.Forms.ToolStripMenuItem msItemSaleOverview;
        private System.Windows.Forms.ToolStripMenuItem msItemSale;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.Panel pItem;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblCreateDate;
    }
}