using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;
using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Reporte
{
    internal class ReporteAnualController
    {
        ReporteAnualView reporteAnualView;
        AdministradorReportesView administradorReportesView;

        public ReporteAnualController(ReporteAnualView reporteAnualVista)
        {
            reporteAnualView = reporteAnualVista;
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            reporteAnualView.Load += new EventHandler(MostrarReporteAnual);
            reporteAnualView.Load += new EventHandler(MostrarReporteMensualPorAnio);
            reporteAnualView.btnDetalleGastos.Click += new EventHandler(MostrarGastosTotalesPorAnio);
        }
        
        private void MostrarReporteMensualPorAnio(object sender, EventArgs e)
        {
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            reporteAnualView.lstvReporteMensualPorAnio.Items.Clear();
            ReporteDao reporteDao = new ReporteDao();
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            List<ReporteDto> listadoCuentas = reporteDao.ObtenerCuentasMesDeUnAnio(AdministradorReportesController.AnioSeleccionado);
            List<int> listadoIndicesMeses = reporteDao.ObtenerIndicesDeMeses(AdministradorReportesController.AnioSeleccionado);
            int[] arregloIndices = new int[listadoIndicesMeses.Count];
            arregloIndices = listadoIndicesMeses.ToArray();
            int indice = 0;
            int totalTiposDeGastos = 0;
            int utilidad = 0;
            foreach (ReporteDto reporteDto in listadoCuentas)
            {
                totalTiposDeGastos = reporteDto.TotalGastos + reporteDao.ObtenerTotalGastosInternosPorMes(arregloIndices[indice], AdministradorReportesController.AnioSeleccionado);
                utilidad = reporteDto.TotalVentas - totalTiposDeGastos;
                string[] row = { reporteDto.Mes, CambioDeFormato.DarFormatoANumero(reporteDto.TotalVentas), CambioDeFormato.DarFormatoANumero(totalTiposDeGastos), CambioDeFormato.DarFormatoANumero(utilidad) };
                ListViewItem itemReporte = new ListViewItem(row);
                reporteAnualView.lstvReporteMensualPorAnio.Items.Add(itemReporte);
                indice++;
            }
        }

        private void MostrarReporteAnual(object sender, EventArgs e)
        {
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteAnualView.lblTituloReporteAnual.Text = "REPORTE AÑO: " + administradorReportesView.cbSeleccionarAnio.SelectedItem.ToString();
            ReporteDao reporteDao = new ReporteDao();
            int totalVentasAnio = reporteDao.ObtenerTotalVentasPorAnio(AdministradorReportesController.AnioSeleccionado);
            int totalGastosAnio = new Logica().SumarTiposDeGastos(AdministradorReportesController.AnioSeleccionado);
            reporteAnualView.txtCantidadContratos.Text = reporteDao.ObtenerCantidadContratos(AdministradorReportesController.AnioSeleccionado).ToString();
            reporteAnualView.txtTotalVentas.Text = totalVentasAnio.ToString();
            reporteAnualView.txtTotalGastos.Text = totalGastosAnio.ToString();
            reporteAnualView.txtUtilidadGeneral.Text = (totalVentasAnio - totalGastosAnio).ToString();
        }

        private void MostrarGastosTotalesPorAnio(object sender, EventArgs e)
        {  
            reporteAnualView.lstvGastosTotalesMensuales.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteAnualView.lstvGastosTotalesMensuales.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteAnualView.lstvGastosTotalesMensuales.Items.Add(itemGastoInterno);
            }
        }
    }
}
