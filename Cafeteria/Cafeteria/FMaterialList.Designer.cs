namespace Cafeteria
{
    partial class FMaterialList
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
            this.msItemSaleOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.pButtonList = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtxtTest = new System.Windows.Forms.RichTextBox();
            this.msMainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.Color.Peru;
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSaleOverview,
            this.productToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.msMainMenu.Size = new System.Drawing.Size(884, 40);
            this.msMainMenu.TabIndex = 18;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msItemSaleOverview
            // 
            this.msItemSaleOverview.AutoSize = false;
            this.msItemSaleOverview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msItemSaleOverview.ForeColor = System.Drawing.SystemColors.Window;
            this.msItemSaleOverview.Name = "msItemSaleOverview";
            this.msItemSaleOverview.Size = new System.Drawing.Size(110, 36);
            this.msItemSaleOverview.Text = "Sale Overview";
            this.msItemSaleOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.AutoSize = false;
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblUnit);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(247, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 40);
            this.panel2.TabIndex = 27;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuantity.Location = new System.Drawing.Point(259, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnit.Location = new System.Drawing.Point(403, 12);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(34, 16);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "Unit";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(118, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Location = new System.Drawing.Point(247, 248);
            this.flpList.Margin = new System.Windows.Forms.Padding(0);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(625, 364);
            this.flpList.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tan;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(588, 170);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Tan;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModify.Location = new System.Drawing.Point(784, 170);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 23;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // pButtonList
            // 
            this.pButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pButtonList.Location = new System.Drawing.Point(247, 111);
            this.pButtonList.Name = "pButtonList";
            this.pButtonList.Size = new System.Drawing.Size(612, 10);
            this.pButtonList.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(243, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Material List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(247, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 19);
            this.panel1.TabIndex = 21;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.SystemColors.Control;
            this.flpFilter.Location = new System.Drawing.Point(25, 75);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(189, 570);
            this.flpFilter.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tan;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(688, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtxtTest
            // 
            this.rtxtTest.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTest.Location = new System.Drawing.Point(310, 159);
            this.rtxtTest.Name = "rtxtTest";
            this.rtxtTest.Size = new System.Drawing.Size(190, 34);
            this.rtxtTest.TabIndex = 28;
            this.rtxtTest.Text = "";
            // 
            // FMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.rtxtTest);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.pButtonList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpFilter);
            this.Name = "FMaterialList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMaterialManager";
            this.Load += new System.EventHandler(this.FMaterialList_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msItemSaleOverview;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel pButtonList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rtxtTest;
    }
}