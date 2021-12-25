using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class Cliente
    {

        
        int idCliente;
        string identificacionCliente;
        string nombreCliente;
        string correoElectronicoCliente;
        string celularCliente;
        string telefonoFijoCliente;
        string direccionCliente;


        public int Id { get => idCliente; set => idCliente = value; }
        public string IdentificacionCliente { get => identificacionCliente; set => identificacionCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string CorreoElectronicoCliente { get => correoElectronicoCliente; set => correoElectronicoCliente = value; }
        public string CelularCliente { get => celularCliente; set => celularCliente = value; }
        public string TelefonoFijoCliente { get => telefonoFijoCliente; set => telefonoFijoCliente = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }


    }
}
