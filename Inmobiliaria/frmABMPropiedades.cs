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
    public partial class frmABMPropiedades : Form
    {
        public frmABMPropiedades()
        {
            InitializeComponent();
        }

        private void frmABMPropiedades_Load(object sender, EventArgs e)
        {
            btnActualizarPropiedad.Enabled = false;
            btnEliminar.Enabled = false;
            LimpiarCampos();
            CargarGrillaPropiedades();
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

        private void btnGuardarPropiedad_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Propiedad agredada correctamente!");
                    LimpiarCampos();
                    CargarComboBarrios();
                    CargarComboMonedas();
                    CargarComboTiposOperaciones();
                    CargarComboTiposPropiedades();
                    CargarGrillaPropiedades();
                }
                else
                {
                    MessageBox.Show("Error al insertar la propiedad!");
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

        private void grillaPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarPropiedad.Enabled = true;
            btnGuardarPropiedad.Enabled = false;
            btnEliminar.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaPropiedades.Rows[indice];

            int desigCatastral = int.Parse(filaSeleccionada.Cells["DesignacionCatastral"].Value.ToString());

            Propiedad p = AD_Propiedades.ObtenerPropiedadPorDesigCatastral(desigCatastral);
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Propiedad p)
        {
            txtDesignacionCatastral.Text = p.DesignacionCatastralPropiedad.ToString();
            txtCalle.Text = p.CallePropiedad;
            txtNroCalle.Text = p.NroCallePropiedad.ToString();
            txtPiso.Text = p.PisoPropiedad.ToString();
            txtDepartamento.Text = p.DepartamentoPropiedad;
            cmbBarrio.SelectedValue = p.IdBarrioPropiedad;
            cmbTipoPropiedad.SelectedValue = p.IdTipoPropPropiedad;
            cmbTipoOperacion.SelectedValue = p.IdTipoOperacionPropiedad;
            cmbMoneda.SelectedValue = p.IdMonedaPropiedad;
            txtMonto.Text = p.MontoPropiedad.ToString();

        }

        private void btnActualizarPropiedad_Click(object sender, EventArgs e)
        {
            Propiedad p = ObtenerDatosPropiedad();
            bool resultado = AD_Propiedades.ActualizarPropiedad(p);
            if (resultado)
            {
                MessageBox.Show("Propiedad actualizada con exito!");
                LimpiarCampos();
                CargarGrillaPropiedades();
                CargarComboBarrios();
                CargarComboMonedas();
                CargarComboTiposOperaciones();
                CargarComboTiposPropiedades();
                btnGuardarPropiedad.Enabled = true;
                btnActualizarPropiedad.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar la propiedad!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar la propiedad seleccionada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Propiedad p = ObtenerDatosPropiedad();
                bool resultado = AD_Propiedades.EliminarPropiedad(p);
                if (resultado)
                {
                    MessageBox.Show("Propiedad eliminada con exito!");
                    LimpiarCampos();
                    CargarGrillaPropiedades();
                    CargarComboBarrios();
                    CargarComboMonedas();
                    CargarComboTiposOperaciones();
                    CargarComboTiposPropiedades();
                    btnGuardarPropiedad.Enabled = true;
                    btnActualizarPropiedad.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar la propiedad!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }
    }
}
