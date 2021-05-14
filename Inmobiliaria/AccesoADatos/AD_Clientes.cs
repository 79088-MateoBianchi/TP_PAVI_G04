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
    public class AD_Clientes
    {
        public static DataTable ObtenerListadoClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT nro_documento_c,tipo_documento_c, n_cliente, apellido_cliente,tel_cliente, calle, nro_calle, id_barrio FROM clientes";
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
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarClienteBD(Cliente cl)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO clientes(nro_documento_c, tipo_documento_c, n_cliente, apellido_cliente, tel_cliente, calle, nro_calle, id_barrio) VALUES (@documentoCliente, @tipoDocumento, @nombreCliente,@apellidoCliente,@telefonoCliente, @Calle, @numeroCalle, @idBarrio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documentoCliente", cl.DocumentoCliente);
                cmd.Parameters.AddWithValue("@tipoDocumento", cl.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nombreCliente", cl.NombreCliente);
                cmd.Parameters.AddWithValue("@apellidoCliente", cl.ApellidoCliente);
                cmd.Parameters.AddWithValue("@telefonoCliente", cl.TelefonoCliente);
                cmd.Parameters.AddWithValue("@Calle", cl.CalleCliente);
                cmd.Parameters.AddWithValue("@numeroCalle", cl.NroCasaCliente);
                cmd.Parameters.AddWithValue("@idBarrio", cl.IdBarrio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }


        public static Cliente ObtenerCliente(int documento)
        {
            Cliente cl = new Cliente();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM clientes where nro_documento_c like @documentoCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documentoCliente", documento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    cl.DocumentoCliente = int.Parse(dr["nro_documento_c"].ToString());
                    cl.TipoDocumentoCliente = int.Parse(dr["tipo_documento_c"].ToString());
                    cl.NombreCliente = dr["n_cliente"].ToString();
                    cl.ApellidoCliente = dr["apellido_cliente"].ToString();
                    cl.TelefonoCliente = dr["tel_cliente"].ToString();

                    cl.CalleCliente = dr["calle"].ToString();
                    cl.NroCasaCliente = int.Parse(dr["nro_calle"].ToString());
                    cl.IdBarrio = int.Parse(dr["id_barrio"].ToString());


                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return cl;
        }

        public static bool ActualizarCliente(Cliente cl)
        {

            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE clientes SET nro_documento_c = @documentoCliente, tipo_documento_c = @tipoDocumento, n_cliente = @nombreCliente,apellido_cliente = @apellidoCliente,tel_cliente = @telefonoCliente, calle = @Calle, nro_calle = @numeroCalle, id_barrio = @idBarrio WHERE nro_documento_c like @documentoCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documentoCliente", cl.DocumentoCliente);
                cmd.Parameters.AddWithValue("@tipoDocumento", cl.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nombreCliente", cl.NombreCliente);
                cmd.Parameters.AddWithValue("@apellidoCliente", cl.ApellidoCliente);
                cmd.Parameters.AddWithValue("@telefonoCliente", cl.TelefonoCliente);
                cmd.Parameters.AddWithValue("@Calle", cl.CalleCliente);
                cmd.Parameters.AddWithValue("@numeroCalle", cl.NroCasaCliente);
                cmd.Parameters.AddWithValue("@idBarrio", cl.IdBarrio);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

            
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }
    }
}
