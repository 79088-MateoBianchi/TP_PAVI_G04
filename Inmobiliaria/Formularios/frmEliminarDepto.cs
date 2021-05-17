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
    public partial class frmEliminarDepto : Form
    {
        public frmEliminarDepto(Depto d)
        {
            InitializeComponent();

            txtNroDepto.Text = d.IdDepto.ToString();
            txtNombreDepto.Text = d.NombreDepto.ToString();
            txtNroProvincia.Text = d.IdProvinciaDepto.ToString();
        }


        private Depto ObternerDatosDepto()
        {
            Depto d = new Depto();

            d.IdDepto = int.Parse(txtNroDepto.Text.Trim());
            d.NombreDepto = txtNombreDepto.Text.Trim();
            d.IdProvinciaDepto = int.Parse(txtNroProvincia.Text.Trim());

            return d;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el departamento seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Depto d = ObternerDatosDepto();
                bool resultado = AD_Deptos.EliminarDepto(d);
                if (resultado)
                {
                    MessageBox.Show("Departamento eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el departamento!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la eliminación del departamento?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
