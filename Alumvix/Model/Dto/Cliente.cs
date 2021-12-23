using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class Cliente
    {
        #region atributos
        int _id;
        string _identificacionCliente;
        string _nombreCliente;
        string _correoElectronicoCliente;
        string _celularCliente;
        string _telefonoFijoCliente;
        string _direccionCliente;

        public int Id { get => _id; set => _id = value; }
        public string IdentificacionCliente { get => _identificacionCliente; set => _identificacionCliente = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string CorreoElectronicoCliente { get => _correoElectronicoCliente; set => _correoElectronicoCliente = value; }
        public string CelularCliente { get => _celularCliente; set => _celularCliente = value; }
        public string TelefonoFijoCliente { get => _telefonoFijoCliente; set => _telefonoFijoCliente = value; }
        public string DireccionCliente { get => _direccionCliente; set => _direccionCliente = value; }
        #endregion


    }
}
