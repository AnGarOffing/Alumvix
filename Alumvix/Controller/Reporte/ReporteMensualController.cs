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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Reporte
{
    internal class ReporteMensualController
    {
        ReporteMensualView reporteMensualView;
        AdministradorReportesView administradorReportesView;
        ClienteView clienteView;
        LoginView loginView;

        public ReporteMensualController(ReporteMensualView reporteMensualVista)
        {
            reporteMensualView = reporteMensualVista;
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView();
            reporteMensualView.Activated += new EventHandler(MostrarReporteMensual);
            reporteMensualView.btnCerrarReporteMensualView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            reporteMensualView.btnCerrarReporteMensualView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            reporteMensualView.btnCerrarReporteMensualView.Click += new EventHandler(CerrarReporteMensualView);
            reporteMensualView.btnMinimizarReporteMensualView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            reporteMensualView.btnMinimizarReporteMensualView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            reporteMensualView.btnMinimizarReporteMensualView.Click += new EventHandler(MinimizarReporteMensualView);
            reporteMensualView.btnDetalleGastos.Click += new EventHandler(MostrarGastosTotalesPorMes);
            reporteMensualView.btnCerrarSesionReporteMensual.Click += new EventHandler(CerrarSesion);
            reporteMensualView.btnCerrarSesionReporteMensual.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            reporteMensualView.btnCerrarSesionReporteMensual.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
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
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            AdministradorReportesView administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            AdministradorReportesController.MesSeleccionado = administradorReportesView.cbSeleccionarMes.SelectedIndex;
            AdministradorReportesController.AnioSeleccionado = Convert.ToInt32(administradorReportesView.cbSeleccionarAnio.SelectedValue);
            reporteMensualView.lblTituloReporteMensual.Text = "REPORTE: " + administradorReportesView.cbSeleccionarMes.SelectedItem.ToString().ToUpperInvariant() + "-" + administradorReportesView.cbSeleccionarAnio.SelectedItem.ToString();
            ReporteDao reporteDao = new ReporteDao();
            int totalVentasMes = reporteDao.ObtenerTotalVentasPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            int totalGastosMes = new Logica().SumarTiposDeGastos(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);          
            reporteMensualView.txtCantidadContratos.Text = reporteDao.ObtenerCantidadContratos(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado).ToString();
            reporteMensualView.txtTotalVentas.Text = CambioDeFormato.DarFormatoANumero(totalVentasMes);
            reporteMensualView.txtTotalGastos.Text = CambioDeFormato.DarFormatoANumero(totalGastosMes);
            reporteMensualView.txtUtilidadGeneral.Text = CambioDeFormato.DarFormatoANumero((totalVentasMes - totalGastosMes));
        }

        private void MostrarGastosTotalesPorMes(object sender, EventArgs e)
        {
            reporteMensualView.lstvGastosPeriodo.Items.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastos = gastoDao.ObtenerGastosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoDto gastoDto in listadoGastos)
            {
                string[] row = { gastoDto.TipoGasto, CambioDeFormato.DarFormatoANumero(gastoDto.ValorGasto) };
                ListViewItem itemGasto = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGasto);
            }

            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternosPorMes(AdministradorReportesController.MesSeleccionado, AdministradorReportesController.AnioSeleccionado);
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                string[] row = { gastoInternoDto.TipoGastoInterno, CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno) };
                ListViewItem itemGastoInterno = new ListViewItem(row);
                reporteMensualView.lstvGastosPeriodo.Items.Add(itemGastoInterno);
            }
        }
    }
}
