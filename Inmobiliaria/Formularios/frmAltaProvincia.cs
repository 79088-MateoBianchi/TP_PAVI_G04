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
    public partial class frmAltaProvincia : Form
    {
        public frmAltaProvincia()
        {
            InitializeComponent();
        }

        private void frmAltaProvincia_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            SetUltimoIdProvincia();
        }

        private void LimpiarCampos()
        {
            txtNroProvincia.Text = "";
            txtNombreProvincia.Text = "";
            txtNroProvincia.Focus();
        }

        private void SetUltimoIdProvincia()
        {
            int ultimoId = AD_Provincias.ObtenerUltimoIdProvincia() + 1;

            txtNroProvincia.Text = ultimoId.ToString();
        }


        private Provincia ObtenerDatosProvincia()
        {
            Provincia p = new Provincia();

            p.IdProvincia = int.Parse(txtNroProvincia.Text);
            p.NombreProvincia = txtNombreProvincia.Text.Trim();

            return p;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroProvincia.Text.Equals("") || txtNombreProvincia.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreProvincia.Focus();
            }
            else
            {
                string nombreProvincia = txtNombreProvincia.Text.Trim();
                bool existe = AD_Provincias.ExisteProvincia(nombreProvincia);
                if (existe)
                {
                    MessageBox.Show("La provincia ingresada ya esta en el sistema!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreProvincia.Focus();
                }
                else
                {
                    Provincia p = new Provincia();
                    bool resultado = AD_Provincias.AgregarProvincia(p);

                    if (resultado)
                    {
                        MessageBox.Show("Provincia agredada correctamente!", "Informacion");
                        frmAltaProvincia_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar la provincia!");
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
