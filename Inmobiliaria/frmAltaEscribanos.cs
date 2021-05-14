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
    public partial class frmAltaEscribanos : Form
    {
        public frmAltaEscribanos()
        {
            InitializeComponent();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Escribano ObtenerDatosEscribano()
        {
            Escribano escrib = new Escribano();

            escrib.MatriculaEscribano = int.Parse(txtMatricula.Text);
            escrib.NombreEscribano = txtNombre.Text;
            escrib.ApellidoEscribano = txtApellido.Text;
            return escrib;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool existe = AD_Escribanos.ExisteEscribano(int.Parse(txtMatricula.Text));
            if (existe)
            {
                MessageBox.Show("El escribano ingresado ya existe en el sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatricula.Focus();
            }
            else
            {
                if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtMatricula.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatricula.Focus();
                }
                else
                {
                    Escribano escrib = ObtenerDatosEscribano();
                    bool resultado = AD_Escribanos.AgregarEscribano(escrib);

                    if (resultado)
                    {
                        MessageBox.Show("Escribano agredado correctamente!", "Informacion");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el escribano!");
                    }
                }
            }
        }
    }
}
