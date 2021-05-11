using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Edificio
    {
        string n_edificio;
        int cantidad_deptos;
        bool tiene_ascensor;
        string calle;
        int nro_calle;
        int id_barrio;



        public string NombreEdificio
        {
            get => n_edificio;
            set => n_edificio = value;
        }
        public int CantidadDptosEdificio
        {
            get => cantidad_deptos;
            set => cantidad_deptos = value;
        }
        public bool TieneAscensorEdificio
        {
            get => tiene_ascensor;
            set => tiene_ascensor = value;
        }
        public string CalleEdificio
        {
            get => calle;
            set => calle= value;
        }
        public int NumeroCalleEdificio
        {
            get => nro_calle;
            set => nro_calle = value;
        }
        public int IdBarrioEdificio
        {
            get => id_barrio;
            set => id_barrio = value;
        }

    }
}
