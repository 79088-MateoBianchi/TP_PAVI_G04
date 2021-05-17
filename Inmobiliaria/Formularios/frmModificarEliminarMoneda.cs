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
    public partial class frmModificarEliminarMoneda : Form
    {
        public frmModificarEliminarMoneda(Moneda mon)
        {
            InitializeComponent();
            CargarCampos(mon);
        }

        private void CargarCampos(Moneda mon)
        {
            txtId.Text = mon.IdMoneda.ToString();
            txtNom.Text = mon.NombreMoneda;
            txtCot.Text = mon.CotizacionMoneda.ToString();
            ShowDialog();
        }

        private Moneda ObtenerDatosMoneda()
        {
            Moneda loc = new Moneda();
            loc.IdMoneda = int.Parse(txtId.Text.Trim());
            loc.NombreMoneda = txtNom.Text.Trim();
            loc.CotizacionMoneda = int.Parse(txtCot.Text.Trim());

            return loc;
        }

        private void frmModificarLocalidad_Load(object sender, EventArgs e)
        {

        }


        public static bool EliminarMoneda(Moneda loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "DELETE FROM monedas WHERE id_moneda like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", loc.IdMoneda);

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


        public static bool ActualizarMoneda(Moneda loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "UPDATE monedas SET n_moneda = @nombre, cotizacion_pesos_arg = @cot WHERE id_moneda = @id_moneda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_moneda", loc.IdMoneda);
                cmd.Parameters.AddWithValue("@nombre", loc.NombreMoneda);
                cmd.Parameters.AddWithValue("@cot", loc.CotizacionMoneda);

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

        private void frmModificarEliminarMoneda_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)

        {
            if (!txtNom.Text.Trim().Equals("") && AD_Monedas.ValidarAlRegistrar(txtNom.Text.Trim()) == false)
            {
                Moneda loc = ObtenerDatosMoneda();
                bool resultado = ActualizarMoneda(loc);
                if (resultado)
                {
                    MessageBox.Show("Moneda actualizada con éxito");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al actualizar Moneda");
                }
            }
            else
            {
                if (AD_Monedas.ValidarAlRegistrar(txtNom.Text.Trim()) == true)
                {
                    MessageBox.Show("El nombre de la localidad ya existe");
                }
                else if (txtNom.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Por favor complete los campos que esten vacios");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la localidad exitosamente");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Moneda loc = AD_Monedas.ObtenerMoneda(txtNom.Text);
            bool resultado = EliminarMoneda(loc);
            if (resultado)
            {
                MessageBox.Show("Moneda eliminada con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar Moneda");
            }
        }
    }
}