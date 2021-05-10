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
    public partial class FormClienteNoPaga : Form
    {
        public FormClienteNoPaga()
        {
            InitializeComponent();
        }

        private void FormClienteNoPaga_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = ControladorBBDD.getInstance().clientesNoPaga();
            dataGrid.AutoResizeColumns();
        }
    }
}
