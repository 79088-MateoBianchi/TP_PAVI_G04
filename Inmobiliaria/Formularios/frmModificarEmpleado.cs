using Inmobiliaria.AccesoADatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado(Empleados em)
        {
            InitializeComponent();
            CargarCampos(em);
        }


        //Completo el form con los datos del empleado
        private void CargarCampos(Empleados em)
        {
            CargarComboBarrios();
            txtLeg.Text = em.LegajoEmpleado.ToString();
            txtNom.Text = em.NombreEmpleado;
            txtApe.Text = em.ApellidoEmpleado;
            txtDire.Text = em.CalleEmpleado;
            txtNroCall.Text = em.NroCalleEmpleado.ToString();
            cmbBarr.SelectedValue = em.IdBarrioEmpleado;
            txtIDUsu.Text = em.IdUsuarioEmpleado.ToString();
            txtNomUsu.Text = em.NombreUsuarioEmpleado;
            txtContra.Text = em.ContraseñaEmpleado;
            txtRepContra.Text = em.ContraseñaEmpleado;
            ShowDialog();
        }

        //Guardo las modificaciones que hice en el form
        private Empleados ObtenerDatosEmpleado()
        {
            Empleados em = new Empleados();
            em.LegajoEmpleado = int.Parse(txtLeg.Text.Trim());
            em.NombreEmpleado = txtNom.Text.Trim();
            em.ApellidoEmpleado = txtApe.Text.Trim();
            em.CalleEmpleado = txtDire.Text.Trim();
            em.NroCalleEmpleado = int.Parse(txtNroCall.Text.Trim());
            em.IdBarrioEmpleado = (int)cmbBarr.SelectedValue;
            em.NombreUsuarioEmpleado = txtNomUsu.Text.Trim();
            em.ContraseñaEmpleado = txtContra.Text.Trim();

            return em;
        }




        public static bool ActualizarEmpleado(Empleados em)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "UPDATE empleados SET legajo = @legajo, n_empleado = @nombre, apellido_empleado = @apellido, calle = @calle, nro_calle = @nroCalle, id_barrio = @idBarrio, n_usuario = @nombreUsuario, contraseña = @contraseña WHERE legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", em.LegajoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", em.NombreEmpleado);
                cmd.Parameters.AddWithValue("@apellido", em.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@calle", em.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroCalle", em.NroCalleEmpleado);
                cmd.Parameters.AddWithValue("@idBarrio", em.IdBarrioEmpleado);
                cmd.Parameters.AddWithValue("@nombreUsuario", em.NombreUsuarioEmpleado);
                cmd.Parameters.AddWithValue("@contraseña", em.ContraseñaEmpleado);


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

        public static bool EliminarEmpleado(Empleados em)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "DELETE FROM empleados WHERE legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", em.LegajoEmpleado);

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


        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void CargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM barrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarr.DataSource = tabla;
                cmbBarr.DisplayMember = "n_barrio";
                cmbBarr.ValueMember = "id_barrio";
                cmbBarr.SelectedIndex = -1;

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string leg = "";
            leg = txtLeg.Text.Trim().ToString();
            string nombreUsua = txtNomUsu.Text;
            if (txtContra.Text.Equals(txtRepContra.Text) == true && leg.Length == 5 && !txtNom.Text.Trim().Equals("") && !txtApe.Text.Trim().Equals("") && !txtDire.Text.Trim().Equals("") && !txtNroCall.Text.Trim().Equals("") && !cmbBarr.Text.Trim().Equals("") && !txtNomUsu.Text.Trim().Equals("") && !txtContra.Text.Trim().Equals("") && !txtRepContra.Text.Trim().Equals("") && (AD_Empleados.ValidarAlModificar(nombreUsua) == false || AD_Empleados.ObtenerEmpleado(txtLeg.Text.ToString()).NombreUsuarioEmpleado.Equals(txtNomUsu.Text)))
            {
                //Poner try cach
                Empleados em = ObtenerDatosEmpleado();
                bool resultado = ActualizarEmpleado(em);
                if (resultado)
                {
                    MessageBox.Show("Persona actualizada con éxito");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al actualizar persona");
                }

                //MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDocumento + " " + nroDocumento);
                //MessageBox.Show("Datos de la persona: " + per.NombrePersona + " " + per.ApellidoPersona + " " + per.DocumentoPersona);
            }
            else
            {
                if (AD_Empleados.ValidarAlRegistrar(int.Parse(txtLeg.Text), nombreUsua) == true)
                {
                    MessageBox.Show("Hay un problema, Legajo o nombre de usuario ya se encuentran ocupados");
                }
                else if (txtContra.Text.Equals(txtRepContra.Text) == false)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else if (leg.Length < 5 || txtNom.Text.Trim().Equals("") || txtApe.Text.Trim().Equals("") || txtDire.Text.Trim().Equals("") || txtNroCall.Text.Trim().Equals("") || cmbBarr.Text.Trim().Equals("") || txtNomUsu.Text.Trim().Equals("") || txtContra.Text.Trim().Equals("") || txtRepContra.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Hay un problema, por favor verifique que todos los campos esten completos");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el empleado exitosamente");
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Empleados em = AD_Empleados.ObtenerEmpleado(txtLeg.Text);
            bool resultado = EliminarEmpleado(em);
            if (resultado)
            {
                MessageBox.Show("Empleado eliminado con éxito");
                CargarComboBarrios();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar empleado");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_ABM_empleados ventana = new frm_ABM_empleados();
            ventana.Show();
            this.Close();
        }
    }
}
