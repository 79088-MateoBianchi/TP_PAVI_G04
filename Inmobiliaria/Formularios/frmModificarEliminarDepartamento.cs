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
    public partial class frmModificarEliminarDepartamento : Form
    {
        public frmModificarEliminarDepartamento(Departamento d)
        {
            InitializeComponent();

            txtNroEdificio.Text = d.IdEdificioDepartamento.ToString();
            txtNroPiso.Text = d.PisoDepartamento.ToString();
            txtDenominacion.Text = d.DenominacionDepartamento;
            txtSuperficie.Text = d.SuperficieDepartamento.ToString();
            txtPorcentajeEdificio.Text = d.PorcentajeEdificioDepartamento.ToString();
            txtLegajoEncExp.Text = d.LegajoEncargadoExpensasDepartamento.ToString();

        }


        private Departamento ObtenerDatosDepartamento()
        {
            Departamento d = new Departamento();

            d.IdEdificioDepartamento = int.Parse(txtNroEdificio.Text.Trim());
            d.PisoDepartamento = int.Parse(txtNroPiso.Text.Trim());
            d.DenominacionDepartamento = txtDenominacion.Text.Trim();
            d.SuperficieDepartamento = int.Parse(txtSuperficie.Text.Trim());
            d.PorcentajeEdificioDepartamento = float.Parse(txtPorcentajeEdificio.Text.Trim());
            d.LegajoEncargadoExpensasDepartamento = int.Parse(txtLegajoEncExp.Text.Trim());

            return d;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el departamento seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Departamento d = ObtenerDatosDepartamento();
                bool resultado = AD_Departamentos.EliminarDepartamento(d);
                if (resultado)
                {
                    MessageBox.Show("Propiedad eliminada con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la propiedad!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroEdificio.Text.Equals("") || txtNroPiso.Text.Equals("") || txtDenominacion.Text.Equals("") || txtSuperficie.Text.Equals("") || txtPorcentajeEdificio.Text.Equals("") || txtLegajoEncExp.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult aviso = MessageBox.Show("¿Desea confirmar las modificaciones realizadas?", "Confirmar modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aviso == DialogResult.Yes)
                {
                    Departamento d = ObtenerDatosDepartamento();
                    bool resultado = AD_Departamentos.ActualizarDepartamento(d);
                    if (resultado)
                    {
                        MessageBox.Show("Propiedad actualizada con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la propiedad!");
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la edicion de la propiedad?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
