using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class ProveedorDto
    {
        string nombreProveedor;
        string celularProveedor;
        string telefonoFijoProveedor;
        string direccionProveedor;

        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string CelularProveedor { get => celularProveedor; set => celularProveedor = value; }
        public string TelefonoFijoProveedor { get => telefonoFijoProveedor; set => telefonoFijoProveedor = value; }
        public string DireccionProveedor { get => direccionProveedor; set => direccionProveedor = value; }
    }
}
