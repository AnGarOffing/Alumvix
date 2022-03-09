using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class GastoDto
    {
        int idGasto;
        string numeroFactura;
        int valorGasto;
        DateTime fechaGasto;
        string descripcionGasto;
        string proveedor;
        string facturaProveedor;
        string tipoGasto;
        string cliente;
        int numeroContrato;


        public int IdGasto { get => idGasto; set => idGasto = value; }
        public DateTime FechaGasto { get => fechaGasto; set => fechaGasto = value; }
        public string DescripcionGasto { get => descripcionGasto; set => descripcionGasto = value; }
        public int ValorGasto { get => valorGasto; set => valorGasto = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string TipoGasto { get => tipoGasto; set => tipoGasto = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int NumeroContrato { get => numeroContrato; set => numeroContrato = value; }
        public string FacturaProveedor { get => facturaProveedor; set => facturaProveedor = value; }
    }
}
