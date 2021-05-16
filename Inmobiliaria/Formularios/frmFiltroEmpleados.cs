using Inmobiliaria.AccesoADatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frm_ABM_empleados : Form
    {
        public frm_ABM_empleados()
        {
            InitializeComponent();

            //    cmbColumna.Items.Add("Legajo");
            //    cmbColumna.Items.Add("Nombre");
            //    cmbColumna.Items.Add("Apellido");
        }

        //private void filtrar(string criterio, string campo)
        //{
        //    gdrEmpleados.DataSource = AD_Empleados.ObtenerListadoEmpleadosReducido();
        //}


        private void frm_ABM_empleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                gdrEmpleados.DataSource = AD_Empleados.ObtenerListadoEmpleadosReducido();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener empleados");
            }

        }


        private void gdrEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrilla();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrEmpleados.Rows[indice];
                string legajo = filaSeleccionada.Cells["LegajoEmpleado"].Value.ToString();
                Empleados em = AD_Empleados.ObtenerEmpleado(legajo);
                frmModificarEmpleado vent = new frmModificarEmpleado(em);
                //CargarCampos(em);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }

        //private void CargarCampos(Empleados em)
        //{
        //    frmModificarEmpleado vent = new frmModificarEmpleado();
        //    vent.txtLeg.Text = em.LegajoEmpleado.ToString();
        //    vent.txtNom.Text = em.NombreEmpleado;
        //    vent.txtApe.Text = em.ApellidoEmpleado;
        //    vent.txtDire.Text = em.CalleEmpleado;
        //    vent.txtNroCall.Text = em.NroCalleEmpleado.ToString();
        //    vent.cmbBarr.SelectedValue = em.IdBarrioEmpleado;
        //    vent.txtIDUsu.Text = em.IdUsuarioEmpleado.ToString();
        //    vent.txtNomUsu.Text = em.NombreUsuarioEmpleado;
        //    vent.txtContra.Text = em.ContraseñaEmpleado;
        //    vent.txtRepContra.Text = em.ContraseñaEmpleado;
        //    vent.ShowDialog();
        //}

        //private Empleados ObtenerEmpleado(string legajo)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    Empleados em = new Empleados();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "SELECT * FROM empleados where legajo like @legajo";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@legajo", legajo);

        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null && dr.Read())
        //        {
        //            em.LegajoEmpleado = int.Parse(dr["legajo"].ToString());
        //            em.NombreEmpleado = dr["n_empleado"].ToString();
        //            em.ApellidoEmpleado = dr["apellido_empleado"].ToString();
        //            em.CalleEmpleado = dr["calle"].ToString();
        //            em.NroCalleEmpleado = int.Parse(dr["nro_calle"].ToString());
        //            em.IdBarrioEmpleado = int.Parse(dr["id_barrio"].ToString());
        //            em.IdUsuarioEmpleado = int.Parse(dr["id_usuario"].ToString());
        //            em.NombreUsuarioEmpleado = dr["n_usuario"].ToString();
        //            em.ContraseñaEmpleado = dr["contraseña"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }

        //    return em;

        //}


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorLegajo.Text.Equals(""))
                {
                    CargarGrilla();
                    MessageBox.Show("Ingrese algun legajo");
                }
                else
                {
                    DataTable tablaResultado = AD_Empleados.ObtenerEmpleadoXLegajo(int.Parse(txtFiltrarPorLegajo.Text.Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        gdrEmpleados.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Empleado Inexistente");
                        txtFiltrarPorLegajo.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado ventana = new frmAltaEmpleado();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }

}

