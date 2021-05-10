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
    public partial class FormEliminaGama : Form
    {
        public FormEliminaGama()
        {
            InitializeComponent();
        }

        private void FormEliminaGama_Load(object sender, EventArgs e)
        {
            rellenaCombo();
        }

        private void rellenaCombo()
        {
            List<String> gamas = ControladorBBDD.getInstance().getGama();

            comboGama.Items.Clear();

            for (int i = 0; i < gamas.Count(); i++)
            {
                comboGama.Items.Add(gamas[i]);
            }

            comboGama.SelectedIndex = 0;
        }

        private void comboGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescripcionGama.Text = ControladorBBDD.getInstance().getDescGama(comboGama.SelectedItem.ToString());
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar la gama y todo sus productos?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ControladorBBDD.getInstance().eliminaGama(comboGama.SelectedItem.ToString());
                rellenaCombo();
            }
        }
    }
}
