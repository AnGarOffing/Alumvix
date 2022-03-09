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
    internal class ReporteMensualController
    {
        ReporteMensualView reporteMensualView;
        AdministradorReportesView administradorReportesView;
        int mes;
        int anio;
        ClienteView clienteView;
        LoginView loginView;

        public ReporteMensualController(ReporteMensualView reporteMensualVista)
        {
            reporteMensualView = reporteMensualVista;
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            mes = AdministradorReportesController.MesSeleccionado = administradorReportesView.cbSeleccionarMes.SelectedIndex;
            anio = AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView();
            reporteMensualView.Activated += new EventHandler(MostrarReporteMensual);
            reporteMensualView.Activated += new EventHandler(MostrarResumenContratos);
            reporteMensualView.btnCerrarReporteMensualView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            reporteMensualView.btnCerrarReporteMensualView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            reporteMensualView.btnCerrarReporteMensualView.Click += new EventHandler(CerrarReporteMensualView);
            reporteMensualView.btnMinimizarReporteMensualView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            reporteMensualView.btnMinimizarReporteMensualView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            reporteMensualView.btnMinimizarReporteMensualView.Click += new EventHandler(MinimizarReporteMensualView);
            reporteMensualView.Activated += new EventHandler(MostrarGastosTotalesPorMes);
            reporteMensualView.btnCerrarSesionReporteMensual.Click += new EventHandler(CerrarSesion);
            reporteMensualView.btnCerrarSesionReporteMensual.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            reporteMensualView.btnCerrarSesionReporteMensual.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            reporteMensualView.btnExportarReporteMensualAExcel.Click += new EventHandler(ExportarReporteAExcel);
            reporteMensualView.pnlSuperiorReporteMensualView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void MostrarResumenContratos(object sender, EventArgs e)
        {
            mes = AdministradorReportesController.MesSeleccionado = administradorReportesView.cbSeleccionarMes.SelectedIndex;
            anio = AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteMensualView.lstvResumenContratos.Items.Clear();
            ResumenContratoDao resumenContratoDao = new ResumenContratoDao();
            List<ResumenContratoDto> listadoResumenContrato = resumenContratoDao.ObtenerResumenContratos(mes, anio);
            foreach (ResumenContratoDto resumenContrato in listadoResumenContrato)
            {
                string[] row = { CambioDeFormato.CambiarFormatoDeFecha(resumenContrato.FechaInicioContrato),
                resumenContrato.NombreCliente, resumenContrato.NumeroFactura.ToString(), resumenContrato.TipoFactura, 
                   CambioDeFormato.DarFormatoANumero(resumenContrato.ValorFactura).ToString(), resumenContrato.Categoria};
                ListViewItem itemResumenContrato = new ListViewItem(row);
                reporteMensualView.lstvResumenContratos.Items.Add(itemResumenContrato);
            }
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(reporteMensualView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ExportarReporteAExcel(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(reporteMensualView.txtCantidadContratos);
            textBoxes.Add(reporteMensualView.txtTotalVentas);
            textBoxes.Add(reporteMensualView.txtTotalGastos);
            textBoxes.Add(reporteMensualView.txtUtilidadGeneral);
            logica.ExportarReporteMensualAExcel(textBoxes, reporteMensualView.lstvGastosPeriodo, reporteMensualView.lstvResumenContratos);
        }

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            reporteMensualView.btnCerrarSesionReporteMensual.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            reporteMensualView.btnCerrarSesionReporteMensual.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reporteMensualView.Hide();
                administradorReportesView.Hide();
                clienteView.Hide();
                loginView.Show();
            }         
        }

        private void MinimizarReporteMensualView(object sender, EventArgs e)
        {
            reporteMensualView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarReporteMensualView(object sender, EventArgs e)
        {
            reporteMensualView.Hide();
            administradorReportesView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            reporteMensualView.btnCerrarReporteMensualView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            reporteMensualView.btnCerrarReporteMensualView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            reporteMensualView.btnMinimizarReporteMensualView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            reporteMensualView.btnMinimizarReporteMensualView.BackColor = Color.Transparent;
        }

        private void MostrarReporteMensual(object sender, EventArgs e)
        {
            mes = AdministradorReportesController.MesSeleccionado = administradorReportesView.cbSeleccionarMes.SelectedIndex;
            anio = AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            reporteMensualView.lblTituloReporteMensual.Text = "REPORTE: " + administradorReportesView.cbSeleccionarMes.SelectedItem.ToString().ToUpperInvariant() + " - " + administradorReportesView.cbSeleccionarAnio.SelectedItem.ToString();
            ReporteDao reporteDao = new ReporteDao();
            int totalVentasMes = reporteDao.ObtenerTotalVentasPorMes(mes, anio);
            int totalGastosMes = new Logica().SumarTiposDeGastos(mes, anio);
            int cantContabilidad = reporteDao.ObtenerCantidadContabilidadPorMes(mes, anio);
            int cantReserva = reporteDao.ObtenerCantidadReservaPorMes(mes, anio);
            int totalContabilidad = reporteDao.ObtenerTotalContabilidadPorMes(mes, anio);
            int totalReserva = reporteDao.ObtenerTotalReservaPorMes(mes, anio);
            reporteMensualView.txtCantidadContratos.Text = reporteDao.ObtenerCantidadContratos(mes, anio).ToString();
            reporteMensualView.txtTotalVentas.Text = CambioDeFormato.DarFormatoANumero(totalVentasMes);
            reporteMensualView.txtTotalGastos.Text = CambioDeFormato.DarFormatoANumero(totalGastosMes);
            reporteMensualView.txtUtilidadGeneral.Text = CambioDeFormato.DarFormatoANumero((totalVentasMes - totalGastosMes));
            reporteMensualView.txtCantidadContabilidad.Text = CambioDeFormato.DarFormatoANumero((cantContabilidad));
            reporteMensualView.txtCantidadReserva.Text = CambioDeFormato.DarFormatoANumero((cantReserva));
            reporteMensualView.txtTotalContabilidad.Text = CambioDeFormato.DarFormatoANumero((totalContabilidad));
            reporteMensualView.txtTotalReserva.Text = CambioDeFormato.DarFormatoANumero((totalReserva));
        }

        private void MostrarGastosTotalesPorMes(object sender, EventArgs e)
        {
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosAgrupadosPorMes(mes, anio);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorMes(mes, anio);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGastoInterno);
            }
        }
    }
}
