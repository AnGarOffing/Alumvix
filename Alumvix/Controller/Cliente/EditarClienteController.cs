using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Cliente;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alumvix.Controller.Cliente
{
    internal class EditarClienteController
    {
        EditarClienteView editarClienteView;
        ClienteView clienteView = ClienteController.ObtenerInstanciaClienteView();
        List<ClienteDto> datosCliente;
        public EditarClienteController(EditarClienteView editarClienteVista)
        {
            editarClienteView = editarClienteVista;
            datosCliente = ClienteController.CargarRegistroCliente();
            editarClienteView.Activated += new EventHandler(CargarDatosCliente);
            editarClienteView.txtActualizarIdentificacionCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarClienteView.txtEditarNombreCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaLetrasYNumeros);
            editarClienteView.txtEditarTelefonoCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarClienteView.txtEditarCelularCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarClienteView.btnMinimizarEditarClienteView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarClienteView.btnMinimizarEditarClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarClienteView.btnCerrarEditarClienteView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarClienteView.btnCerrarEditarClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarClienteView.btnCerrarEditarClienteView.Click += new EventHandler(CerrarFormularioEditarClienteView);
            editarClienteView.btnMinimizarEditarClienteView.Click += new EventHandler(MinimizarFormularioEditarClienteView);
            editarClienteView.btnActualizarCliente.Click += new EventHandler(ActualizarCliente);
            editarClienteView.pnlSuperiorEditarClienteView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarClienteView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MinimizarFormularioEditarClienteView(object sender, EventArgs e)
        {
            editarClienteView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarFormularioEditarClienteView(object sender, EventArgs e)
        {
            editarClienteView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarClienteView.btnMinimizarEditarClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarClienteView.btnMinimizarEditarClienteView.BackColor = Color.Transparent;
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarClienteView.btnCerrarEditarClienteView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarClienteView.btnCerrarEditarClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void ValidarEntradaLetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActualizarCliente(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            if (ValidacionesDeControles.ValidarBotonIngresoCliente(editarClienteView.txtEditarNombreCliente.Text) == false)
            {
                MessageBox.Show("Debe diligenciar minimamente el nombre del cliente");
            }
            else
            {
                bool respuestaActualizacionCliente = clienteDao.ActualizarCliente(
                    ClienteController.ObtenerIdCliente(),
                    editarClienteView.txtActualizarIdentificacionCliente.Text,
                    editarClienteView.txtEditarNombreCliente.Text,
                    editarClienteView.txtEditarEmailCliente.Text,
                    editarClienteView.txtEditarCelularCliente.Text,
                    editarClienteView.txtEditarTelefonoCliente.Text,
                    editarClienteView.txtEditarDireccionCliente.Text);
                if (respuestaActualizacionCliente)
                {
                    editarClienteView.Hide();
                    MessageBox.Show("El cliente ha sido actualizado con exito");
                    clienteView.Show();
                }
                else MessageBox.Show("Error al intentar actualizar el cliente");
            }
        }

        private void CargarDatosCliente(object sender, EventArgs e)
        {
            editarClienteView.txtActualizarIdentificacionCliente.Text = datosCliente[0].IdentificacionCliente.ToString();
            editarClienteView.txtEditarNombreCliente.Text = datosCliente[0].NombreCliente.ToString();
            editarClienteView.txtEditarEmailCliente.Text = datosCliente[0].CorreoElectronicoCliente.ToString();
            editarClienteView.txtEditarCelularCliente.Text = datosCliente[0].CelularCliente.ToString();
            editarClienteView.txtEditarTelefonoCliente.Text = datosCliente[0].TelefonoFijoCliente.ToString();
            editarClienteView.txtEditarDireccionCliente.Text = datosCliente[0].DireccionCliente.ToString();
        }
    }
}
