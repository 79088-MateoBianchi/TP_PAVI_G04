using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Empleados
    {
        private int Legajo;
        private string Nombre;
        private string Apellido;
        private string Calle;
        private int NroCalle;
        private int IdBarrio;
        private int IdUsuario;
        private string NombreUsuario;
        private string Contraseña;

        public Empleados()
        {

        }

        public int LegajoEmpleado { get => Legajo; set => Legajo = value; }
        public string NombreEmpleado { get => Nombre; set => Nombre = value; }
        public string ApellidoEmpleado { get => Apellido; set => Apellido = value; }
        public string CalleEmpleado { get => Calle; set => Calle = value; }
        public int NroCalleEmpleado { get => NroCalle; set => NroCalle = value; }
        public int IdBarrioEmpleado { get => IdBarrio; set => IdBarrio = value; }
        public int IdUsuarioEmpleado { get => IdUsuario; set => IdUsuario = value; }
        public string NombreUsuarioEmpleado { get => NombreUsuario; set => NombreUsuario = value; }
        public string ContraseñaEmpleado { get => Contraseña; set => Contraseña = value; }
    }
}