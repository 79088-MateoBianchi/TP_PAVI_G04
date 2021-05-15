using Inmobiliaria.formularios;
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

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ABM_empleados ventana = new frm_ABM_empleados();
            ventana.ShowDialog();
        }
    }
}
