using System;
using Inmobiliaria.AccesoADatos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frmAltaEmpleado : Form
    {
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboBarrios();
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

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "n_barrio";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;

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
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNroCalle.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtRepContraseña.Text = "";
        }

        private Empleados ObtenerDatosEmpleado()
        {
            Empleados em = new Empleados();
            em.LegajoEmpleado = int.Parse(txtLegajo.Text.Trim());
            em.NombreEmpleado = txtNombre.Text.Trim();
            em.ApellidoEmpleado = txtApellido.Text.Trim();
            em.CalleEmpleado = txtDireccion.Text.Trim();
            em.NroCalleEmpleado = int.Parse(txtNroCalle.Text.Trim());
            em.IdBarrioEmpleado = (int)cmbBarrio.SelectedValue;
            em.NombreUsuarioEmpleado = txtNombreUsuario.Text.Trim();
            em.ContraseñaEmpleado = txtContraseña.Text.Trim();

            return em;
        }




        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            string leg = "";
            leg = txtLegajo.Text.Trim().ToString();
            string nombreUsua = txtNombreUsuario.Text;
            if (txtContraseña.Text.Equals(txtRepContraseña.Text) == true && leg.Length == 5 && !txtNombre.Text.Trim().Equals("") && !txtApellido.Text.Trim().Equals("") && !txtDireccion.Text.Trim().Equals("") && !txtNroCalle.Text.Trim().Equals("") && !cmbBarrio.Text.Trim().Equals("") && !txtNombreUsuario.Text.Trim().Equals("") && !txtContraseña.Text.Trim().Equals("") && !txtRepContraseña.Text.Trim().Equals("") && AD_Empleados.ValidarAlRegistrar(int.Parse(txtLegajo.Text), nombreUsua) == false)
            {
                //Poner try cach
                Empleados em = ObtenerDatosEmpleado();
                bool resultado = AD_Empleados.AgregarEmpleadoABD(em);
                if (resultado)
                {
                    MessageBox.Show("Empleado agregado con éxito");
                    LimpiarCampos();
                    CargarComboBarrios();
                    //CargarComboCarreras();
                    //CargarComboTiposDocumentos();

                }
                else
                {
                    MessageBox.Show("Error al agregar la empleado");
                }

                //MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDocumento + " " + nroDocumento);
                //MessageBox.Show("Datos de la persona: " + per.NombrePersona + " " + per.ApellidoPersona + " " + per.DocumentoPersona);
            }
            else
            {
                if (AD_Empleados.ValidarAlRegistrar(int.Parse(txtLegajo.Text), nombreUsua) == true)
                {
                    MessageBox.Show("Hay un problema, Legajo o nombre de usuario ya se encuentran ocupados");
                }
                else if (txtContraseña.Text.Equals(txtRepContraseña.Text) == false)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else if (leg.Length < 5 || txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || txtDireccion.Text.Trim().Equals("") || txtNroCalle.Text.Trim().Equals("") || cmbBarrio.Text.Trim().Equals("") || txtNombreUsuario.Text.Trim().Equals("") || txtContraseña.Text.Trim().Equals("") || txtRepContraseña.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Hay un problema, por favor verifique que todos los campos esten completos");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el empleado exitosamente");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

