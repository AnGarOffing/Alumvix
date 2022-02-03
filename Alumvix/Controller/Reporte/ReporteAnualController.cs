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

        public ReporteAnualController(ReporteAnualView reporteAnualVista)
        {
            reporteAnualView = reporteAnualVista;
            reporteAnualView.Load += new EventHandler(MostrarReporteAnual);
            reporteAnualView.btnDetalleGastos.Click += new EventHandler(MostrarGastosTotalesPorAnio);
        }

        private void MostrarReporteAnual(object sender, EventArgs e)
        {
            AdministradorReportesView administradorReportesView = AdministradorReportesController.ObtenerInstancia();
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
            reporteAnualView.lstvGastosPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteAnualView.lstvGastosPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteAnualView.lstvGastosPeriodo.Items.Add(itemGastoInterno);
            }
        }
    }
}
