using Inmobiliaria.Entidades;
using Inmobiliaria.AccesoADatos;
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
    public partial class frmAltaMoneda : Form
    {
        public frmAltaMoneda()
        {
            InitializeComponent();
        }

        private void frmAltaMoneda_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txtNom.Text = "";
            txtCot.Text = "";
        }

        private Moneda ObtenerDatosMoneda()
        {
            Moneda loc = new Moneda();
            loc.NombreMoneda = txtNom.Text.Trim();
            loc.CotizacionMoneda = int.Parse(txtCot.Text.Trim());

            return loc;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Trim().Equals("") && !txtCot.Text.Trim().Equals("") && AD_Monedas.ValidarAlRegistrar(txtNom.Text.Trim()) == false)
            {
                Moneda loc = ObtenerDatosMoneda();
                bool resultado = AD_Monedas.AgregarMonedaABD(loc);
                if (resultado)
                {
                    MessageBox.Show("Moneda agregada con éxito");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar Moneda");
                }

                //MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDocumento + " " + nroDocumento);
                //MessageBox.Show("Datos de la persona: " + per.NombrePersona + " " + per.ApellidoPersona + " " + per.DocumentoPersona);
            }
            else
            {
                if (AD_Monedas.ValidarAlRegistrar(txtNom.Text.Trim()) == true)
                {
                    MessageBox.Show("El nombre de la Moneda ya existe");
                }
                else if (txtNom.Text.Trim().Equals("") || txtCot.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Por favor complete los campos que esten vacios");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la Moneda exitosamente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}