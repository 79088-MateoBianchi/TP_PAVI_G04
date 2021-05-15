using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Propiedad
    {
        private int DesignacionCatastral;
        private string Calle;
        private int NroCalle;
        private int IdBarrio;
        private int Piso;
        private string Departamento;
        private int IdTipoPropiedad;
        private int Monto;
        private int IdMoneda;
        private int IdTipoOperacion;

        public int DesignacionCatastralPropiedad { get => DesignacionCatastral; set => DesignacionCatastral = value; }
        public string CallePropiedad { get => Calle; set => Calle = value; }
        public int NroCallePropiedad { get => NroCalle; set => NroCalle = value; }
        public int IdBarrioPropiedad { get => IdBarrio; set => IdBarrio = value; }
        public int PisoPropiedad { get => Piso; set => Piso = value; }
        public string DepartamentoPropiedad { get => Departamento; set => Departamento = value; }
        public int IdTipoPropPropiedad { get => IdTipoPropiedad; set => IdTipoPropiedad = value; }
        public int MontoPropiedad { get => Monto; set => Monto = value; }
        public int IdMonedaPropiedad { get => IdMoneda; set => IdMoneda = value; }
        public int IdTipoOperacionPropiedad { get => IdTipoOperacion; set => IdTipoOperacion = value; }
    }
}
