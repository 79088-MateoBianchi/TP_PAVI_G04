using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos
{
    public class AD_Localidades
    {
        public static Localidades ObtenerLocalidad(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Localidades loc = new Localidades();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM localidades where id_localidad like @id_localidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_localidad", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    loc.IdLocalidad = int.Parse(dr["id_localidad"].ToString());
                    loc.NombreLocalidad = dr["n_localidad"].ToString();
                    loc.IdDepartamentoLocalidad = int.Parse(dr["id_departamento"].ToString());
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

            return loc;

        }


        public static DataTable ObtenerLocalidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id_localidad, n_localidad, n_departamento FROM localidades INNER JOIN deptos ON localidades.id_departamento = deptos.id_departamento";

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

        public static bool AgregarLocalidadABD(Localidades loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "INSERT INTO localidades (n_localidad, id_departamento) VALUES (@nombre, @idDepartamento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", loc.NombreLocalidad);
                cmd.Parameters.AddWithValue("@idDepartamento", loc.IdDepartamentoLocalidad);
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


        public static bool ValidarAlRegistrar(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM localidades WHERE n_localidad like @nombreLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreLocalidad", nombre);
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

        public static DataTable ObtenerLocalidadXNombre(string parametro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id_localidad, n_localidad, n_departamento FROM localidades INNER JOIN deptos ON localidades.id_departamento = deptos.id_departamento where n_localidad = @localidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@localidad", parametro);
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
