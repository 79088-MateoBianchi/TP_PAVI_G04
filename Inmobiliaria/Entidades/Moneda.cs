using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Moneda
    {
        private int Id;
        private string Nombre;
        private int Cotizacion;


        public Moneda()
        {

        }

        public int IdMoneda { get => Id; set => Id = value; }
        public string NombreMoneda { get => Nombre; set => Nombre = value; }
        public int CotizacionMoneda { get => Cotizacion; set => Cotizacion = value; }
    }
}
