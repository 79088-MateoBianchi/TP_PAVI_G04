using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Escribano
    {
        private int Matricula;
        string Nombre;
        string Apellido;

        public int MatriculaEscribano { get => Matricula; set => Matricula = value; }
        public string NombreEscribano { get => Nombre; set => Nombre = value; }
        public string ApellidoEscribano { get => Apellido; set => Apellido = value; }
    }
}
