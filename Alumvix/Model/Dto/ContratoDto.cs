using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class ContratoDto
    {
        int idContrato;
        string numeroFactura;
        string tipoFactura;
        int valorContrato;
        string fechaInicioContrato;
        string fechaTerminacionContrato;
        string estadoContrato;
        string estadoTrabajo;
        int idCliente;
        List<AbonoDto> gastos = new List<AbonoDto>();
        

        public int IdContrato { get => idContrato; set => idContrato = value; }
        public int ValorContrato { get => valorContrato; set => valorContrato = value; }
        public string FechaInicioContrato { get => fechaInicioContrato; set => fechaInicioContrato = value; }
        public string FechaTerminacionContrato { get => fechaTerminacionContrato; set => fechaTerminacionContrato = value; }
        public string EstadoContrato { get => estadoContrato; set => estadoContrato = value; }
        public string EstadoTrabajo { get => estadoTrabajo; set => estadoTrabajo = value; }
        public int Cliente { get => idCliente; set => idCliente = value; }
        public List<AbonoDto> Gastos { get => gastos; set => gastos = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public string TipoFactura { get => tipoFactura; set => tipoFactura = value; }
    }
}

