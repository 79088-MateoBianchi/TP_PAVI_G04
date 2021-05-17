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
    public partial class frmFiltroMoneda : Form
    {
        public frmFiltroMoneda()
        {
            InitializeComponent();
        }

        private void frmFiltroMoneda_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                gdrMonedas.DataSource = AD_Monedas.ObtenerMonedas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener localidades");
            }

        }        

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaMoneda ventana = new frmAltaMoneda();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdrMonedas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrilla();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrMonedas.Rows[indice];
                string id = filaSeleccionada.Cells["IdMoneda"].Value.ToString();
                Moneda mon = AD_Monedas.ObtenerMoneda(id);
                frmModificarEliminarMoneda vent = new frmModificarEliminarMoneda(mon);
                //CargarCampos(em);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorMoneda.Text.Equals(""))
                {
                    CargarGrilla();
                    MessageBox.Show("Ingrese algun nombre");
                }
                else
                {
                    DataTable tablaResultado = AD_Monedas.ObtenerMonedaXNombre(txtFiltrarPorMoneda.Text.Trim());
                    if (tablaResultado.Rows.Count > 0)
                    {
                        gdrMonedas.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Empleado Inexistente");
                        txtFiltrarPorMoneda.Focus();
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