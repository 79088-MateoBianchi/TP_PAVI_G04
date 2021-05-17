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
    public partial class frmFiltroDeptos : Form
    {
        public frmFiltroDeptos()
        {
            InitializeComponent();
        }

        private void frmFiltroDeptos_Load(object sender, EventArgs e)
        {
            txtIdProvincia.Focus();
        }

        private void chkTodosDeptos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodosDeptos.Checked)
            {
                txtIdProvincia.Text = "";
                txtIdProvincia.Enabled = false;
            }
            else
            {
                txtIdProvincia.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtIdProvincia.Text = "";
            txtIdProvincia.Focus();
            chkTodosDeptos.Checked = false;
            for (int i = 0; i < grillaDeptos.Rows.Count; i++)
            {
                DataGridViewRow deleteRow = grillaDeptos.Rows[i];
                grillaDeptos.Rows.Remove(deleteRow);
            }
            grillaDeptos.Refresh();
        }


        private void CargarGrillaDeptos()
        {
            try
            {
                grillaDeptos.DataSource = AD_Deptos.ObtenerDeptos();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla");
                throw;
            }
        }

        private void btnBuscarProvincias_Click(object sender, EventArgs e)
        {
            if (chkTodosDeptos.Checked)
            {
                CargarGrillaDeptos();
            }
            else if (txtIdProvincia.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProvincia.Focus();
            }
            else
            {
                grillaDeptos.DataSource = AD_Deptos.ObtenerDeptoPorIdProvincia(int.Parse(txtIdProvincia.Text.Trim()));
                if (grillaDeptos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void grillaDeptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaDeptos.Rows[indice];

            Depto d = new Depto();
            d.IdDepto = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            d.NombreDepto = filaSeleccionada.Cells[1].Value.ToString();
            d.IdProvinciaDepto = int.Parse(filaSeleccionada.Cells[2].Value.ToString());

            frmEliminarDepto ventana = new frmEliminarDepto(d);
            ventana.ShowDialog();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            frmAltaDepto ventana = new frmAltaDepto();
            ventana.ShowDialog();
        }

        private void btnSalirProvincias_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
