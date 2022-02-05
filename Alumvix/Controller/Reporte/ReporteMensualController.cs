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
    internal class ReporteMensualController
    {
        ReporteMensualView reporteMensualView;

        public ReporteMensualController(ReporteMensualView reporteMensualVista)
        {
            reporteMensualView = reporteMensualVista;
            reporteMensualView.Load += new EventHandler(MostrarReporteMensual);
            reporteMensualView.btnDetalleGastos.Click += new EventHandler(MostrarGastosTotalesPorMes);
        }

        private void MostrarReporteMensual(object sender, EventArgs e)
        {
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            AdministradorReportesView administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            AdministradorReportesController.MesSeleccionado = administradorReportesView.cbSeleccionarMes.SelectedIndex;
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteMensualView.lblTituloReporteMensual.Text = "REPORTE: " + administradorReportesView.cbSeleccionarMes.SelectedItem.ToString().ToUpperInvariant() + "/" + administradorReportesView.cbSeleccionarAnio.SelectedItem.ToString();
            ReporteDao reporteDao = new ReporteDao();
            int totalVentasMes = reporteDao.ObtenerTotalVentasPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            int totalGastosMes = new Logica().SumarTiposDeGastos(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);          
            reporteMensualView.txtCantidadContratos.Text = reporteDao.ObtenerCantidadContratos(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado).ToString();
            reporteMensualView.txtTotalVentas.Text = totalVentasMes.ToString();
            reporteMensualView.txtTotalGastos.Text = totalGastosMes.ToString();
            reporteMensualView.txtUtilidadGeneral.Text = (totalVentasMes - totalGastosMes).ToString();
        }

        private void MostrarGastosTotalesPorMes(object sender, EventArgs e)
        {
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGastoInterno);
            }
        }
    }
}
