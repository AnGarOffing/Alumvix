using Alumvix.Model.Dao;
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

        public int ConsultarCantidadContratos(int idCliente)
        {
            ContratoDao contratoDao = new ContratoDao();
            int contadorContratos = contratoDao.ObtenerContratos(idCliente).Count;
            return contadorContratos;
        }

        public static int AplicarIVA(int valor, int idIva)
        {
            ContratoDao contratoDao = new ContratoDao();
            double iva = contratoDao.ConsultarIVA(idIva);
            return (int)(valor * iva) + valor;
        }

        public static int QuitarIVA(int valor)
        {
            return Convert.ToInt32(valor / (1 + new ContratoDao().ConsultarIVA(1)));
        }

        public int SumarTiposDeGastos(int mes, int anio) 
        {
            ReporteDao reporteDao = new ReporteDao();
            int totalGastosPorMes = reporteDao.ObtenerTotalGastosPorMes(mes, anio);
            int totalGastosInternos = reporteDao.ObtenerTotalGastosInternosPorMes(mes, anio);
            int sumaGastos = totalGastosPorMes + totalGastosInternos;
            return sumaGastos;          
        }

        public int SumarTiposDeGastos(int anio)
        {
            ReporteDao reporteDao = new ReporteDao();
            int totalGastosPorAnio = reporteDao.ObtenerTotalGastosPorAnio(anio);
            int totalGastosInternos = reporteDao.ObtenerTotalGastosInternosPorAnio(anio);
            int sumaGastos = totalGastosPorAnio + totalGastosInternos;
            return sumaGastos;
        }
    }
}
