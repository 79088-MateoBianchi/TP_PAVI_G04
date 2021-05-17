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
    public partial class frmFiltroProvincias : Form
    {
        public frmFiltroProvincias()
        {
            InitializeComponent();
        }

        private void frmFiltroProvincias_Load(object sender, EventArgs e)
        {
            txtIdProvincia.Focus();
        }

        private void chkTodasProvincias_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodasProvincias.Checked)
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
            chkTodasProvincias.Checked = false;
            for (int i = 0; i < grillaProvincias.Rows.Count; i++)
            {
                DataGridViewRow deleteRow = grillaProvincias.Rows[i];
                grillaProvincias.Rows.Remove(deleteRow);
            }
            grillaProvincias.Refresh();
        }

        private void CargarGrillaProvincias()
        {
            try
            {
                grillaProvincias.DataSource = AD_Provincias.ObtenerProvincias();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla");
                throw;
            }
        }

        private void btnBuscarProvincias_Click(object sender, EventArgs e)
        {
            if (chkTodasProvincias.Checked)
            {
                CargarGrillaProvincias();
            }
            else if (txtIdProvincia.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProvincia.Focus();
            }
            else
            {
                grillaProvincias.DataSource = AD_Provincias.ObtenerProvinciaPorId(int.Parse(txtIdProvincia.Text.Trim()));
                if (grillaProvincias.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }


        private void grillaProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaProvincias.Rows[indice];

            Provincia p = new Provincia();
            p.IdProvincia = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            p.NombreProvincia = filaSeleccionada.Cells[1].Value.ToString();

            frmEliminarProvincia ventana = new frmEliminarProvincia(p);
            ventana.ShowDialog();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            frmAltaProvincia ventana = new frmAltaProvincia();
            ventana.ShowDialog();
        }

        private void btnSalirProvincias_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
