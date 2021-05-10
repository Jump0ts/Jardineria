namespace Jardineria
{
    partial class FormAnadirProd
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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblGama = new System.Windows.Forms.Label();
            this.lblDim = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblPProveedor = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtPProveedor = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtDim = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboGama = new System.Windows.Forms.ComboBox();
            this.lblPatron = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(39, 12);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(134, 20);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código producto: ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(39, 47);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(73, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre: ";
            // 
            // lblGama
            // 
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(39, 78);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(61, 20);
            this.lblGama.TabIndex = 2;
            this.lblGama.Text = "Gama: ";
            // 
            // lblDim
            // 
            this.lblDim.AutoSize = true;
            this.lblDim.Location = new System.Drawing.Point(39, 111);
            this.lblDim.Name = "lblDim";
            this.lblDim.Size = new System.Drawing.Size(109, 20);
            this.lblDim.TabIndex = 3;
            this.lblDim.Text = "Dimensiones: ";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(39, 143);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(85, 20);
            this.lblProv.TabIndex = 4;
            this.lblProv.Text = "Proveedor:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(39, 175);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(39, 207);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(141, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Cantidad en stock:";
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(39, 239);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(122, 20);
            this.lblVenta.TabIndex = 7;
            this.lblVenta.Text = "Precio de venta:";
            // 
            // lblPProveedor
            // 
            this.lblPProveedor.AutoSize = true;
            this.lblPProveedor.Location = new System.Drawing.Point(41, 271);
            this.lblPProveedor.Name = "lblPProveedor";
            this.lblPProveedor.Size = new System.Drawing.Size(132, 20);
            this.lblPProveedor.TabIndex = 8;
            this.lblPProveedor.Text = "Precio proveedor:";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(292, 314);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(74, 39);
            this.btnAnadir.TabIndex = 9;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(441, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 39);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(330, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(173, 26);
            this.txtCod.TabIndex = 11;
            // 
            // txtPProveedor
            // 
            this.txtPProveedor.Location = new System.Drawing.Point(272, 268);
            this.txtPProveedor.Name = "txtPProveedor";
            this.txtPProveedor.Size = new System.Drawing.Size(156, 26);
            this.txtPProveedor.TabIndex = 12;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(272, 236);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(156, 26);
            this.txtVenta.TabIndex = 13;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(272, 204);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(156, 26);
            this.txtCant.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(272, 172);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(463, 26);
            this.txtDesc.TabIndex = 15;
            // 
            // txtDim
            // 
            this.txtDim.Location = new System.Drawing.Point(272, 108);
            this.txtDim.Name = "txtDim";
            this.txtDim.Size = new System.Drawing.Size(156, 26);
            this.txtDim.TabIndex = 16;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(272, 140);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(463, 26);
            this.txtProveedor.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(272, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(463, 26);
            this.txtNombre.TabIndex = 18;
            // 
            // comboGama
            // 
            this.comboGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGama.FormattingEnabled = true;
            this.comboGama.Location = new System.Drawing.Point(272, 76);
            this.comboGama.Name = "comboGama";
            this.comboGama.Size = new System.Drawing.Size(243, 28);
            this.comboGama.TabIndex = 19;
            this.comboGama.SelectedIndexChanged += new System.EventHandler(this.comboGama_SelectedIndexChanged);
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Location = new System.Drawing.Point(268, 15);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(56, 20);
            this.lblPatron.TabIndex = 20;
            this.lblPatron.Text = "Patron";
            // 
            // FormAnadirProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 382);
            this.Controls.Add(this.lblPatron);
            this.Controls.Add(this.comboGama);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtDim);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtPProveedor);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.lblPProveedor);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblDim);
            this.Controls.Add(this.lblGama);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnadirProd";
            this.Text = "FormAnadirProd";
            this.Load += new System.EventHandler(this.FormAnadirProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblGama;
        private System.Windows.Forms.Label lblDim;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblPProveedor;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtPProveedor;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtDim;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboGama;
        private System.Windows.Forms.Label lblPatron;
    }
}