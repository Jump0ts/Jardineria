using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cambiaPanel(Form formulario)
        {
            if (this.panel.Controls.Count > 0)
            {
                this.panel.Controls.RemoveAt(0);
            }
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panel.Controls.Add(formulario);
            formulario.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            if (ControladorBBDD.getInstance().conectar() == false)
            {
                MessageBox.Show("Error al conectar a la base de datos.");
                this.Close();
            }

            cambiaPanel(new FormAnadirProd());
        }

        private void btnAnadirProd_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormAnadirProd());
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControladorBBDD.getInstance().desconectar();
        }

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormEliminaGama());
        }

        private void btnPedEntregados_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormPedEntrgados());
        }

        private void btnEmpJefe_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormEmpJefe());
        }

        private void btnClientesNPaga_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormClienteNoPaga());
        }

        private void btnConsultPrecio_Click(object sender, EventArgs e)
        {
            cambiaPanel(new FormPrecios());
        }
    }
}
