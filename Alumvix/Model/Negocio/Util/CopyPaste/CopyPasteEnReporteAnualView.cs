using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Negocio.Util.CopyPaste
{
    internal class CopyPasteEnReporteAnualView
    {
        ReporteAnualView reporteAnualView;

        public CopyPasteEnReporteAnualView(ReporteAnualView reporteAnualVista)
        {
            reporteAnualView = reporteAnualVista;
            reporteAnualView.Load += new EventHandler(TransformarTextBoxesReporteAnualView);
        }

        private void TransformarTextBoxesReporteAnualView(object sender, EventArgs e)
        {
            reporteAnualView.txtCantidadContratos.ReadOnly = true;
            reporteAnualView.txtCantidadContratos.BorderStyle = 0;
            reporteAnualView.txtCantidadContratos.BackColor = reporteAnualView.BackColor;
            reporteAnualView.txtCantidadContratos.TabStop = false;

            reporteAnualView.txtTotalVentas.ReadOnly = true;
            reporteAnualView.txtTotalVentas.BorderStyle = 0;
            reporteAnualView.txtTotalVentas.BackColor = reporteAnualView.BackColor;
            reporteAnualView.txtTotalVentas.TabStop = false;

            reporteAnualView.txtTotalGastos.ReadOnly = true;
            reporteAnualView.txtTotalGastos.BorderStyle = 0;
            reporteAnualView.txtTotalGastos.BackColor = reporteAnualView.BackColor;
            reporteAnualView.txtTotalGastos.TabStop = false;

            reporteAnualView.txtUtilidadGeneral.ReadOnly = true;
            reporteAnualView.txtUtilidadGeneral.BorderStyle = 0;
            reporteAnualView.txtUtilidadGeneral.BackColor = reporteAnualView.BackColor;
            reporteAnualView.txtUtilidadGeneral.TabStop = false;
        }
    }
}
