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
    public partial class frmFiltroLocalidades : Form
    {
        public frmFiltroLocalidades()
        {
            InitializeComponent();
        }

        private void frmFiltroLocalidades_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                gdrLocalidades.DataSource = AD_Localidades.ObtenerLocalidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener localidades");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaLocalidad ventana = new frmAltaLocalidad();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdrLocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrilla();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrLocalidades.Rows[indice];
                string id = filaSeleccionada.Cells["IdLocal"].Value.ToString();
                Localidades loc = AD_Localidades.ObtenerLocalidad(id);
                frmModificarLocalidad vent = new frmModificarLocalidad(loc);
                //CargarCampos(em);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorLocalidad.Text.Equals(""))
                {
                    CargarGrilla();
                    MessageBox.Show("Ingrese algun nombre");
                }
                else
                {
                    DataTable tablaResultado = AD_Localidades.ObtenerLocalidadXNombre(txtFiltrarPorLocalidad.Text.Trim());
                    if (tablaResultado.Rows.Count > 0)
                    {
                        gdrLocalidades.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Empleado Inexistente");
                        txtFiltrarPorLocalidad.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
