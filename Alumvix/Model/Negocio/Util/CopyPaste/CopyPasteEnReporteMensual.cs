using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Negocio.Util
{
    internal class CopyPasteEnReporteMensual
    {
        ReporteMensualView reporteMensualView;

        public CopyPasteEnReporteMensual(ReporteMensualView reporteMensualVista)
        {
            reporteMensualView = reporteMensualVista;
            reporteMensualView.Load += new EventHandler(TransformarTextBoxesReporteMensualView);
        }

        private void TransformarTextBoxesReporteMensualView(object sender, EventArgs e)
        {
            reporteMensualView.txtCantidadContratos.ReadOnly = true;
            reporteMensualView.txtCantidadContratos.BorderStyle = 0;
            reporteMensualView.txtCantidadContratos.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtCantidadContratos.TabStop = false;

            reporteMensualView.txtTotalGastos.ReadOnly = true;
            reporteMensualView.txtTotalGastos.BorderStyle = 0;
            reporteMensualView.txtTotalGastos.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtTotalGastos.TabStop = false;

            reporteMensualView.txtTotalVentas.ReadOnly = true;
            reporteMensualView.txtTotalVentas.BorderStyle = 0;
            reporteMensualView.txtTotalVentas.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtTotalVentas.TabStop = false;

            reporteMensualView.txtUtilidadGeneral.ReadOnly = true;
            reporteMensualView.txtUtilidadGeneral.BorderStyle = 0;
            reporteMensualView.txtUtilidadGeneral.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtUtilidadGeneral.TabStop = false;
        }
    }
}
