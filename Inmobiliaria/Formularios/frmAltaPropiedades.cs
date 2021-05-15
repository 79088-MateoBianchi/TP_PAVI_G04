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
    public partial class frmAltaPropiedades : Form
    {
        public frmAltaPropiedades()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboBarrios();
            CargarComboTiposPropiedades();
            CargarComboTiposOperaciones();
            CargarComboMonedas();
        }
        private void LimpiarCampos()
        {
            txtDesignacionCatastral.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtPiso.Text = "";
            txtDepartamento.Text = "";
            txtMonto.Text = "";

        }
        private void CargarComboBarrios()
        {
            try
            {
                cmbBarrio.DataSource = AD_Barrios.ObtenerBarrios();
                cmbBarrio.DisplayMember = "n_barrio";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los barrios!");
                throw;
            }
        }
        private void CargarComboTiposPropiedades()
        {
            try
            {
                cmbTipoPropiedad.DataSource = AD_TiposPropiedades.ObtenerTiposPropiedades();
                cmbTipoPropiedad.DisplayMember = "n_tipo_propiedad";
                cmbTipoPropiedad.ValueMember = "id_tipo_propiedad";
                cmbTipoPropiedad.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de propiedades!");
                throw;
            }
        }
        private void CargarComboTiposOperaciones()
        {
            try
            {
                cmbTipoOperacion.DataSource = AD_TiposOperaciones.ObtenerTiposOperaciones();
                cmbTipoOperacion.DisplayMember = "n_tipo_operacion";
                cmbTipoOperacion.ValueMember = "id_tipo_operacion";
                cmbTipoOperacion.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de operaciones!");
                throw;
            }
        }
        private void CargarComboMonedas()
        {
            try
            {
                cmbMoneda.DataSource = AD_Monedas.ObtenerMonedas();
                cmbMoneda.DisplayMember = "n_moneda";
                cmbMoneda.ValueMember = "id_moneda";
                cmbMoneda.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las monedas!");
                throw;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardarPropiedad_Click(object sender, EventArgs e)
        {
            bool existe = AD_Propiedades.ExistePropiedad(int.Parse(txtDesignacionCatastral.Text));
            if (existe)
            {
                MessageBox.Show("La propiedad ingresada ya esta en el sistema!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesignacionCatastral.Focus();
            }
            else
            {
                if (txtDesignacionCatastral.Text.Equals("") || txtCalle.Text.Equals("") || txtNroCalle.Text.Equals("") || cmbBarrio.SelectedIndex.Equals(-1) || cmbMoneda.SelectedIndex.Equals(-1) || cmbTipoOperacion.SelectedIndex.Equals(-1) || cmbTipoPropiedad.SelectedIndex.Equals(-1) || txtMonto.Text.Equals("") || txtPiso.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesignacionCatastral.Focus();
                }
                else
                {
                    Propiedad p = ObtenerDatosPropiedad();
                    bool resultado = AD_Propiedades.AgregarPropiedad(p);

                    if (resultado)
                    {
                        MessageBox.Show("Propiedad agredada correctamente!", "Informacion");
                        LimpiarCampos();
                        CargarComboBarrios();
                        CargarComboMonedas();
                        CargarComboTiposOperaciones();
                        CargarComboTiposPropiedades();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar la propiedad!");
                    }
                }
            }
        }
        private Propiedad ObtenerDatosPropiedad()
        {
            Propiedad prop = new Propiedad();

            prop.DesignacionCatastralPropiedad = int.Parse(txtDesignacionCatastral.Text);
            prop.CallePropiedad = txtCalle.Text;
            prop.NroCallePropiedad = int.Parse(txtNroCalle.Text);
            prop.PisoPropiedad = int.Parse(txtPiso.Text);
            prop.DepartamentoPropiedad = txtDepartamento.Text;
            prop.IdBarrioPropiedad = (int)cmbBarrio.SelectedValue;
            prop.IdTipoPropPropiedad = (int)cmbTipoPropiedad.SelectedValue;
            prop.IdTipoOperacionPropiedad = (int)cmbTipoOperacion.SelectedValue;
            prop.MontoPropiedad = int.Parse(txtMonto.Text);
            prop.IdMonedaPropiedad = (int)cmbMoneda.SelectedValue;

            return prop;
        }

    }
}
