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
    public partial class frmModificarLocalidad : Form
    {
        public frmModificarLocalidad(Localidades loc)
        {
            InitializeComponent();
            CargarCampos(loc);
        }

        private void CargarCampos(Localidades loc)
        {
            CargarComboDepartamentos();
            txtID.Text = loc.IdLocalidad.ToString();
            txtNombre.Text = loc.NombreLocalidad;
            cmbDepartamento.SelectedValue = loc.IdDepartamentoLocalidad;
            ShowDialog();
        }

        private Localidades ObtenerDatosLocalidades()
        {
            Localidades loc = new Localidades();
            loc.IdLocalidad = int.Parse(txtID.Text.Trim());
            loc.NombreLocalidad = txtNombre.Text.Trim();
            loc.IdDepartamentoLocalidad = (int)cmbDepartamento.SelectedValue;

            return loc;
        }

        private void frmModificarLocalidad_Load(object sender, EventArgs e)
        {

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

        public static bool EliminarLocalidad(Localidades loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "DELETE FROM localidades WHERE id_localidad like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", loc.IdLocalidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;

        }


        public static bool ActualizarLocalidad(Localidades loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "UPDATE localidades SET n_localidad = @nombre, id_departamento = @idDepartamento WHERE id_localidad = @id_localidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_localidad", loc.IdLocalidad);
                cmd.Parameters.AddWithValue("@nombre", loc.NombreLocalidad);
                cmd.Parameters.AddWithValue("@idDepartamento", loc.IdDepartamentoLocalidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;

        }

        private void btnModificarLocalidad_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Trim().Equals("")  && AD_Localidades.ValidarAlRegistrar(txtNombre.Text.Trim()) == false)
            {
                Localidades loc = ObtenerDatosLocalidades();
                bool resultado = ActualizarLocalidad(loc);
                if (resultado)
                {
                    MessageBox.Show("Localidad actualizada con éxito");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al actualizar localidad");
                }
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

        private void btnEliminarLocalidad_Click(object sender, EventArgs e)
        {
            Localidades loc = AD_Localidades.ObtenerLocalidad(txtID.Text);
            bool resultado = EliminarLocalidad(loc);
            if (resultado)
            {
                MessageBox.Show("Localidad eliminada con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar localidad");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
