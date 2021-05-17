using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Depto
    {

        private int Id;
        private string Nombre;
        private int IdProvincia;

        public int IdDepto { get => Id; set => Id = value; }
        public string NombreDepto { get => Nombre; set => Nombre = value; }
        public int IdProvinciaDepto { get => IdProvincia; set => IdProvincia = value; }

    }
}
