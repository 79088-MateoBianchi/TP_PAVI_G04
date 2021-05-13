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
    public partial class frmFiltroPropiedades : Form
    {
        public frmFiltroPropiedades()
        {
            InitializeComponent();
        }

        private void frmFiltroPropiedades_Load(object sender, EventArgs e)
        {
            txtDesigCat.Focus();
        }
        private void CargarGrillaPropiedades()
        {
            try
            {
                grillaPropiedades.DataSource = AD_Propiedades.ObtenerPropiedades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkMostrarTodasProp.Checked)
            {
                CargarGrillaPropiedades();
            }
            else if (txtDesigCat.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesigCat.Focus();
            }
            else
            {
                grillaPropiedades.DataSource = AD_Propiedades.GetPropiedadesPorDesigCatastral(int.Parse(txtDesigCat.Text));
                if (grillaPropiedades.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtDesigCat.Text = "";
            txtDesigCat.Focus();
            chkMostrarTodasProp.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPropiedades ventana = new frmAltaPropiedades();
            ventana.ShowDialog();
        }

        private void grillaPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaPropiedades.Rows[indice];

            int desigCatastral = int.Parse(filaSeleccionada.Cells["DesignacionCatastral"].Value.ToString());

            Propiedad p = AD_Propiedades.ObtenerPropiedadPorDesigCatastral(desigCatastral);

            frmModificarEliminarPropiedad ventana = new frmModificarEliminarPropiedad(p);
            ventana.ShowDialog();
        }
    }
}
