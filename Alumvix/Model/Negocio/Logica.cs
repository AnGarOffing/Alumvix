using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Negocio
{
    internal class Logica
    {
        int acumulador;

        public int SumarGastos(List<GastoDto> gastos)
        {
            acumulador = 0;
            foreach (GastoDto gasto in gastos)
            {
                acumulador += gasto.ValorGasto;
            }
            return acumulador;
        }

        public int SumarAbonos(List<AbonoDto> abonos)
        {
            acumulador = 0;
            foreach (AbonoDto abono in abonos)
            {
                acumulador += abono.ValorAbono;
            }
            return acumulador;
        }

        public int ObtenerRestantePorPagar(int totalAbonos, int valorContrato) 
        {
            return valorContrato - totalAbonos;
        }

        public int ObtenerUtilidad(int totalAbonos, int totalGastos)
        {
            int utilidad = totalAbonos - totalGastos;
            if (utilidad < 0)
            {
                utilidad = 0;
            }
            return utilidad;
        }
    }
}
