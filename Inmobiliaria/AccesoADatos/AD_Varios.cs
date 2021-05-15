using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos
{
    class AD_Varios
    {
        public static bool AgregarEmpleadoABD(Empleados em)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "INSERT INTO empleados (legajo, n_empleado, apellido_empleado, calle, nro_calle, id_barrio, n_usuario, contraseña) VALUES (@legajo, @nombre, @apellido, @calle, @nroCalle, @idBarrio, @nombreUsuario, @contraseña)";
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
    }
}
