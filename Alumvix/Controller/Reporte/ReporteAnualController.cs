using Alumvix.Controller.Login;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;
using Alumvix.View;
using Alumvix.View.Login;
using Alumvix.View.Reporte;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Reporte
{
    internal class ReporteAnualController
    {
        ReporteAnualView reporteAnualView;
        AdministradorReportesView administradorReportesView;
        ClienteView clienteView;
        LoginView loginView;

        public ReporteAnualController(ReporteAnualView reporteAnualVista)
        {
            reporteAnualView = reporteAnualVista;
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView();    
            reporteAnualView.Activated += new EventHandler(MostrarReporteAnual);
            reporteAnualView.Activated += new EventHandler(MostrarReporteMensualPorAnio);
            reporteAnualView.Activated += new EventHandler(LimpiarListadoGastos);
            reporteAnualView.btnCerrarReporteAnualView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            reporteAnualView.btnCerrarReporteAnualView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            reporteAnualView.btnCerrarReporteAnualView.Click += new EventHandler(CerrarReporteAnualView);
            reporteAnualView.btnMinimizarReporteAnualView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            reporteAnualView.btnMinimizarReporteAnualView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            reporteAnualView.btnMinimizarReporteAnualView.Click += new EventHandler(MinimizarReporteAnualView);
            reporteAnualView.Activated += new EventHandler(MostrarGastosTotalesPorAnio);
            reporteAnualView.btnExportarReporteAExcel.Click += new EventHandler(ExportarReporteAExcel);
            reporteAnualView.btnCerrarSesionReporteAnual.Click += new EventHandler(CerrarSesion);
            reporteAnualView.btnCerrarSesionReporteAnual.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            reporteAnualView.btnCerrarSesionReporteAnual.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            reporteAnualView.pnlSuperiorReporteAnualView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(reporteAnualView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LimpiarListadoGastos(object sender, EventArgs e)
        {
            reporteAnualView.lstvGastosTotalesMensuales.Items.Clear();
        }

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            reporteAnualView.btnCerrarSesionReporteAnual.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            reporteAnualView.btnCerrarSesionReporteAnual.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reporteAnualView.Hide();
                administradorReportesView.Hide();
                clienteView.Hide();
                loginView.Show();
            }       
        }

        private void MinimizarReporteAnualView(object sender, EventArgs e)
        {
            reporteAnualView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarReporteAnualView(object sender, EventArgs e)
        {
            reporteAnualView.Hide();
            administradorReportesView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            reporteAnualView.btnCerrarReporteAnualView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            reporteAnualView.btnCerrarReporteAnualView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            reporteAnualView.btnMinimizarReporteAnualView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            reporteAnualView.btnMinimizarReporteAnualView.BackColor = Color.Transparent;
        }

        private void MostrarReporteMensualPorAnio(object sender, EventArgs e)
        {
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            reporteAnualView.lstvReporteMensualPorAnio.Items.Clear();
            ReporteDao reporteDao = new ReporteDao();
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            List<ReporteDto> reporteGastosMensualesPorAnio = reporteDao.ObtenerGastosDeContratoMensualesPorAnio(AdministradorReportesController.AnioSeleccionado);
            List<int> listadoIndicesMeses = reporteDao.ObtenerIndicesDeMeses(AdministradorReportesController.AnioSeleccionado);
            int[] arregloIndices = new int[listadoIndicesMeses.Count];
            arregloIndices = listadoIndicesMeses.ToArray();
            int totalTiposDeGastos = 0;
            int totalVentasMes = 0;
            int utilidad = 0;
            foreach (ReporteDto reporteDto in reporteGastosMensualesPorAnio)
            {
                totalVentasMes = reporteDao.ObtenerTotalVentasPorMesDeUnAnio(reporteDto.IndiceMes, AdministradorReportesController.AnioSeleccionado);
                totalTiposDeGastos = reporteDto.TotalGastos + reporteDao.ObtenerTotalGastosInternosPorMes(reporteDto.IndiceMes, AdministradorReportesController.AnioSeleccionado);
                utilidad = totalVentasMes - totalTiposDeGastos;
                string[] row = { reporteDto.Mes, CambioDeFormato.DarFormatoANumero(totalVentasMes), CambioDeFormato.DarFormatoANumero(totalTiposDeGastos), CambioDeFormato.DarFormatoANumero(utilidad) };
                ListViewItem itemReporte = new ListViewItem(row);
                reporteAnualView.lstvReporteMensualPorAnio.Items.Add(itemReporte);
            }
        }

        private void MostrarReporteAnual(object sender, EventArgs e)
        {
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteAnualView.lblTituloReporteAnual.Text = "REPORTE AÑO: " + administradorReportesView.cbSeleccionarAnio.SelectedItem.ToString();
            ReporteDao reporteDao = new ReporteDao();
            int totalVentasAnio = reporteDao.ObtenerTotalVentasPorAnio(AdministradorReportesController.AnioSeleccionado);
            int totalGastosAnio = new Logica().SumarTiposDeGastos(AdministradorReportesController.AnioSeleccionado);
            reporteAnualView.txtCantidadContratos.Text = reporteDao.ObtenerCantidadContratos(AdministradorReportesController.AnioSeleccionado).ToString();
            reporteAnualView.txtTotalVentas.Text = CambioDeFormato.DarFormatoANumero(totalVentasAnio);
            reporteAnualView.txtTotalGastos.Text = CambioDeFormato.DarFormatoANumero(totalGastosAnio);
            reporteAnualView.txtUtilidadGeneral.Text = CambioDeFormato.DarFormatoANumero((totalVentasAnio - totalGastosAnio));
        }

        private void MostrarGastosTotalesPorAnio(object sender, EventArgs e)
        {  
            reporteAnualView.lstvGastosTotalesMensuales.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteAnualView.lstvGastosTotalesMensuales.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorAnio(AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteAnualView.lstvGastosTotalesMensuales.Items.Add(itemGastoInterno);
            }
        }

        private void ExportarReporteAExcel(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(reporteAnualView.txtCantidadContratos);
            textBoxes.Add(reporteAnualView.txtTotalVentas);
            textBoxes.Add(reporteAnualView.txtTotalGastos);
            textBoxes.Add(reporteAnualView.txtUtilidadGeneral);
            logica.ExportarReporteAnualAExcel(textBoxes, reporteAnualView.lstvGastosTotalesMensuales, reporteAnualView.lstvReporteMensualPorAnio);
        }
    }
}
