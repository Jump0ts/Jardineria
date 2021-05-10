namespace Jardineria
{
    partial class FormPrecios
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
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(104, 133);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(125, 20);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Precio más alto: ";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(104, 231);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(125, 20);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Precio más bajo:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(342, 130);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(342, 228);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 3;
            // 
            // FormPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrecios";
            this.Text = "FormPrecios";
            this.Load += new System.EventHandler(this.FormPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
    }
}