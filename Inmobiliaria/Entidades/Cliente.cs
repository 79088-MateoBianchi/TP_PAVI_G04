using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Cliente
    {
        int nro_documento_c;
        int tipo_documento_c;
        string n_cliente;
        string apellido_cliente;
        int tel_client;
        string calle;
        int nro_calle;
        int id_barrio;

        public int DocumentoCliente
        {
            get => nro_documento_c;
            set => nro_documento_c = value;
        }

        public int TipoDocumentoCliente
        {
            get => tipo_documento_c;
            set => tipo_documento_c = value;
        }

        public string NombreCliente
        {
            get => n_cliente;
            set => n_cliente = value;
        }

        public string ApellidoCliente
        {
            get => apellido_cliente;
            set => apellido_cliente = value;
        }

        public int TelefonoCliente
        {
            get => tel_client;
            set => tel_client = value;
        }

        public string CalleCliente
        {
            get => calle;
            set => calle = value;
        }

        public int NroCasaCliente
        {
            get => nro_calle;
            set => nro_calle = value;
        }

        public int IdBarrio
        {
            get => id_barrio;
            set => id_barrio = value;
        }


    }
}
