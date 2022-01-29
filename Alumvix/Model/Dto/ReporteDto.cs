using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class ReporteDto
    {
        int cantidadClientes;
        int totalVentas;
        int totalGastos;
        int utilidadGeneral;

        public int CantidadClientes { get => cantidadClientes; set => cantidadClientes = value; }
        public int TotalVentas { get => totalVentas; set => totalVentas = value; }
        public int TotalGastos { get => totalGastos; set => totalGastos = value; }
        public int UtilidadGeneral { get => utilidadGeneral; set => utilidadGeneral = value; }
    }
}
