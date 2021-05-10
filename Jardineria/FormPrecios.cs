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
    public partial class FormPrecios : Form
    {
        public FormPrecios()
        {
            InitializeComponent();
        }

        private void FormPrecios_Load(object sender, EventArgs e)
        {
            List<long> precios = ControladorBBDD.getInstance().maxMin();

            txtMax.Text = precios[0] + "€";
            txtMin.Text = precios[1] + "€";
        }
    }
}
