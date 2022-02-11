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
using System.Drawing;
using Alumvix.View;

namespace Alumvix.Controller.Reporte
{

    internal class AdministradorReportesController
    {
        static AdministradorReportesView administradorReporteView;
        ClienteView clienteView;
        static int mesSeleccionado;
        static int anioSeleccionado;

        public static int MesSeleccionado { get => mesSeleccionado; set => mesSeleccionado = value; }
        public static int AnioSeleccionado { get => anioSeleccionado; set => anioSeleccionado = value; }

        public AdministradorReportesController(AdministradorReportesView administradorReportesVista)
        {
            administradorReporteView = administradorReportesVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            administradorReporteView.Activated += new EventHandler(CargarCombos);
            administradorReporteView.rbAnual.CheckedChanged += new EventHandler(ActivarComboAnios);
            administradorReporteView.rbMensual.CheckedChanged += new EventHandler(ActivarComboMeses);
            administradorReporteView.rbRangoDeFechas.CheckedChanged += new EventHandler(ActivarRangoDeFecha);
            administradorReporteView.btnCerrarAdministradorReportesView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            administradorReporteView.btnCerrarAdministradorReportesView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            administradorReporteView.btnCerrarAdministradorReportesView.Click += new EventHandler(CerrarAdministradorReportesView);
            administradorReporteView.btnMinimizarAdministradorReportesView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            administradorReporteView.btnMinimizarAdministradorReportesView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            administradorReporteView.btnMinimizarAdministradorReportesView.Click += new EventHandler(MinimizarAdministradorReportesView);
            administradorReporteView.btnConsultarReporte.Click += new EventHandler(AbrirReporte);
        }

        private void MinimizarAdministradorReportesView(object sender, EventArgs e)
        {
            administradorReporteView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarAdministradorReportesView(object sender, EventArgs e)
        {
            administradorReporteView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            administradorReporteView.btnCerrarAdministradorReportesView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            administradorReporteView.btnCerrarAdministradorReportesView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            administradorReporteView.btnMinimizarAdministradorReportesView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            administradorReporteView.btnMinimizarAdministradorReportesView.BackColor = Color.Transparent;
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
            administradorReporteView.rbRangoDeFechas.Enabled = false;
        }

        private void AbrirReporte(object sender, EventArgs e)
        {
            if (administradorReporteView.rbMensual.Checked && administradorReporteView.cbSeleccionarMes.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un mes");
            }
            else
            {
                if (administradorReporteView.rbMensual.Checked == true)
                {
                    //ReporteMensualView reporteMensualView = ReporteMensualView.ObtenerInstancia();
                    //reporteMensualView.ShowDialog();
                    ReporteMensualView reporteMensualView = ReporteMensualView.ObtenerInstancia();
                    reporteMensualView.Show();
                    administradorReporteView.Hide();
                }
                if (administradorReporteView.rbAnual.Checked == true)
                {
                    //ReporteAnualView reporteAnualView = ReporteAnualView.ObtenerInstancia();
                    //reporteAnualView.ShowDialog();
                    ReporteAnualView reporteAnualView = ReporteAnualView.ObtenerInstancia();
                    reporteAnualView.Show();
                    administradorReporteView.Hide();
                }
                if (administradorReporteView.rbRangoDeFechas.Checked == true)
                {
                    
                }
            }           
        }

        private void ActivarRangoDeFecha(object sender, EventArgs e)
        {
            //administradorReporteView.dtpFechaInicioReporte.Enabled = true;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = true;
            administradorReporteView.cbSeleccionarAnio.Enabled = false;
            administradorReporteView.cbSeleccionarMes.Enabled = false;
        }

        private void ActivarComboAnios(object sender, EventArgs e)
        {
            administradorReporteView.cbSeleccionarAnio.Enabled = true;
            administradorReporteView.cbSeleccionarMes.Enabled = false;
            //administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = false;        
        }

        private void ActivarComboMeses(object sender, EventArgs e)
        {
            administradorReporteView.cbSeleccionarMes.Enabled = true;
            administradorReporteView.cbSeleccionarAnio.Enabled = true;
            //administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = false;
        }

        public static AdministradorReportesView ObtenerInstancia()
        {
            return administradorReporteView;
        }
    }
}
