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
using Alumvix.View.Login;
using Alumvix.Controller.Login;

namespace Alumvix.Controller.Reporte
{

    internal class AdministradorReportesController
    {
        static AdministradorReportesView administradorReportesView;
        LoginView loginView;
        ClienteView clienteView;
        static int mesSeleccionado;
        static int anioSeleccionado;

        public static int MesSeleccionado { get => mesSeleccionado; set => mesSeleccionado = value; }
        public static int AnioSeleccionado { get => anioSeleccionado; set => anioSeleccionado = value; }

        public AdministradorReportesController(AdministradorReportesView administradorReportesVista)
        {
            administradorReportesView = administradorReportesVista;
            loginView = LoginController.ObtenerInstanciaLoginView();
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            administradorReportesView.Activated += new EventHandler(CargarCombos);
            administradorReportesView.rbAnual.CheckedChanged += new EventHandler(ActivarComboAnios);
            administradorReportesView.rbMensual.CheckedChanged += new EventHandler(ActivarComboMeses);
            administradorReportesView.rbRangoDeFechas.CheckedChanged += new EventHandler(ActivarRangoDeFecha);
            administradorReportesView.btnCerrarAdministradorReportesView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            administradorReportesView.btnCerrarAdministradorReportesView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            administradorReportesView.btnCerrarAdministradorReportesView.Click += new EventHandler(CerrarAdministradorReportesView);
            administradorReportesView.btnMinimizarAdministradorReportesView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            administradorReportesView.btnMinimizarAdministradorReportesView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            administradorReportesView.btnMinimizarAdministradorReportesView.Click += new EventHandler(MinimizarAdministradorReportesView);
            administradorReportesView.btnCerrarSesionAdminReportes.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            administradorReportesView.btnCerrarSesionAdminReportes.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            administradorReportesView.btnConsultarReporte.Click += new EventHandler(AbrirReporte);
            administradorReportesView.btnCerrarSesionAdminReportes.Click += new EventHandler(CerrarSesion);
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                administradorReportesView.Hide();
                clienteView.Hide();
                loginView.Show();
            }           
        }

        private void MinimizarAdministradorReportesView(object sender, EventArgs e)
        {
            administradorReportesView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarAdministradorReportesView(object sender, EventArgs e)
        {
            administradorReportesView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            administradorReportesView.btnCerrarSesionAdminReportes.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            administradorReportesView.btnCerrarSesionAdminReportes.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            administradorReportesView.btnCerrarAdministradorReportesView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            administradorReportesView.btnCerrarAdministradorReportesView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            administradorReportesView.btnMinimizarAdministradorReportesView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            administradorReportesView.btnMinimizarAdministradorReportesView.BackColor = Color.Transparent;
        }

        private void CargarCombos(object sender, EventArgs e)
        {
            if (administradorReportesView.cbSeleccionarMes.Items.Count == 0)
            {
                administradorReportesView.cbSeleccionarMes.DataSource = new List<string>()
                { "--Seleccionar--" ,"Enero", "Febrero", "Marzo", "Abril",
                  "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            }
            if (administradorReportesView.cbSeleccionarAnio.Items.Count == 0)
            {
                int anioActual = DateTime.Now.Year;
                int anioInicial = 2022;
                List<int> listadoAnios = new List<int>();
                while (anioInicial <= anioActual + 1)
                {
                    listadoAnios.Add(anioInicial);
                    anioInicial++;
                }
                administradorReportesView.cbSeleccionarAnio.DataSource = listadoAnios.Select(a => a.ToString()).ToList();
            }
            administradorReportesView.rbRangoDeFechas.Enabled = false;
        }

        private void AbrirReporte(object sender, EventArgs e)
        {
            if (administradorReportesView.rbMensual.Checked && administradorReportesView.cbSeleccionarMes.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un mes");
            }
            else
            {
                if (administradorReportesView.rbMensual.Checked == true)
                {
                    //ReporteMensualView reporteMensualView = ReporteMensualView.ObtenerInstancia();
                    //reporteMensualView.ShowDialog();
                    ReporteMensualView reporteMensualView = ReporteMensualView.ObtenerInstancia();
                    reporteMensualView.Show();
                    administradorReportesView.Hide();
                }
                if (administradorReportesView.rbAnual.Checked == true)
                {
                    //ReporteAnualView reporteAnualView = ReporteAnualView.ObtenerInstancia();
                    //reporteAnualView.ShowDialog();
                    ReporteAnualView reporteAnualView = ReporteAnualView.ObtenerInstancia();
                    reporteAnualView.Show();
                    administradorReportesView.Hide();
                }
                if (administradorReportesView.rbRangoDeFechas.Checked == true)
                {
                    
                }
            }           
        }

        private void ActivarRangoDeFecha(object sender, EventArgs e)
        {
            //administradorReporteView.dtpFechaInicioReporte.Enabled = true;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = true;
            administradorReportesView.cbSeleccionarAnio.Enabled = false;
            administradorReportesView.cbSeleccionarMes.Enabled = false;
        }

        private void ActivarComboAnios(object sender, EventArgs e)
        {
            administradorReportesView.cbSeleccionarAnio.Enabled = true;
            administradorReportesView.cbSeleccionarMes.SelectedIndex = 0;
            administradorReportesView.cbSeleccionarMes.Enabled = false;
            //administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = false;        
        }

        private void ActivarComboMeses(object sender, EventArgs e)
        {
            administradorReportesView.cbSeleccionarMes.Enabled = true;
            administradorReportesView.cbSeleccionarAnio.Enabled = true;
            //administradorReporteView.dtpFechaInicioReporte.Enabled = false;
            //administradorReporteView.dtpFechaFinalReporte.Enabled = false;
        }

        public static AdministradorReportesView ObtenerInstancia()
        {
            return administradorReportesView;
        }
    }
}
