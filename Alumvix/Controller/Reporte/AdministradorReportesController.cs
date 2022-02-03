using Alumvix.Model.Dao;
using Alumvix.View.Reporte;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumvix.Model.Negocio;
using System.Windows.Forms;

namespace Alumvix.Controller.Reporte
{

    internal class AdministradorReportesController
    {
        static AdministradorReportesView administradorReporteView;
        static int mesSeleccionado;
        static int anioSeleccionado;

        public static int MesSeleccionado { get => mesSeleccionado; set => mesSeleccionado = value; }
        public static int AnioSeleccionado { get => anioSeleccionado; set => anioSeleccionado = value; }

        public AdministradorReportesController(AdministradorReportesView administradorReporteVista)
        {
            administradorReporteView = administradorReporteVista;
            administradorReporteView.Activated += new EventHandler(CargarCombos);
            administradorReporteView.rbAnual.CheckedChanged += new EventHandler(ActivarComboAnios);
            administradorReporteView.rbMensual.CheckedChanged += new EventHandler(ActivarComboMeses);
            administradorReporteView.rbRangoDeFechas.CheckedChanged += new EventHandler(ActivarRangoDeFecha);
            administradorReporteView.btnConsultarReporte.Click += new EventHandler(AbrirReporteMensualView);
        }

       

        private void CargarCombos(object sender, EventArgs e)
        {
            if (administradorReporteView.cbSeleccionarMes.Items.Count == 0)
            {
                administradorReporteView.cbSeleccionarMes.DataSource = new List<string>()
                { "--Seleccionar--" ,"Enero", "Febrero", "Marzo", "Abril",
                  "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            }
            if (administradorReporteView.cbSeleccionarAnio.Items.Count == 0)
            {
                //TODO: cargar los años consultando en BD los años en los que se han hecho contratos)
                int anioActual = DateTime.Now.Year;
                int anioInicial = 2022;
                List<int> listadoAnios = new List<int>();
                while (anioInicial <= anioActual + 1)
                {
                    listadoAnios.Add(anioInicial);
                    anioInicial++;
                }
                administradorReporteView.cbSeleccionarAnio.DataSource = listadoAnios.Select(a => a.ToString()).ToList();
            }
        }

        private void AbrirReporteMensualView(object sender, EventArgs e)
        {
            if (administradorReporteView.rbMensual.Checked == true)
            {                             
                ReporteMensualView reporteMensualView = ReporteMensualView.ObtenerInstancia();
                reporteMensualView.ShowDialog();              
            }
            if (administradorReporteView.rbAnual.Checked == true)
            {
                ReporteAnualView reporteAnualView = ReporteAnualView.ObtenerInstancia();
                reporteAnualView.ShowDialog();
            }
        }

        private void ActivarRangoDeFecha(object sender, EventArgs e)
        {
            administradorReporteView.dtpFechaInicioReporte.Enabled = true;
            administradorReporteView.dtpFechaFinalReporte.Enabled = true;
            administradorReporteView.cbSeleccionarAnio.Enabled = false;
            administradorReporteView.cbSeleccionarMes.Enabled = false;
        }

        private void ActivarComboAnios(object sender, EventArgs e)
        {
            administradorReporteView.cbSeleccionarAnio.Enabled = true;
            administradorReporteView.cbSeleccionarMes.Enabled = false;
            administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            administradorReporteView.dtpFechaFinalReporte.Enabled = false;        
        }

        private void ActivarComboMeses(object sender, EventArgs e)
        {
            administradorReporteView.cbSeleccionarMes.Enabled = true;
            administradorReporteView.cbSeleccionarAnio.Enabled = true;
            administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            administradorReporteView.dtpFechaFinalReporte.Enabled = false;
        }

        public static AdministradorReportesView ObtenerInstancia()
        {
            return administradorReporteView;
        }
    }
}
