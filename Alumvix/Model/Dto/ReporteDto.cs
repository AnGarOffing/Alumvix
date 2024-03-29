﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class ReporteDto
    {
        int indiceMes;
        string mes;
        int cantidadContratos;
        int totalVentas;
        int totalGastos;
        int utilidadGeneral;

        public int CantidadContratos { get => cantidadContratos; set => cantidadContratos = value; }
        public int TotalVentas { get => totalVentas; set => totalVentas = value; }
        public int TotalGastos { get => totalGastos; set => totalGastos = value; }
        public int UtilidadGeneral { get => utilidadGeneral; set => utilidadGeneral = value; }
        public string Mes { get => mes; set => mes = value; }
        public int IndiceMes { get => indiceMes; set => indiceMes = value; }
    }
}
