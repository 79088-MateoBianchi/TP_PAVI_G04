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

namespace Inmobiliaria
{
    public partial class frmFiltroDepartamentos : Form
    {
        public frmFiltroDepartamentos()
        {
            InitializeComponent();
        }

        private void frmFiltroDepartamentos_Load(object sender, EventArgs e)
        {
            txtIdEdificio.Focus();
        }

        private void chkTodosDepartamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodosDepartamentos.Checked)
            {
                txtIdEdificio.Text = "";
                txtIdEdificio.Enabled = false;
            } else
            {
                txtIdEdificio.Enabled = true;
            }
        }


        private void LimpiarCampos()
        {
            txtIdEdificio.Text = "";
            txtIdEdificio.Focus();
            chkTodosDepartamentos.Checked = false;
            for (int i = 0; i < grillaDepartamentos.Rows.Count; i++)
            {
                DataGridViewRow deleteRow = grillaDepartamentos.Rows[i];
                grillaDepartamentos.Rows.Remove(deleteRow);
            }
            grillaDepartamentos.Refresh();
        }


        private void CargarGrillaDepartamentos()
        {
            try
            {
                grillaDepartamentos.DataSource = AD_Departamentos.ObtenerDepartamentos();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla");
                throw;
            }
        }

        private void btnBuscarDepartamentos_Click(object sender, EventArgs e)
        {
            if (chkTodosDepartamentos.Checked)
            {
                CargarGrillaDepartamentos();
            }
            else if (txtIdEdificio.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdEdificio.Focus();
            }
            else
            {
                grillaDepartamentos.DataSource = AD_Departamentos.ObtenerDepartamentosPorIdEdificio(int.Parse(txtIdEdificio.Text.Trim()));
                if (grillaDepartamentos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }


        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            frmAltaDepartamento ventana = new frmAltaDepartamento();
            ventana.ShowDialog();
        }

        private void btnSalirDepartamentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grillaDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaDepartamentos.Rows[indice];

            int idEdificio = int.Parse(filaSeleccionada.Cells["idEdificio"].Value.ToString());
            int nroPiso = int.Parse(filaSeleccionada.Cells["Piso"].Value.ToString());
            string denominacion = filaSeleccionada.Cells["Denominacion"].Value.ToString();

            Departamento d = AD_Departamentos.ObtenerDepartamentoPorEdificioPisoDenominacion(idEdificio, nroPiso, denominacion);

            frmModificarEliminarDepartamento ventana = new frmModificarEliminarDepartamento(d);
            ventana.ShowDialog();
        }
    }
}
