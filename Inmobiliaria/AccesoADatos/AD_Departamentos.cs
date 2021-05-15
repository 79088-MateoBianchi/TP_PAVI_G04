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
    public class AD_Departamentos
    {
        public static DataTable ObtenerDepartamentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDepartamentos";

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


        public static DataTable ObtenerDepartamentosPorIdEdificio(int idEdificio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDepartamentosPorIdEdificio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", idEdificio);
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


        public static Departamento ObtenerDepartamentoPorEdificioPisoDenominacion(int idEdificio, int nroPiso, string denominacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Departamento d = new Departamento();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDepartamentoPorEdificioPisoDenominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", idEdificio);
                cmd.Parameters.AddWithValue("@nroPiso", nroPiso);
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    d.IdEdificioDepartamento = int.Parse(dr["id_edificio"].ToString());
                    d.PisoDepartamento = int.Parse(dr["piso"].ToString());
                    d.DenominacionDepartamento = dr["denominacion"].ToString();
                    d.SuperficieDepartamento = int.Parse(dr["superficie"].ToString());
                    d.PorcentajeEdificioDepartamento = float.Parse(dr["porcentaje_edificio"].ToString());
                    d.LegajoEncargadoExpensasDepartamento = int.Parse(dr["legajo_encargado_exp"].ToString());

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

            return d;
        }


        public static bool EliminarDepartamento(Departamento d)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", d.IdEdificioDepartamento);
                cmd.Parameters.AddWithValue("@nroPiso", d.PisoDepartamento);
                cmd.Parameters.AddWithValue("@denominacion", d.DenominacionDepartamento);

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


        public static bool ActualizarDepartamento(Departamento d)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", d.IdEdificioDepartamento);
                cmd.Parameters.AddWithValue("@nroPiso", d.PisoDepartamento);
                cmd.Parameters.AddWithValue("@denominacion", d.DenominacionDepartamento);
                cmd.Parameters.AddWithValue("@superficie", d.SuperficieDepartamento);
                cmd.Parameters.AddWithValue("@porcentajeEdificio", d.PorcentajeEdificioDepartamento);
                cmd.Parameters.AddWithValue("@legajoEncargadoExp", d.LegajoEncargadoExpensasDepartamento);

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


        public static bool ExisteDepartamento(int idEdificio, int nroPiso, string denominacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDepartamentoPorEdificioPisoDenominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", idEdificio);
                cmd.Parameters.AddWithValue("@nroPiso", nroPiso);
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
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


        public static bool AgregarDepartamento(Departamento d)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEdificio", d.IdEdificioDepartamento);
                cmd.Parameters.AddWithValue("@nroPiso", d.PisoDepartamento);
                cmd.Parameters.AddWithValue("@denominacion", d.DenominacionDepartamento);
                cmd.Parameters.AddWithValue("@superficie", d.SuperficieDepartamento);
                cmd.Parameters.AddWithValue("@porcentajeEdificio", d.PorcentajeEdificioDepartamento);
                cmd.Parameters.AddWithValue("@legajoEncargadoExp", d.LegajoEncargadoExpensasDepartamento);

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
    }
}
