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
    public class AD_Proveedores
    {
        public static DataTable ObtenerProveedores()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetProveedores";
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
        public static DataTable ObtenerProveedoresPorId(int Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetProveedoresPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", Id);
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
        public static Proveedor ObtenerObjProveedorPorId(int Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Proveedor prov = new Proveedor();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetProveedoresPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", Id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    prov.IdProveedor = int.Parse(dr["id_proveedor"].ToString());
                    prov.NombreProveedor = dr["n_proveedor"].ToString();
                    prov.DescripcionProveedor = dr["descripcion"].ToString();
                    prov.TelefonoProveedor = dr["tel_proveedor"].ToString();
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
            return prov;
        }
        public static bool AgregarProveedor(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", prov.NombreProveedor);
                cmd.Parameters.AddWithValue("@descripcion", prov.DescripcionProveedor);
                cmd.Parameters.AddWithValue("@telefono", prov.TelefonoProveedor);

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
        public static bool ActualizarProveedor(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", prov.NombreProveedor);
                cmd.Parameters.AddWithValue("@descripcion", prov.DescripcionProveedor);
                cmd.Parameters.AddWithValue("@telefono", prov.TelefonoProveedor);

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
        public static bool EliminarProveedor(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", prov.IdProveedor);
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

        public static bool ExisteProveedorPorId(int Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetProveedoresPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", Id);
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