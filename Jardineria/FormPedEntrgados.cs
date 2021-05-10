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
    public partial class FormPedEntrgados : Form
    {
        public FormPedEntrgados()
        {
            InitializeComponent();
        }

        private void FormPedEntrgados_Load(object sender, EventArgs e)
        {
            comboMes.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ControladorBBDD.getInstance().pedidosMes(comboMes.SelectedIndex + 1);
            dataGridView.AutoResizeColumns();

            if (dataGridView.Rows.Count == 0)
                MessageBox.Show("No hay pedidos entregados en ese mes.");
        }
    }
}
