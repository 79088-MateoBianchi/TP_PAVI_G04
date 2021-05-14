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
    public class AD_Escribanos
    {

        public static DataTable ObtenerEscribanos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEscribanos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }
        public static DataTable ObtenerEscribanosPorMatricula(int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEscribanoPorMatricula";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarEscribano(Escribano escribano)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertEscribano";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", escribano.MatriculaEscribano);
                cmd.Parameters.AddWithValue("@nombre", escribano.NombreEscribano);
                cmd.Parameters.AddWithValue("@apellido", escribano.ApellidoEscribano);

                cmd.CommandType = CommandType.StoredProcedure;
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
        public static Escribano ObtenerObjEscribanosPorMatricula(int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Escribano escrib = new Escribano();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEscribanoPorMatricula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    escrib.MatriculaEscribano = int.Parse(dr["matricula"].ToString());
                    escrib.NombreEscribano = dr["n_escribano"].ToString();
                    escrib.ApellidoEscribano = dr["apellido_escribano"].ToString();
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

            return escrib;
        }
        public static bool ActualizarEscribano(Escribano escrib)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateEscribano";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", escrib.MatriculaEscribano);
                cmd.Parameters.AddWithValue("@nombre", escrib.NombreEscribano);
                cmd.Parameters.AddWithValue("@apellido", escrib.ApellidoEscribano);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static bool EliminarEscribano(Escribano escrib)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteEscribano";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", escrib.MatriculaEscribano);

                cmd.CommandType = CommandType.StoredProcedure;
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
        public static bool ExisteEscribano(int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEscribanoPorMatricula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(tabla);
                int filas = tabla.Rows.Count;
                if (filas == 1)
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
    }
}