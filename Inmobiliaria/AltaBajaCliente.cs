using Inmobiliaria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class AltaBajaCliente : Form
    {
        public AltaBajaCliente()
        {
            InitializeComponent();
   
        }
        private void AltaBajaCliente_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrClientes.DataSource = AD_Clientes.ObtenerListadoClientes();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Obtener Edificios");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente ventana = new NuevoCliente();
            ventana.Show();
        }

        private void gdrClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrClientes.Rows[indice];
            int documento = int.Parse(filaSeleccionada.Cells["Documento"].Value.ToString());
            ModificarCliente ventana = new ModificarCliente(documento);
            ventana.Show();
        } 
    }
}
