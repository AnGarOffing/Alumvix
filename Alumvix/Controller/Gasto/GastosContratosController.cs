using Alumvix.Controller.Login;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View;
using Alumvix.View.Gasto;
using Alumvix.View.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class GastosContratosController
    {
        static GastosContratosView gastosContratosView;
        ClienteView clienteView;
        LoginView loginView;
        List<int> idsGastosContratos = new List<int>();

        public GastosContratosController(GastosContratosView gastosContratosVista)
        {
            gastosContratosView = gastosContratosVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView();
            gastosContratosView.Activated += new EventHandler(CargarCombos);
            gastosContratosView.Activated += new EventHandler(MostrarGastosContratos);
            gastosContratosView.cbSeleccionarMesGI.SelectedIndexChanged += new EventHandler(MostrarGastosContratos);
            gastosContratosView.cbSeleccionarAnioGI.SelectedIndexChanged += new EventHandler(MostrarGastosContratos);
            gastosContratosView.btnCerrarGastosContratosView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            gastosContratosView.btnCerrarGastosContratosView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            gastosContratosView.btnCerrarGastosContratosView.Click += new EventHandler(CerrarGastosContratosView);
            gastosContratosView.btnMinimizarGastosContratosView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            gastosContratosView.btnMinimizarGastosContratosView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            gastosContratosView.btnMinimizarGastosContratosView.Click += new EventHandler(MinimizarGastosContratosView);
            gastosContratosView.btnCerrarSesionGastosContratos.Click += new EventHandler(CerraSesion);
            gastosContratosView.btnCerrarSesionGastosContratos.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            gastosContratosView.btnCerrarSesionGastosContratos.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            gastosContratosView.pnlSuperiorGastosContratosView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void CargarCombos(object sender, EventArgs e)
        {
            if (gastosContratosView.cbSeleccionarMesGI.Items.Count == 0)
            {
                gastosContratosView.cbSeleccionarMesGI.DataSource = new List<string>()
                { "--Todos--" ,"Enero", "Febrero", "Marzo", "Abril",
                  "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            }
            if (gastosContratosView.cbSeleccionarAnioGI.Items.Count == 0)
            {
                int anioActual = DateTime.Now.Year;
                int anioInicial = 2022;
                List<int> listadoAnios = new List<int>();
                while (anioInicial <= anioActual + 1)
                {
                    listadoAnios.Add(anioInicial);
                    anioInicial++;
                }
                gastosContratosView.cbSeleccionarAnioGI.DataSource = listadoAnios.Select(a => a.ToString()).ToList();
            }
            gastosContratosView.cbSeleccionarMesGI.SelectedIndex = 0;
            gastosContratosView.cbSeleccionarAnioGI.SelectedIndex = 0;
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(gastosContratosView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            gastosContratosView.btnCerrarSesionGastosContratos.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            gastosContratosView.btnCerrarSesionGastosContratos.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void CerraSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gastosContratosView.Hide();
                clienteView.Hide();
                loginView.Show();
            }
        }

        public static GastosContratosView ObtenerInstanciaGastosContratosView()
        {
            return gastosContratosView;
        }

        private void MinimizarGastosContratosView(object sender, EventArgs e)
        {
            gastosContratosView.WindowState = FormWindowState.Minimized;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            gastosContratosView.btnCerrarGastosContratosView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            gastosContratosView.btnCerrarGastosContratosView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            gastosContratosView.btnMinimizarGastosContratosView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            gastosContratosView.btnMinimizarGastosContratosView.BackColor = Color.Transparent;
        }

        private void CerrarGastosContratosView(object sender, EventArgs e)
        {
            gastosContratosView.Hide();
            clienteView.Show();
        }

        private void MostrarGastosContratos(object sender, EventArgs e)
        {
            gastosContratosView.lstvGastosContratos.Items.Clear();
            idsGastosContratos.Clear();
            GastoDao gastoDao = new GastoDao();
            List<GastoDto> listadoGastosContratos = new List<GastoDto>();
            if (gastosContratosView.cbSeleccionarMesGI.SelectedIndex == 0)
            {
                listadoGastosContratos.Clear();
                listadoGastosContratos = gastoDao.ObtenerGastosPorMes();
                gastosContratosView.cbSeleccionarAnioGI.Enabled = false;
            }
            else
            {
                gastosContratosView.cbSeleccionarAnioGI.Enabled = true;
                listadoGastosContratos.Clear();
                listadoGastosContratos = gastoDao.ObtenerGastosPorMes(
                gastosContratosView.cbSeleccionarMesGI.SelectedIndex,
                Convert.ToInt32(gastosContratosView.cbSeleccionarAnioGI.SelectedItem));
            }
            foreach (GastoDto gasto in listadoGastosContratos)
            {
                //idsGastosContratos.Add(gastoInternoDto.IdGastoInterno); //almacenamos ids de los gastos internos que se muestran 
                string[] row = { CambioDeFormato.CambiarFormatoDeFecha(gasto.FechaGasto),
                    gasto.TipoGasto, CambioDeFormato.DarFormatoANumero(gasto.ValorGasto).ToString(),
                    gasto.Proveedor, gasto.FacturaProveedor, CambioDeFormato.DarFormatoANumero(gasto.NumeroContrato).ToString(),
                    gasto.Cliente, gasto.DescripcionGasto};
                ListViewItem itemGastoContrato = new ListViewItem(row);
                gastosContratosView.lstvGastosContratos.Items.Add(itemGastoContrato);
            }
        }

        public static GastosContratosView ObtenerInstancia()
        {
            return gastosContratosView;
        }
    }
}
