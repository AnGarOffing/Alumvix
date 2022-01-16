using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alumvix.Controller.Cliente
{
    internal class EditarClienteController
    {
        EditarClienteView editarClienteView;
        List<ClienteDto> datosCliente;
        public EditarClienteController(EditarClienteView editarClienteVista)
        {
            editarClienteView = editarClienteVista;
            datosCliente = ClienteController.CargarRegistroCliente();
            editarClienteView.Load += new EventHandler(CargarDatosCliente);
            editarClienteView.btnActualizarCliente.Click += new EventHandler(ActualizarCliente);
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
                    editarClienteView.Close();
                    MessageBox.Show("El cliente ha sido actualizado con exito");
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
