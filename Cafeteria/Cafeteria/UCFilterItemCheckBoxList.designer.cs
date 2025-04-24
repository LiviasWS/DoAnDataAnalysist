namespace Cafeteria
{
    partial class UCFilterItemCheckBoxList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(21, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Location = new System.Drawing.Point(24, 55);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(158, 145);
            this.flpList.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.SandyBrown;
            this.lblLine.Location = new System.Drawing.Point(25, 40);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(130, 2);
            this.lblLine.TabIndex = 3;
            // 
            // UCFilterItemCheckBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "UCFilterItemCheckBoxList";
            this.Size = new System.Drawing.Size(185, 216);
            this.Load += new System.EventHandler(this.UCFilterItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Label lblLine;
    }
}
