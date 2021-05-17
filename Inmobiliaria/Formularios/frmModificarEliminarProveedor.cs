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
    public partial class frmModificarEliminarProveedor : Form
    {
        public frmModificarEliminarProveedor(Proveedor prov)
        {
            InitializeComponent();
            txtNro.Text = prov.IdProveedor.ToString();
            txtNombre.Text = prov.NombreProveedor;
            txtDescripcion.Text = prov.DescripcionProveedor;
            txtTelefono.Text = prov.TelefonoProveedor;
        }

        private void frmModificarEliminarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtDescripcion.Text.Equals("") || txtTelefono.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Complete todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult aviso = MessageBox.Show("¿Desea confirmar las modificaciones realizadas?", "Confirmar modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aviso == DialogResult.Yes)
                {
                    Proveedor prov = ObtenerDatosProveedor();
                    bool resultado = AD_Proveedores.ActualizarProveedor(prov);
                    if (resultado)
                    {
                        MessageBox.Show("Proveedor actualizado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el proveedor!");
                    }
                }
            }
        }
        private Proveedor ObtenerDatosProveedor()
        {
            Proveedor prov = new Proveedor();

            prov.IdProveedor = int.Parse(txtNro.Text);
            prov.NombreProveedor = txtNombre.Text;
            prov.DescripcionProveedor = txtDescripcion.Text;
            prov.TelefonoProveedor = txtTelefono.Text;

            return prov;
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el proveedor seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Proveedor prov = ObtenerDatosProveedor();
                bool resultado = AD_Proveedores.EliminarProveedor(prov);
                if (resultado)
                {
                    MessageBox.Show("Proveedor eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el proveedor.");
                }
            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
