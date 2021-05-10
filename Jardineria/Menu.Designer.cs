namespace Jardineria
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.btnAnadirProd = new System.Windows.Forms.Button();
            this.btnEliminarGama = new System.Windows.Forms.Button();
            this.btnPedEntregados = new System.Windows.Forms.Button();
            this.btnEmpJefe = new System.Windows.Forms.Button();
            this.btnClientesNPaga = new System.Windows.Forms.Button();
            this.btnConsultPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(913, 460);
            this.panel.TabIndex = 0;
            // 
            // btnAnadirProd
            // 
            this.btnAnadirProd.Location = new System.Drawing.Point(12, 478);
            this.btnAnadirProd.Name = "btnAnadirProd";
            this.btnAnadirProd.Size = new System.Drawing.Size(147, 54);
            this.btnAnadirProd.TabIndex = 1;
            this.btnAnadirProd.Text = "Añadir producto";
            this.btnAnadirProd.UseVisualStyleBackColor = true;
            this.btnAnadirProd.Click += new System.EventHandler(this.btnAnadirProd_Click);
            // 
            // btnEliminarGama
            // 
            this.btnEliminarGama.Location = new System.Drawing.Point(165, 478);
            this.btnEliminarGama.Name = "btnEliminarGama";
            this.btnEliminarGama.Size = new System.Drawing.Size(147, 54);
            this.btnEliminarGama.TabIndex = 2;
            this.btnEliminarGama.Text = "Eliminar gama";
            this.btnEliminarGama.UseVisualStyleBackColor = true;
            this.btnEliminarGama.Click += new System.EventHandler(this.btnEliminarGama_Click);
            // 
            // btnPedEntregados
            // 
            this.btnPedEntregados.Location = new System.Drawing.Point(318, 478);
            this.btnPedEntregados.Name = "btnPedEntregados";
            this.btnPedEntregados.Size = new System.Drawing.Size(147, 54);
            this.btnPedEntregados.TabIndex = 3;
            this.btnPedEntregados.Text = "Pedidos entregados";
            this.btnPedEntregados.UseVisualStyleBackColor = true;
            this.btnPedEntregados.Click += new System.EventHandler(this.btnPedEntregados_Click);
            // 
            // btnEmpJefe
            // 
            this.btnEmpJefe.Location = new System.Drawing.Point(471, 478);
            this.btnEmpJefe.Name = "btnEmpJefe";
            this.btnEmpJefe.Size = new System.Drawing.Size(147, 54);
            this.btnEmpJefe.TabIndex = 4;
            this.btnEmpJefe.Text = "Empleados por jefe";
            this.btnEmpJefe.UseVisualStyleBackColor = true;
            this.btnEmpJefe.Click += new System.EventHandler(this.btnEmpJefe_Click);
            // 
            // btnClientesNPaga
            // 
            this.btnClientesNPaga.Location = new System.Drawing.Point(624, 478);
            this.btnClientesNPaga.Name = "btnClientesNPaga";
            this.btnClientesNPaga.Size = new System.Drawing.Size(147, 54);
            this.btnClientesNPaga.TabIndex = 5;
            this.btnClientesNPaga.Text = "Clientes sin pagar";
            this.btnClientesNPaga.UseVisualStyleBackColor = true;
            this.btnClientesNPaga.Click += new System.EventHandler(this.btnClientesNPaga_Click);
            // 
            // btnConsultPrecio
            // 
            this.btnConsultPrecio.Location = new System.Drawing.Point(777, 478);
            this.btnConsultPrecio.Name = "btnConsultPrecio";
            this.btnConsultPrecio.Size = new System.Drawing.Size(147, 54);
            this.btnConsultPrecio.TabIndex = 6;
            this.btnConsultPrecio.Text = "Consulta precios";
            this.btnConsultPrecio.UseVisualStyleBackColor = true;
            this.btnConsultPrecio.Click += new System.EventHandler(this.btnConsultPrecio_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 544);
            this.Controls.Add(this.btnConsultPrecio);
            this.Controls.Add(this.btnClientesNPaga);
            this.Controls.Add(this.btnEmpJefe);
            this.Controls.Add(this.btnPedEntregados);
            this.Controls.Add(this.btnEliminarGama);
            this.Controls.Add(this.btnAnadirProd);
            this.Controls.Add(this.panel);
            this.Name = "menu";
            this.Text = "Jardinería";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAnadirProd;
        private System.Windows.Forms.Button btnEliminarGama;
        private System.Windows.Forms.Button btnPedEntregados;
        private System.Windows.Forms.Button btnEmpJefe;
        private System.Windows.Forms.Button btnClientesNPaga;
        private System.Windows.Forms.Button btnConsultPrecio;
    }
}

