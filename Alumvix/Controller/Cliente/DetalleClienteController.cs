using System;
using System.Collections.Generic;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Cliente;

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        DetalleClienteView detalleClienteVista;
        List<string> registroCliente = ClienteController.CargarRegistroCliente();

        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);
            detalleClienteVista.Load += new EventHandler(MostrarContrato);
        }


        //metodo para mostrar el detalle de un cliente en la vista "DetalleClienteView"
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.lblId2.Text = registroCliente[0].ToString();
            detalleClienteVista.lblNombreCliente2.Text = registroCliente[1].ToString();
            detalleClienteVista.lblCorreo2.Text = registroCliente[2].ToString();
            detalleClienteVista.lblCelular2.Text = registroCliente[3].ToString();
            detalleClienteVista.lblFijo2.Text = registroCliente[4].ToString();
            detalleClienteVista.lblDireccion2.Text = registroCliente[5].ToString();
        }

        //metodo para mostrar la info de un contrato en la vista DetalleClienteView
        private void MostrarContrato(object sender, EventArgs e)
        {
            ContratoDto contrato = new ContratoDao().ObtenerContrato(ClienteController.ObtenerIdCliente());
            detalleClienteVista.lblNumero2.Text = contrato.IdContrato.ToString();
            detalleClienteVista.lblValor2.Text = FormatoAValor.DarFormatoANumero(contrato.ValorContrato);
            detalleClienteVista.lblfechaInicio2.Text = contrato.FechaInicioContrato.ToString();
            detalleClienteVista.lblFechaFin2.Text = contrato.FechaTerminacionContrato.ToString();
            detalleClienteVista.lblEstadoContrato2.Text = contrato.EstadoContrato.ToString();
            detalleClienteVista.lblEstadoTrabajo2.Text = contrato.EstadoTrabajo.ToString();
        }

    }
}
