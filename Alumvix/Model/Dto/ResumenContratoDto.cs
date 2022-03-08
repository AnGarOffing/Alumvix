using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    public class ResumenContratoDto
    {
        DateTime fechaInicioContrato;
        string nombreCliente;
        int numeroFactura;
        string tipoFactura;
        int valorFactura;
        string categoria;

        public DateTime FechaInicioContrato { get => fechaInicioContrato; set => fechaInicioContrato = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public string TipoFactura { get => tipoFactura; set => tipoFactura = value; }
        public int ValorFactura { get => valorFactura; set => valorFactura = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
