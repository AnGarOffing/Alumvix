using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }
    }
}
