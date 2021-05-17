using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Proveedor
    {
        private int Id;
        private string Nombre;
        private string Descripcion;
        private string Telefono;

        public int IdProveedor { get => Id; set => Id = value; }
        public string NombreProveedor { get => Nombre; set => Nombre = value; }
        public string DescripcionProveedor { get => Descripcion; set => Descripcion = value; }
        public string TelefonoProveedor { get => Telefono; set => Telefono = value; }
    }
}
