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
    public partial class AltaEdificio : Form
    {
        public AltaEdificio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Edificio ed = ObtenerDatosEdificio();
                bool res = AD_Edificios.AgregarEdificioBD(ed);

                if (res)
                {
                    MessageBox.Show("Edificio Agregado Con Exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al Cargar Edificio");
                }
            }
            btnActualizarEdificio.Enabled = false;


        }
        private void LimpiarCampos()
        {
            txtNombreEdificio.Text = "";
            txtCantidadDptos.Text = "";
            chkAscensor.Checked = false;
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";
            txtIdBarrio.Text = "";
            txtNombreEdificio.Focus();
        }


        private void CargarGrilla()
        {
            try
            {
                gdrEdificios.DataSource = AD_Edificios.ObtenerListadoEdificios();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Obtener Edificios");
            }
        }

        private void AltaEdificio_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private Edificio ObtenerDatosEdificio()
        {
            Edificio ed = new Edificio();
            ed.NombreEdificio = txtNombreEdificio.Text.Trim();
            ed.CantidadDptosEdificio = int.Parse(txtCantidadDptos.Text);
            if (chkAscensor.Checked)
            {
                ed.TieneAscensorEdificio = true;
            }
            else
            {
                ed.TieneAscensorEdificio = false;
            }
            ed.CalleEdificio = txtCalle.Text.Trim();
            ed.NumeroCalleEdificio = int.Parse(txtNumeroCalle.Text);
            ed.IdBarrioEdificio = int.Parse(txtIdBarrio.Text);

            return ed;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarEdificio.Enabled = false;

        }

        private bool ValidarCamposVacios()
        {
            if (txtCalle.Text.Equals("") || txtCantidadDptos.Text.Equals("") || txtIdBarrio.Text.Equals("") || txtNombreEdificio.Text.Equals("") || txtNumeroCalle.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos para continuar");
                return false;
            }
            else
                return true;
        }



        private void CargarCampos(Edificio ed)
        {
            txtNombreEdificio.Text = ed.NombreEdificio;

            txtCantidadDptos.Text = ed.CantidadDptosEdificio.ToString();


            if (ed.TieneAscensorEdificio)
            {
                chkAscensor.Checked = true;
            }
            else
            {
                chkAscensor.Checked = false;
            }

            txtCalle.Text = ed.CalleEdificio;
            txtNumeroCalle.Text = ed.NumeroCalleEdificio.ToString();
            txtIdBarrio.Text = ed.IdBarrioEdificio.ToString();

        }

        private void btnActualizarEdificio_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Edificio ed = ObtenerDatosEdificio();
                bool res = AD_Edificios.ActualizarEdificio(ed);
                if (res)
                {
                    MessageBox.Show("Edificio Actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Edificio");
                }
            }

        }

        private void gdrEdificios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarEdificio.Enabled = true;
            DataGridViewRow filaSeleccionda = gdrEdificios.Rows[indice];
            string nombreEdificio = filaSeleccionda.Cells["Nombre"].Value.ToString();
            Edificio ed = AD_Edificios.ObtenerEdificio(nombreEdificio);

            LimpiarCampos();

            CargarCampos(ed);
        }
    }


}
