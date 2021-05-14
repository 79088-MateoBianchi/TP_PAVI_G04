using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            CargarComboTipoDocumento();
            CargarComboBarrio();
        }

        private void CargarComboTipoDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "SELECT * FROM tipos_documentos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                cmbTipoDocumento.DataSource = table;
                cmbTipoDocumento.DisplayMember = "n_tipo_documento";
                cmbTipoDocumento.ValueMember = "id_tipo_documento";
                cmbTipoDocumento.SelectedIndex = -1;

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

        private void CargarComboBarrio() 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "SELECT * FROM barrios";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                cmbBarrioCliente.DataSource = table;
                cmbBarrioCliente.DisplayMember = "n_barrio";
                cmbBarrioCliente.ValueMember = "id_barrio";
                cmbBarrioCliente.SelectedIndex = -1;

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

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro desea crea un cliente?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                try
                {
                    Cliente cl = new Cliente();
                    cl.NombreCliente = txtNombreCliente.Text.ToString().Trim();
                    cl.ApellidoCliente = txtApellidoCliente.Text.ToString().Trim();
                    cl.TipoDocumentoCliente = (int)cmbTipoDocumento.SelectedValue;
                    cl.DocumentoCliente = int.Parse(txtDocumentoCliente.Text.ToString());
                    cl.TelefonoCliente = txtTelefonoCliente.Text.ToString().Trim();
                    cl.CalleCliente = txtCalleCliente.Text.ToString().Trim();
                    cl.NroCasaCliente = int.Parse(txtNroCasaCliente.Text.Trim());
                    cl.IdBarrio = (int)cmbBarrioCliente.SelectedValue;

                    AD_Clientes.AgregarClienteBD(cl);


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al cargar cliente" + ex);
                }
            }
            
        }
    }
}
