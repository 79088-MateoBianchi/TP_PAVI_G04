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
    public partial class frmAltaProveedor : Form
    {
        public frmAltaProveedor()
        {
            InitializeComponent();
        }

        private void lblAltaEscribanos_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea salir de la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private Proveedor ObtenerDatosProveedor()
        {
            Proveedor prov = new Proveedor();
          
            prov.NombreProveedor = txtNombre.Text;
            prov.DescripcionProveedor = txtDescripcion.Text;
            prov.TelefonoProveedor = txtTelefono.Text;
            return prov;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtDescripcion.Text.Equals("") || txtTelefono.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Complete todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
                int telefono = int.Parse(txtTelefono.Text.Trim());
                bool existe = AD_Proveedores.ExisteProveedorPorId(telefono);
                if (existe)
                {
                    MessageBox.Show("La propiedad ingresada ya esta en el sistema!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }
                else
                {
                    Proveedor p = ObtenerDatosProveedor();
                    bool resultado = AD_Proveedores.AgregarProveedor(p);

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

        private void frmAltaProveedor_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }
    }
}
