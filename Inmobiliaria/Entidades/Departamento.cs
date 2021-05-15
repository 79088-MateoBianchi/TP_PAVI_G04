using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Departamento
    {

        private int IdEdificio;
        private int Piso;
        private string Denominacion;
        private int Superficie;
        private float PorcentajeEdificio;
        private int LegajoEncargadoExpensas;

        public int IdEdificioDepartamento { get => IdEdificio; set => IdEdificio = value; }
        public int PisoDepartamento { get => Piso; set => Piso = value; }
        public string DenominacionDepartamento { get => Denominacion; set => Denominacion = value; }
        public int SuperficieDepartamento { get => Superficie; set => Superficie = value; }
        public float PorcentajeEdificioDepartamento { get => PorcentajeEdificio; set => PorcentajeEdificio = value; }
        public int LegajoEncargadoExpensasDepartamento { get => LegajoEncargadoExpensas; set => LegajoEncargadoExpensas = value; }

    }
}
