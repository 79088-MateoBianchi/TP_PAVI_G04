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
    public partial class frmAltaDepto : Form
    {
        public frmAltaDepto()
        {
            InitializeComponent();
        }

        private void frmAltaDepto_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            SetUltimoIdDepto();
            CargarComboProvincias();
        }

        private void LimpiarCampos()
        {
            txtNroDepto.Text = "";
            txtNombreDepto.Text = "";
            cmbProvincias.SelectedIndex = -1;
            txtNroDepto.Focus();
        }

        private void SetUltimoIdDepto()
        {
            int ultimoId = AD_Deptos.ObtenerUltimoIdDepto();

            if (ultimoId == 0)
            {
                MessageBox.Show("Ocurrió un error al acceder a los datos del departamento", "Error");
            }
            else
            {
                ultimoId++;
                txtNroDepto.Text = ultimoId.ToString();
            }
        }


        private void CargarComboProvincias()
        {
            try
            {
                cmbProvincias.DataSource = AD_Provincias.ObtenerProvincias();
                cmbProvincias.DisplayMember = "n_provincia";
                cmbProvincias.ValueMember = "id_provincia";
                cmbProvincias.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las provincias!");
                throw;
            }
        }


        private Depto ObtenerDatosDepto()
        {
            Depto d = new Depto();

            d.IdDepto = int.Parse(txtNroDepto.Text);
            d.NombreDepto = txtNombreDepto.Text.Trim();
            d.IdProvinciaDepto = (int)cmbProvincias.SelectedValue;

            return d;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroDepto.Text.Equals("") || txtNombreDepto.Text.Equals("") || cmbProvincias.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreDepto.Focus();
            }
            else
            {
                Depto d = ObtenerDatosDepto();
                string nombreDepto = d.NombreDepto;
                int idProvincia = d.IdProvinciaDepto;
                bool existe = AD_Deptos.ExisteDepto(nombreDepto, idProvincia);
                if (existe)
                {
                    MessageBox.Show("El departamento ingresado ya esta en el sistema!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreDepto.Focus();
                }
                else
                {
                    bool resultado = AD_Deptos.AgregarDepto(d);

                    if (resultado)
                    {
                        MessageBox.Show("Departamento agredado correctamente!", "Informacion");
                        frmAltaDepto_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el departamento!");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
