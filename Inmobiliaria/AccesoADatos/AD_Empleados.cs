using Inmobiliaria.formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos
{
    public class AD_Empleados
    {

        public static Empleados ObtenerEmpleado(string legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleados em = new Empleados();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM empleados where legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    em.LegajoEmpleado = int.Parse(dr["legajo"].ToString());
                    em.NombreEmpleado = dr["n_empleado"].ToString();
                    em.ApellidoEmpleado = dr["apellido_empleado"].ToString();
                    em.CalleEmpleado = dr["calle"].ToString();
                    em.NroCalleEmpleado = int.Parse(dr["nro_calle"].ToString());
                    em.IdBarrioEmpleado = int.Parse(dr["id_barrio"].ToString());
                    em.IdUsuarioEmpleado = int.Parse(dr["id_usuario"].ToString());
                    em.NombreUsuarioEmpleado = dr["n_usuario"].ToString();
                    em.ContraseñaEmpleado = dr["contraseña"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return em;

        }

        public static DataTable ObtenerListadoEmpleadosReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT legajo, n_empleado, apellido_empleado, n_usuario, contraseña FROM empleados";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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

        public static bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static bool ValidarAlRegistrar(int legajo, string usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM empleados WHERE legajo like @legajo OR n_usuario like @nombreUsua";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.Parameters.AddWithValue("@nombreUsua", usuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static bool ValidarAlModificar(string usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM empleados WHERE n_usuario like @nombreUsua";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsua", usuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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





        public static DataTable ObtenerEmpleadoXLegajo(int parametro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from empleados where legajo = @legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", parametro);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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
    }
}
