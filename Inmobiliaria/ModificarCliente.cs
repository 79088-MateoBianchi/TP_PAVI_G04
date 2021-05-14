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
    public partial class ModificarCliente : Form
    {
        private readonly int docu;

        public ModificarCliente(int doc)
        {
            docu = doc;
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            Cliente cl = AD_Clientes.ObtenerCliente(docu);
            CargarComboBarrio();
            CargarCampos(cl);
        }

        private void CargarCampos(Cliente cl)
        {
            txtNombreCliente.Text = cl.NombreCliente;
            txtApellidoCliente.Text = cl.ApellidoCliente;
            txtTelefonoCliente.Text = cl.TelefonoCliente;
            txtCalleCliente.Text = cl.CalleCliente;
            txtNroCasaCliente.Text = cl.NroCasaCliente.ToString();
            cmbBarrioCliente.SelectedIndex = cl.IdBarrio - 1;
            

            
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro desea crea un cliente?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Cliente cl = AD_Clientes.ObtenerCliente(docu);
                cl.NombreCliente = txtNombreCliente.Text.ToString().Trim();
                cl.ApellidoCliente = txtApellidoCliente.Text.ToString().Trim();
                cl.TelefonoCliente = txtTelefonoCliente.Text.ToString().Trim();
                cl.CalleCliente = txtCalleCliente.Text.ToString().Trim();
                cl.NroCasaCliente = int.Parse(txtNroCasaCliente.Text.Trim());
                cl.IdBarrio = (int)cmbBarrioCliente.SelectedValue;

                AD_Clientes.ActualizarCliente(cl);
                Close();
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
    }
}
