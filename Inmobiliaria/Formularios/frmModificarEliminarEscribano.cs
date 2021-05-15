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
    public partial class frmModificarEliminarEscribano : Form
    {
        public frmModificarEliminarEscribano(Escribano escrib)
        {
            InitializeComponent();
            txtMatricula.Text = escrib.MatriculaEscribano.ToString();
            txtNombre.Text = escrib.NombreEscribano;
            txtApellido.Text = escrib.ApellidoEscribano;
            txtMatricula.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardarEscribano_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult aviso = MessageBox.Show("¿Desea confirmar las modificaciones realizadas?", "Confirmar modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aviso == DialogResult.Yes)
                {
                    Escribano escrib = ObtenerDatosEscribano();
                    bool resultado = AD_Escribanos.ActualizarEscribano(escrib);
                    if (resultado)
                    {
                        MessageBox.Show("Escribano actualizado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el escribano!");
                    }
                }

            }
        }
        private Escribano ObtenerDatosEscribano()
        {
            Escribano escribano = new Escribano();

            escribano.MatriculaEscribano = int.Parse(txtMatricula.Text);
            escribano.NombreEscribano = txtNombre.Text;
            escribano.ApellidoEscribano = txtApellido.Text;

            return escribano;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el escribano seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Escribano escrib = ObtenerDatosEscribano();
                bool resultado = AD_Escribanos.EliminarEscribano(escrib);
                if (resultado)
                {
                    MessageBox.Show("Escribano eliminado con exito!");
                    this.Close();
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
