using Alumvix.Controller.Login;
using Alumvix.Controller.Reporte;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
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
    internal class GastosInternosController
    {
        static GastosInternosView gastosInternosView;
        ClienteView clienteView;
        LoginView loginView;
        List<int> idsGastosInternos = new List<int>();
        public static int idGastoInterno;
        int indice;

        public GastosInternosController(GastosInternosView gastoInternoVista)
        {
            gastosInternosView = gastoInternoVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView();
            gastosInternosView.Activated += new EventHandler(CargarCombos);
            gastosInternosView.Activated += new EventHandler(MostrarGastosInternos);
            gastosInternosView.cbSeleccionarMesGI.SelectedIndexChanged += new EventHandler(MostrarGastosInternos);
            gastosInternosView.cbSeleccionarAnioGI.SelectedIndexChanged += new EventHandler(MostrarGastosInternos);
            gastosInternosView.lstvGastosInternos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            gastosInternosView.btnCerrarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            gastosInternosView.btnCerrarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            gastosInternosView.btnCerrarGastoInternoView.Click += new EventHandler(CerrarGastoInternoView);
            gastosInternosView.btnMinimizarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            gastosInternosView.btnMinimizarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            gastosInternosView.btnMinimizarGastoInternoView.Click += new EventHandler(MinimizarGastoInternoView);
            gastosInternosView.btnIngresarGastoInterno.Click += new EventHandler(AbrirIngresoGastoInternoView);
            gastosInternosView.btnEliminarGastoInterno.Click += new EventHandler(EliminarGastoInterno);
            gastosInternosView.btnEditarGastoInterno.Click += new EventHandler(AbrirEditarGastoInternoView);
            gastosInternosView.btnCerrarSesionGastosInternos.Click += new EventHandler(CerraSesion);
            gastosInternosView.btnCerrarSesionGastosInternos.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            gastosInternosView.btnCerrarSesionGastosInternos.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            gastosInternosView.pnlSuperiorGastoInternoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void CargarCombos(object sender, EventArgs e)
        {
            if (gastosInternosView.cbSeleccionarMesGI.Items.Count == 0)
            {
                gastosInternosView.cbSeleccionarMesGI.DataSource = new List<string>()
                { "--Todos--" ,"Enero", "Febrero", "Marzo", "Abril",
                  "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            }
            if (gastosInternosView.cbSeleccionarAnioGI.Items.Count == 0)
            {
                int anioActual = DateTime.Now.Year;
                int anioInicial = 2022;
                List<int> listadoAnios = new List<int>();
                while (anioInicial <= anioActual + 1)
                {
                    listadoAnios.Add(anioInicial);
                    anioInicial++;
                }
                gastosInternosView.cbSeleccionarAnioGI.DataSource = listadoAnios.Select(a => a.ToString()).ToList();
            }
            gastosInternosView.cbSeleccionarMesGI.SelectedIndex = 0;
            gastosInternosView.cbSeleccionarAnioGI.SelectedIndex = 0;
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(gastosInternosView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            gastosInternosView.btnCerrarSesionGastosInternos.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            gastosInternosView.btnCerrarSesionGastosInternos.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void CerraSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gastosInternosView.Hide();
                clienteView.Hide();
                loginView.Show();
            }         
        }

        public static GastosInternosView ObtenerInstanciaGastosInternosView()
        {
            return gastosInternosView;
        }

        private void MinimizarGastoInternoView(object sender, EventArgs e)
        {
            gastosInternosView.WindowState = FormWindowState.Minimized;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            gastosInternosView.btnCerrarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            gastosInternosView.btnCerrarGastoInternoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            gastosInternosView.btnMinimizarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            gastosInternosView.btnMinimizarGastoInternoView.BackColor = Color.Transparent;
        }

        private void CerrarGastoInternoView(object sender, EventArgs e)
        {
            gastosInternosView.Hide();
            clienteView.Show();
        }

        private void AbrirEditarGastoInternoView(object sender, EventArgs e)
        {
            if (gastosInternosView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                EditarGastoInternoView editarGastoInternoView = EditarGastoInternoView.ObtenerInstancia();
                gastosInternosView.Hide();
                editarGastoInternoView.Show();
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista");
        }

        public void AbrirIngresoGastoInternoView(object sender, EventArgs e)
        {
            IngresoGastoInternoView ingresoGastoInternoView = IngresoGastoInternoView.ObtenerInstancia();
            gastosInternosView.Hide();
            ingresoGastoInternoView.Show();
        }

        private void EliminarGastoInterno(object sender, EventArgs e)
        {
            if (gastosInternosView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el gasto?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new GastoInternoDao().EliminarGastoInterno(idGastoInterno);
                    if (respuesta)
                    {
                        gastosInternosView.lstvGastosInternos.SelectedItems.Clear();
                        MessageBox.Show("El gasto ha sido eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el gasto");
                    }
                }
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista");
        }

        private void MostrarGastosInternos(object sender, EventArgs e)
        {
            gastosInternosView.lstvGastosInternos.Items.Clear();
            idsGastosInternos.Clear();
            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = new List<GastoInternoDto>();
            if (gastosInternosView.cbSeleccionarMesGI.SelectedIndex == 0)
            {
                listadoGastosInternos.Clear();
                listadoGastosInternos = gastoInternoDao.ObtenerGastosInternos();
                gastosInternosView.cbSeleccionarAnioGI.Enabled = false;
            }
            else
            {
                gastosInternosView.cbSeleccionarAnioGI.Enabled = true;
                listadoGastosInternos.Clear();
                listadoGastosInternos = gastoInternoDao.ObtenerGastosInternos(
                gastosInternosView.cbSeleccionarMesGI.SelectedIndex,
                Convert.ToInt32(gastosInternosView.cbSeleccionarAnioGI.SelectedItem));
            }
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                idsGastosInternos.Add(gastoInternoDto.IdGastoInterno); //almacenamos ids de los gastos internos que se muestran 
                string[] row = { gastoInternoDto.TipoGastoInterno,CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno), CambioDeFormato.CambiarFormatoDeFecha(gastoInternoDto.FechaGastoInterno), gastoInternoDto.DescripcionGastoInterno};
                ListViewItem itemGastoInterno = new ListViewItem(row);
                gastosInternosView.lstvGastosInternos.Items.Add(itemGastoInterno);
            }
        }

        private int EncontrarIdGastoInterno(List<int> idsGastosInternos, int indice)
        {
            return idsGastosInternos[indice];
        }

        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (gastosInternosView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                indice = gastosInternosView.lstvGastosInternos.Items.IndexOf(gastosInternosView.lstvGastosInternos.SelectedItems[0]);
                idGastoInterno = EncontrarIdGastoInterno(idsGastosInternos, indice);
            }
        }

        public static GastosInternosView ObtenerInstancia()
        {
            return gastosInternosView;
        }
    }
}
