using Inmobiliaria.Formularios;
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

        private void ABMDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroDepartamentos ventana = new frmFiltroDepartamentos();
            ventana.ShowDialog();
        }


        private void registrarEliminarPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroPropiedades ventana = new frmFiltroPropiedades();
            ventana.ShowDialog();
        }

        private void aBMEscribanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroEscribanos ventana = new frmFiltroEscribanos();
            ventana.ShowDialog();
        }

        private void aBMLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroLocalidades ventana = new frmFiltroLocalidades();
            ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aBMMonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroMoneda ventana = new frmFiltroMoneda();
            ventana.ShowDialog();
        }
    }
}
