using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarEliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaBajaCliente ventana = new AltaBajaCliente();
            ventana.Show();
            this.Hide();
        }
    }
}
