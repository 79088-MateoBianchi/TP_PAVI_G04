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
    public partial class frmAltaDepartamento : Form
    {
        public frmAltaDepartamento()
        {
            InitializeComponent();
        }

        private void frmAltaDepartamento_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txtNroEdificio.Text = "";
            txtNroPiso.Text = "";
            txtDenominacion.Text = "";
            txtSuperficie.Text = "";
            txtPorcentajeEdificio.Text = "";
            txtLegajoEncExp.Text = "";
            txtNroEdificio.Focus();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private Departamento ObtenerDatosDepartamento()
        {
            Departamento d = new Departamento();

            d.IdEdificioDepartamento = int.Parse(txtNroEdificio.Text.Trim());
            d.PisoDepartamento = int.Parse(txtNroPiso.Text.Trim());
            d.DenominacionDepartamento = txtDenominacion.Text.Trim();
            d.SuperficieDepartamento = int.Parse(txtSuperficie.Text.Trim());
            d.PorcentajeEdificioDepartamento = float.Parse(txtPorcentajeEdificio.Text.Trim());
            d.LegajoEncargadoExpensasDepartamento = int.Parse(txtLegajoEncExp.Text.Trim());

            return d;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNroEdificio.Text.Equals("") || txtNroPiso.Text.Equals("") || txtDenominacion.Text.Equals("") || txtSuperficie.Text.Equals("") || txtPorcentajeEdificio.Text.Equals("") || txtLegajoEncExp.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroEdificio.Focus();
            } else
            {
                int idEdificio = int.Parse(txtNroEdificio.Text.Trim());
                int nroPiso = int.Parse(txtNroPiso.Text.ToString());
                string denominacion = txtDenominacion.Text.ToString();
                bool existe = AD_Departamentos.ExisteDepartamento(idEdificio, nroPiso, denominacion);
                if (existe)
                {
                    MessageBox.Show("La propiedad ingresada ya esta en el sistema!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNroEdificio.Focus();
                } else
                {
                    Departamento d = ObtenerDatosDepartamento();
                    bool resultado = AD_Departamentos.AgregarDepartamento(d);

                    if (resultado)
                    {
                        MessageBox.Show("Propiedad agredada correctamente!", "Informacion");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar la propiedad!");
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
