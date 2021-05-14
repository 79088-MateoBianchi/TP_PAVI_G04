using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
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
    public partial class frmFiltroEscribanos : Form
    {
        public frmFiltroEscribanos()
        {
            InitializeComponent();
        }

        private void frmFiltroEscribanos_Load(object sender, EventArgs e)
        {
            txtMatricula.Focus();

        }

        private void CargarGrillaEscribanos()
        {
            try
            {
                grillaEscribanos.DataSource = AD_Escribanos.ObtenerEscribanos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkMostrarTodosEscrib.Checked)
            {
                CargarGrillaEscribanos();
            }
            else if (txtMatricula.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatricula.Focus();
            }
            else
            {
                grillaEscribanos.DataSource = AD_Escribanos.ObtenerEscribanosPorMatricula(int.Parse(txtMatricula.Text));
                if (grillaEscribanos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtMatricula.Text = "";
            txtMatricula.Focus();
            chkMostrarTodosEscrib.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaEscribanos ventana = new frmAltaEscribanos();
            ventana.ShowDialog();
        }

        private void grillaEscribanos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaEscribanos.Rows[indice];

            int matricula = int.Parse(filaSeleccionada.Cells["Matricula"].Value.ToString());

            Escribano escrib = AD_Escribanos.ObtenerObjEscribanosPorMatricula(matricula);
            frmModificarEliminarEscribano ventana = new frmModificarEliminarEscribano(escrib);
            ventana.ShowDialog();
        }
    }
}
