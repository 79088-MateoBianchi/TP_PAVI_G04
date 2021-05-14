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
    public class AD_Propiedades
    {
        public static DataTable ObtenerPropiedades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPropiedades";

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
        public static bool AgregarPropiedad(Propiedad prop)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertPropiedad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@designacionCatastral", prop.DesignacionCatastralPropiedad);
                cmd.Parameters.AddWithValue("@calle", prop.CallePropiedad);
                cmd.Parameters.AddWithValue("@nroCalle", prop.NroCallePropiedad);
                cmd.Parameters.AddWithValue("@idBarrio", prop.IdBarrioPropiedad);
                cmd.Parameters.AddWithValue("@piso", prop.PisoPropiedad);
                cmd.Parameters.AddWithValue("@depto", prop.DepartamentoPropiedad);
                cmd.Parameters.AddWithValue("@idTipoProp", prop.IdTipoPropPropiedad);
                cmd.Parameters.AddWithValue("@monto", prop.MontoPropiedad);
                cmd.Parameters.AddWithValue("@idMoneda", prop.IdMonedaPropiedad);
                cmd.Parameters.AddWithValue("@idTipoOperacion", prop.IdTipoOperacionPropiedad);

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

        public static Propiedad ObtenerPropiedadPorDesigCatastral(int desigCatastral)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Propiedad p = new Propiedad();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPropPorDesigCatastral";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desigCatastral", desigCatastral);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.DesignacionCatastralPropiedad = int.Parse(dr["designacion_catastral"].ToString());
                    p.CallePropiedad = dr["calle"].ToString();
                    p.NroCallePropiedad = int.Parse(dr["nro_calle"].ToString());
                    p.IdBarrioPropiedad = int.Parse(dr["id_barrio"].ToString());
                    p.PisoPropiedad = int.Parse(dr["piso"].ToString());
                    p.DepartamentoPropiedad = dr["departamento"].ToString();
                    p.IdTipoPropPropiedad = int.Parse(dr["id_tipo_propiedad"].ToString());
                    p.MontoPropiedad = int.Parse(dr["monto"].ToString());
                    p.IdMonedaPropiedad = int.Parse(dr["id_moneda"].ToString());
                    p.IdTipoOperacionPropiedad = int.Parse(dr["id_tipo_operacion"].ToString());
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



            return p;
        }
        public static bool ActualizarPropiedad(Propiedad p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdatePropiedad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desigCatastral", p.DesignacionCatastralPropiedad);
                cmd.Parameters.AddWithValue("@calle", p.CallePropiedad);
                cmd.Parameters.AddWithValue("@nroCalle", p.NroCallePropiedad);
                cmd.Parameters.AddWithValue("@piso", p.PisoPropiedad);
                cmd.Parameters.AddWithValue("@depto", p.DepartamentoPropiedad);
                cmd.Parameters.AddWithValue("@idBarrio", p.IdBarrioPropiedad);
                cmd.Parameters.AddWithValue("@idTipoProp", p.IdTipoPropPropiedad);
                cmd.Parameters.AddWithValue("@idTipoOperacion", p.IdTipoOperacionPropiedad);
                cmd.Parameters.AddWithValue("@monto", p.MontoPropiedad);
                cmd.Parameters.AddWithValue("@moneda", p.IdMonedaPropiedad);

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
        public static bool EliminarPropiedad(Propiedad p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeletePropiedad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desigCatastral", p.DesignacionCatastralPropiedad);

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

        public static DataTable GetPropiedadesPorDesigCatastral(int designacionCatastral)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPropPorDesigCatastral";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desigCatastral", designacionCatastral);
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
        public static bool ExistePropiedad(int desigCat)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPropPorDesigCatastral";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desigCatastral", desigCat);
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
