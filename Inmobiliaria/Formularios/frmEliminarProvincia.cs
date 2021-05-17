using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frmEliminarProvincia : Form
    {
        public frmEliminarProvincia(Provincia p)
        {
            InitializeComponent();

            txtNroProvincia.Text = p.IdProvincia.ToString();
            txtNombreProvincia.Text = p.NombreProvincia;
        }


        private Provincia ObtenerDatosProvincia()
        {
            Provincia p = new Provincia();

            p.IdProvincia = int.Parse(txtNroProvincia.Text.Trim());
            p.NombreProvincia = txtNombreProvincia.Text.Trim();

            return p;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar la provincia seleccionada?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Provincia p = ObtenerDatosProvincia();
                bool resultado = AD_Provincias.EliminarProvincia(p);
                if (resultado)
                {
                    MessageBox.Show("Provincia eliminada con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la provincia!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la eliminación de la provincia?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
