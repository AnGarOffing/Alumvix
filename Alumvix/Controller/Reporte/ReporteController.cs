using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Controller.Reporte
{
    
    internal class ReporteController
    {
        ReporteView reporteView;

        public ReporteController(ReporteView reporteVista) 
        {
            reporteView = reporteVista;
            reporteView.dtpFechaInicioReporte.Enabled = false;
            reporteView.dtpFechaFinalReporte.Enabled = false;
            reporteView.cbSeleccionarAnio.Enabled = false;
        }
    }
}
