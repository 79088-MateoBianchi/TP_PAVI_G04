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
    public class AD_Edificios
    {
        public static DataTable ObtenerListadoEdificios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT n_edificio, cantidad_deptos, tiene_ascensor, calle, nro_calle, id_barrio FROM edificios";
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

        public static bool AgregarEdificioBD(Edificio ed)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO edificios(n_edificio, cantidad_deptos, tiene_ascensor, calle, nro_calle, id_barrio) VALUES (@nombreEdificio, @cantidadDptos, @tieneAscensor, @Calle, @numeroCalle, @idBarrio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", ed.NombreEdificio);
                cmd.Parameters.AddWithValue("@cantidadDptos", ed.CantidadDptosEdificio);
                cmd.Parameters.AddWithValue("@tieneAscensor", ed.TieneAscensorEdificio);
                cmd.Parameters.AddWithValue("@Calle", ed.CalleEdificio);
                cmd.Parameters.AddWithValue("@numeroCalle", ed.NumeroCalleEdificio);
                cmd.Parameters.AddWithValue("@idBarrio", ed.IdBarrioEdificio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;



            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;

        }

        public static Edificio ObtenerEdificio(string nombreEdificio)
        {
            Edificio ed = new Edificio();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM edificios where n_edificio like @nombreEdificio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", nombreEdificio);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); 
                if (dr != null && dr.Read())
                {
                    ed.NombreEdificio = dr["n_edificio"].ToString();
                    ed.CantidadDptosEdificio = int.Parse(dr["cantidad_deptos"].ToString());
                    ed.TieneAscensorEdificio = bool.Parse(dr["tiene_ascensor"].ToString());
                    ed.CalleEdificio = dr["calle"].ToString();
                    ed.NumeroCalleEdificio = int.Parse(dr["nro_calle"].ToString());
                    ed.IdBarrioEdificio = int.Parse(dr["id_barrio"].ToString());


                }
                else
                {

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
            return ed;

        }

        public static bool ActualizarEdificio(Edificio ed)
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
                string consulta = "UPDATE edificios SET n_edificio = @nombreEdificio, cantidad_deptos = @cantidadDptos, tiene_ascensor = @tieneAscensor, calle = @Calle, nro_calle = @numeroCalle, id_barrio = @idBarrio WHERE n_edificio like @nombreEdificio";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombreEdificio", ed.NombreEdificio);
                cmd.Parameters.AddWithValue("@cantidadDptos", ed.CantidadDptosEdificio);
                cmd.Parameters.AddWithValue("@tieneAscensor", ed.TieneAscensorEdificio);
                cmd.Parameters.AddWithValue("@Calle", ed.CalleEdificio);
                cmd.Parameters.AddWithValue("@numeroCalle", ed.NumeroCalleEdificio);
                cmd.Parameters.AddWithValue("@idBarrio", ed.IdBarrioEdificio);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }

    }
}
