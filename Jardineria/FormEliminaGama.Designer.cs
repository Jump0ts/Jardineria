namespace Jardineria
{
    partial class FormEliminaGama
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
            this.comboGama = new System.Windows.Forms.ComboBox();
            this.lblGama = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescripcionGama = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboGama
            // 
            this.comboGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGama.FormattingEnabled = true;
            this.comboGama.Location = new System.Drawing.Point(190, 47);
            this.comboGama.Name = "comboGama";
            this.comboGama.Size = new System.Drawing.Size(193, 28);
            this.comboGama.TabIndex = 0;
            this.comboGama.SelectedIndexChanged += new System.EventHandler(this.comboGama_SelectedIndexChanged);
            // 
            // lblGama
            // 
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(49, 50);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(57, 20);
            this.lblGama.TabIndex = 1;
            this.lblGama.Text = "Gama:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(49, 112);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 20);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblDescripcionGama
            // 
            this.lblDescripcionGama.AutoSize = true;
            this.lblDescripcionGama.Location = new System.Drawing.Point(186, 112);
            this.lblDescripcionGama.Name = "lblDescripcionGama";
            this.lblDescripcionGama.Size = new System.Drawing.Size(136, 20);
            this.lblDescripcionGama.TabIndex = 3;
            this.lblDescripcionGama.Text = "Descripcion gama";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(346, 323);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormEliminaGama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblDescripcionGama);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblGama);
            this.Controls.Add(this.comboGama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminaGama";
            this.Text = "FormEliminaGama";
            this.Load += new System.EventHandler(this.FormEliminaGama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGama;
        private System.Windows.Forms.Label lblGama;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescripcionGama;
        private System.Windows.Forms.Button btnEliminar;
    }
}