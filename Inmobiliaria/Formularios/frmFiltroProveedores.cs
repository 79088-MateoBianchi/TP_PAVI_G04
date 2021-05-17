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

namespace Inmobiliaria.Formularios
{
    public partial class frmFiltroProveedores : Form
    {
        public frmFiltroProveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFiltroProveedores_Load(object sender, EventArgs e)
        {
            txtNro.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProveedor ventana = new frmAltaProveedor();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grillaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }
        private void CargarGrillaProveedores()
        {
            try
            {
                grillaProveedores.DataSource = AD_Proveedores.ObtenerProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNro.Text = "";
            txtNro.Focus();
            chkMostrarTodosProvee.Checked = false;
            for (int i = 0; i < grillaProveedores.Rows.Count; i++)
            {
                DataGridViewRow deleteRow = grillaProveedores.Rows[i];
                grillaProveedores.Rows.Remove(deleteRow);
            }
            grillaProveedores.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkMostrarTodosProvee.Checked)
            {
                CargarGrillaProveedores();
            }
            else if (txtNro.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el número de proveedor para realizar la busqueda!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNro.Focus();
            }
            else
            {
                grillaProveedores.DataSource = AD_Proveedores.ObtenerProveedoresPorId(int.Parse(txtNro.Text.Trim()));
                if (grillaProveedores.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void chkMostrarTodosProvee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarTodosProvee.Checked)
            {
                txtNro.Enabled = false;
                txtNro.Clear();
            }
            else
            {
                txtNro.Enabled = true;
            }
        }

        private void txtNro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrillaProveedores();
        }

        private void grillaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaProveedores.Rows[indice];

            int Id = int.Parse(filaSeleccionada.Cells["IdProveedor"].Value.ToString());           

            Proveedor p = AD_Proveedores.ObtenerObjProveedorPorId(Id);

            frmModificarEliminarProveedor ventana = new frmModificarEliminarProveedor(p);
            ventana.ShowDialog();
        }
    }
}
