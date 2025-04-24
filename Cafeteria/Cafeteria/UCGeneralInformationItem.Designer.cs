namespace Cafeteria
{
    partial class UCGeneralInformationItem
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
            this.lblAttribute = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttribute.Location = new System.Drawing.Point(26, 21);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(68, 16);
            this.lblAttribute.TabIndex = 0;
            this.lblAttribute.Text = "Attribute:";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue.Location = new System.Drawing.Point(170, 24);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(207, 13);
            this.txtValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(167, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 2);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // UCGeneralInformationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblAttribute);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCGeneralInformationItem";
            this.Size = new System.Drawing.Size(408, 50);
            this.Load += new System.EventHandler(this.UCGeneralInformationItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
    }
}
