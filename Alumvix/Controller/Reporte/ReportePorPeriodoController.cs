using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Reporte
{
    internal class ReportePorPeriodoController
    {
        ReportePorPeriodoView reportePorPeriodoView;
        public ReportePorPeriodoController(ReportePorPeriodoView reportePorPeriodoVista)
        {
            reportePorPeriodoView = reportePorPeriodoVista;
            reportePorPeriodoView.btnConsultarReportePorPeriodo.Click += new EventHandler(MostrarCuentasPorPeriodo);
        }

        private void MostrarCuentasPorPeriodo(object sender, EventArgs e)
        {
            LimpiarCampos();
            string fechaInicial = reportePorPeriodoView.dtpFechaInicioReporte.Text;
            string fechaFinal = reportePorPeriodoView.dtpFechaFinalReporte.Text;
            ReporteDto reporteDto = new ReporteDao().ObtenerCuentasPorPeriodo(fechaInicial, fechaFinal);
            reportePorPeriodoView.txtCantidadContratos.Text = reporteDto.CantidadContratos.ToString();
            reportePorPeriodoView.txtTotalVentas.Text = reporteDto.TotalVentas.ToString();
            int totalGastosInternos = new GastoInternoDao().ObtenerTotalGastosInternosPorPeriodo(fechaInicial, fechaFinal);
            int totalTiposDeGastos = reporteDto.TotalGastos + totalGastosInternos;
            reportePorPeriodoView.txtTotalGastos.Text = totalTiposDeGastos.ToString();
            int utilidad = reporteDto.TotalVentas - totalTiposDeGastos;
            reportePorPeriodoView.txtUtilidadGeneral.Text = utilidad.ToString();
        }

        private void MostrarGastosTotalesPorPeriodo(object sender, EventArgs e)
        {
            string fechaInicial = reportePorPeriodoView.dtpFechaInicioReporte.Text;
            string fechaFinal = reportePorPeriodoView.dtpFechaFinalReporte.Text;
            reportePorPeriodoView.lstvGastosTotalesPorPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorPeriodo(fechaInicial, fechaFinal);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reportePorPeriodoView.lstvGastosTotalesPorPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorPeriodo(fechaInicial, fechaFinal);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reportePorPeriodoView.lstvGastosTotalesPorPeriodo.Items.Add(itemGastoInterno);
            }
        }

        private void LimpiarCampos()
        {
            reportePorPeriodoView.txtCantidadContratos.Text = "";
            reportePorPeriodoView.txtTotalVentas.Text = "";
            reportePorPeriodoView.txtTotalGastos.Text = "";
            reportePorPeriodoView.txtUtilidadGeneral.Text = "";
        }
    }
}
