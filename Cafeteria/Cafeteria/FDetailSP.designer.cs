namespace Cafeteria
{
    partial class FDetailSP
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
            this.ucQuantity1 = new Cafeteria.UCQuantity();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucQuantity1
            // 
            this.ucQuantity1.Location = new System.Drawing.Point(-1, -2);
            this.ucQuantity1.Name = "ucQuantity1";
            this.ucQuantity1.Size = new System.Drawing.Size(394, 225);
            this.ucQuantity1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(160, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Thêm";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // FDetailSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(392, 272);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.ucQuantity1);
            this.Name = "FDetailSP";
            this.Text = "FDetailSP";
            this.ResumeLayout(false);

        }

        #endregion

        private UCQuantity ucQuantity1;
        private System.Windows.Forms.Button btnEdit;
    }
}