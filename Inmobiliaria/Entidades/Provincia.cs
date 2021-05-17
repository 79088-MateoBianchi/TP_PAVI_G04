using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Provincia
    {

        private int Id;
        private string Nombre;

        public int IdProvincia { get => Id; set => Id = value; }
        public string NombreProvincia { get => Nombre; set => Nombre = value; }

    }
}
