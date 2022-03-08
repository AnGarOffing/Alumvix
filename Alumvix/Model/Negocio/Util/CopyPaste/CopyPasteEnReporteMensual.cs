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

            reporteMensualView.txtCantidadContabilidad.ReadOnly = true;
            reporteMensualView.txtCantidadContabilidad.BorderStyle = 0;
            reporteMensualView.txtCantidadContabilidad.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtCantidadContabilidad.TabStop = false;

            reporteMensualView.txtCantidadReserva.ReadOnly = true;
            reporteMensualView.txtCantidadReserva.BorderStyle = 0;
            reporteMensualView.txtCantidadReserva.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtCantidadReserva.TabStop = false;

            reporteMensualView.txtTotalContabilidad.ReadOnly = true;
            reporteMensualView.txtTotalContabilidad.BorderStyle = 0;
            reporteMensualView.txtTotalContabilidad.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtTotalContabilidad.TabStop = false;

            reporteMensualView.txtTotalReserva.ReadOnly = true;
            reporteMensualView.txtTotalReserva.BorderStyle = 0;
            reporteMensualView.txtTotalReserva.BackColor = reporteMensualView.BackColor;
            reporteMensualView.txtTotalReserva.TabStop = false;
        }
    }
}
