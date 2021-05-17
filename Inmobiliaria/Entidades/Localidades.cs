using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Localidades
    {
        private int IdLocal;
        private string Nombre;
        private int IdDepartamento;

        public Localidades()
        {

        }

        public int IdLocalidad { get => IdLocal; set => IdLocal = value; }
        public string NombreLocalidad { get => Nombre; set => Nombre = value; }
        public int IdDepartamentoLocalidad { get => IdDepartamento; set => IdDepartamento = value; }
    }
}
