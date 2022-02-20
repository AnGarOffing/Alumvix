using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class SeleccionarContratoController
    {
        static SeleccionarContratoView seleccionarContratoView;
        DetalleClienteView detalleClienteView;
        ClienteView clienteView;
        public SeleccionarContratoController(SeleccionarContratoView seleccionarContratoVista)
        {
            seleccionarContratoView = seleccionarContratoVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            seleccionarContratoView.Activated += new EventHandler(MostrarListadoContratos);
            seleccionarContratoView.Activated += new EventHandler(MostrarNombreClienteEnTitulo);
            seleccionarContratoView.Activated += new EventHandler(CentrarTitulo);
            seleccionarContratoView.btnMostrarContrato.Click += new EventHandler(MostrarContrato);
            seleccionarContratoView.btnMinimizarSeleccionarContratoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            seleccionarContratoView.btnMinimizarSeleccionarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            seleccionarContratoView.btnMinimizarSeleccionarContratoView.Click += new EventHandler(MinimizarSeleccionarContratoView);
            seleccionarContratoView.btnCerrarSeleccionarContratoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            seleccionarContratoView.btnCerrarSeleccionarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            seleccionarContratoView.btnCerrarSeleccionarContratoView.Click += new EventHandler(CerrarSeleccionarContratoView);
            seleccionarContratoView.pnlSuperiorSeleccionarContratoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(seleccionarContratoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            seleccionarContratoView.btnMinimizarSeleccionarContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            seleccionarContratoView.btnMinimizarSeleccionarContratoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            seleccionarContratoView.btnCerrarSeleccionarContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            seleccionarContratoView.btnCerrarSeleccionarContratoView.BackColor = Color.Transparent;
        }

        private void MinimizarSeleccionarContratoView(object sender, EventArgs e)
        {
            seleccionarContratoView.WindowState = FormWindowState.Minimized;
        }

        private void CentrarTitulo(object sender, EventArgs e)
        {
            int x = (seleccionarContratoView.pnlSuperiorSeleccionarContratoView.Size.Width - seleccionarContratoView.lblTituloSeleccionarContrato.Size.Width) / 2;
            seleccionarContratoView.lblTituloSeleccionarContrato.Location = new Point(x, seleccionarContratoView.lblTituloSeleccionarContrato.Location.Y);
        }

        private void CerrarSeleccionarContratoView(object sender, EventArgs e)
        {
            seleccionarContratoView.Hide();
            clienteView.Show();
        }

        private void MostrarNombreClienteEnTitulo(object sender, EventArgs e)
        {
            seleccionarContratoView.lblTituloSeleccionarContrato.Text = "Contratos de " + ClienteController.ObtenerNombreCliente();
        }

        private void MostrarContrato(object sender, EventArgs e)
        {
            if (seleccionarContratoView.lstvListadoContratos.SelectedItems.Count > 0)
            {
                //detalleClienteView = new DetalleClienteView();
                //detalleClienteView.Show();
                detalleClienteView = DetalleClienteView.ObtenerInstancia();
                detalleClienteView.Show();
                seleccionarContratoView.Hide();
            }
            else MessageBox.Show("Debe seleccionar un contrato");
        }

        private void MostrarListadoContratos(object sender, EventArgs e)
        {
            seleccionarContratoView.lstvListadoContratos.Items.Clear();
            foreach (ContratoDto contrato in new ContratoDao().ObtenerContratos(ClienteController.ObtenerIdCliente()))
            { 
                string[] row = { contrato.IdContrato.ToString(),CambioDeFormato.DarFormatoANumero(contrato.ValorContrato), CambioDeFormato.CambiarFormatoDeFecha(Convert.ToDateTime(contrato.FechaInicioContrato)), CambioDeFormato.CambiarFormatoDeFecha(Convert.ToDateTime(contrato.FechaTerminacionContrato)), contrato.EstadoContrato, contrato.EstadoTrabajo };
                ListViewItem itemContrato = new ListViewItem(row);
                seleccionarContratoView.lstvListadoContratos.Items.Add(itemContrato);
            }
        }

        public static  SeleccionarContratoView ObtenerInstanciaSeleccionarContratoView()
        {
            return seleccionarContratoView;
        }
    }
}
