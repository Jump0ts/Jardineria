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
    public partial class FormAnadirProd : Form
    {
        public FormAnadirProd()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtCant.Text = "";
            txtCod.Text = "";
            txtDesc.Text = "";
            txtDim.Text = "";
            txtNombre.Text = "";
            txtPProveedor.Text = "";
            txtProveedor.Text = "";
            txtVenta.Text = "";
        }

        private void comboGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGama.SelectedItem.ToString() == "Herramientas") lblPatron.Text = "";
            else if (comboGama.SelectedItem.ToString() == "Aromáticas") lblPatron.Text = "AR-";
            else if (comboGama.SelectedItem.ToString() == "Frutales") lblPatron.Text = "FR-";
            else if (comboGama.SelectedItem.ToString() == "Ornamentales") lblPatron.Text = "OR-";
            else if (comboGama.SelectedItem.ToString() == "Herbaceas") lblPatron.Text = "HE-";
        }

        private void FormAnadirProd_Load(object sender, EventArgs e)
        {
            List<String> gamas = ControladorBBDD.getInstance().getGama();

            for(int i = 0; i<gamas.Count(); i++)
            {
                comboGama.Items.Add(gamas[i]);
            }

            comboGama.SelectedIndex = 0;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            float dimensiones, stock, venta, pprov;
            long cod;
            if (txtNombre.Text != "" && txtDim.Text != "" && txtCant.Text != "" && txtCod.Text != "" &&
                txtDesc.Text != "" && txtPProveedor.Text != "" && txtProveedor.Text != "" && txtVenta.Text != "")
            {
                if (Int64.TryParse(txtCod.Text, out cod) == true && cod > 0)
                {
                    if (float.TryParse(txtDim.Text, out dimensiones) == true && dimensiones > 0)
                    {
                        if (float.TryParse(txtCant.Text, out stock) == true && stock > 0)
                        {
                            if (float.TryParse(txtVenta.Text, out venta) == true && venta > 0)
                            {
                                if (float.TryParse(txtPProveedor.Text, out pprov) == true && pprov > 0)
                                {
                                    if (ControladorBBDD.getInstance().insertProd(lblPatron.Text + "" + txtCod.Text, txtNombre.Text, comboGama.SelectedItem.ToString(), dimensiones, txtProveedor.Text, txtDesc.Text, stock, venta, pprov) == 1)
                                    {
                                        MessageBox.Show("Producto añadido correctamente.");
                                        limpiar();
                                    }
                                    else MessageBox.Show("Código de producto ya existente.");
                                }
                                else MessageBox.Show("No ha introducido un número válido en el campo de precio de proveedor.");
                            }
                            else MessageBox.Show("No ha introducido un número válido en el campo de precio de venta.");
                        }
                        else MessageBox.Show("No ha introducido un número válido en el campo de cantidad en stock.");
                    }
                    else MessageBox.Show("No ha introducido un número válido en el campo de dimensiones.");
                }
                else MessageBox.Show("No ha introducido un número válido en el campo de código de producto.");
            }
            else MessageBox.Show("Debe rellenar todos los campos.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
