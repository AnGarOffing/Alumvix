using Alumvix.Controller.Reporte;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class GastosPorPeriodoController
    {
        GastosPorPeriodoView gastosPorPeriodoView;

        public GastosPorPeriodoController(GastosPorPeriodoView gastosPorPeriodoVista)
        {
            gastosPorPeriodoView = gastosPorPeriodoVista;
            gastosPorPeriodoView.Load += new EventHandler(MostrarGastosTotalesPorPeriodo);
        }

        private void MostrarGastosTotalesPorPeriodo(object sender, EventArgs e)
        {
            gastosPorPeriodoView.lstvGastosPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosAgrupadosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                gastosPorPeriodoView.lstvGastosPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                gastosPorPeriodoView.lstvGastosPeriodo.Items.Add(itemGastoInterno);
            }
        }

    }
}
