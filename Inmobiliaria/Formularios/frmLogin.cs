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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") && txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                try
                {
                    resultado = AD_Empleados.ValidarUsuario(nombreDeUsuario, password);
                    if (resultado)
                    { 
                        frmPrincipal ventana = new frmPrincipal();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar el usuario!");
                }
            }
        }
    }
}
