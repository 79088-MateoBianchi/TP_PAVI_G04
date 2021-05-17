using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frmAltaLocalidad : Form
    {
        public frmAltaLocalidad()
        {
            InitializeComponent();
        }

        private void frmAltaLocalidad_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboDepartamentos();
        }

        private void CargarComboDepartamentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM deptos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbDepartamento.DataSource = tabla;
                cmbDepartamento.DisplayMember = "n_departamento";
                cmbDepartamento.ValueMember = "id_departamento";
                cmbDepartamento.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private Localidades ObtenerDatosLocalidad()
        {
            Localidades loc = new Localidades();
            loc.NombreLocalidad = txtNombre.Text.Trim();
            loc.IdDepartamentoLocalidad = (int)cmbDepartamento.SelectedValue;

            return loc;
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Trim().Equals("") && !cmbDepartamento.Text.Equals("")  && AD_Localidades.ValidarAlRegistrar(txtNombre.Text.Trim()) == false)
            {
                Localidades loc = ObtenerDatosLocalidad();
                bool resultado = AD_Localidades.AgregarLocalidadABD(loc);
                if (resultado)
                {
                    MessageBox.Show("Localidad agregada con éxito");
                    LimpiarCampos();
                    CargarComboDepartamentos();

                }
                else
                {
                    MessageBox.Show("Error al agregar localidad");
                }

                //MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDocumento + " " + nroDocumento);
                //MessageBox.Show("Datos de la persona: " + per.NombrePersona + " " + per.ApellidoPersona + " " + per.DocumentoPersona);
            }
            else
            {
                if (AD_Localidades.ValidarAlRegistrar(txtNombre.Text.Trim()) == true)
                {
                    MessageBox.Show("El nombre de la localidad ya existe");
                }
                else if (txtNombre.Text.Trim().Equals("") || cmbDepartamento.Text.Equals(""))
                {
                    MessageBox.Show("Por favor complete los campos que esten vacios");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la localidad exitosamente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
