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
    public partial class FormEmpJefe : Form
    {
        private List<Empleado> empleados;
        private int pos = 0;

        public FormEmpJefe()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtCod.Text != "")
            {
                empleados = ControladorBBDD.getInstance().empleadosJefe(txtCod.Text.ToString());
            }

            if (empleados == null)
            {
                MessageBox.Show("Ha introducido un código de jefe inexistente.");
                btnNext.Enabled = false;
                btnPrev.Enabled = false;

                lblNom.Text = "-";
                lblApe.Text = "-";
                lblEmail.Text = "-";

                lblPos.Text = "0 de 0";
            }
            else
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;

                pos = 0;

                muevePos();
            }
        }

        private void muevePos()
        {
            if (pos == -1) pos = empleados.Count - 1;
            if (pos == empleados.Count) pos = 0;

            lblNom.Text = empleados[pos].nombre;
            lblApe.Text = empleados[pos].apellido;
            lblEmail.Text = empleados[pos].email;

            lblPos.Text = pos + 1 + " de " + empleados.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pos++;
            muevePos();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pos--;
            muevePos();
        }
    }
}
