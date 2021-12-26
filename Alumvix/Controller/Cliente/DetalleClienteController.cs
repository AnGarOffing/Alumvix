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
            detalleClienteVista.textBox1.Text = registroCliente[0].ToString();
            detalleClienteVista.textBox2.Text = registroCliente[1].ToString();
            detalleClienteVista.textBox5.Text = registroCliente[2].ToString();
            detalleClienteVista.textBox6.Text = registroCliente[3].ToString();
            detalleClienteVista.textBox3.Text = registroCliente[4].ToString();
            detalleClienteVista.textBox4.Text = registroCliente[5].ToString();
        }

        //metodo para mostrar la info de un contrato en la vista DetalleClienteView
        private void MostrarContrato(object sender, EventArgs e)
        {
            ContratoDto contrato = new ContratoDao().ObtenerContrato(ClienteController.ObtenerIdCliente());
            detalleClienteVista.textBox7.Text = contrato.IdContrato.ToString();
            detalleClienteVista.textBox8.Text = FormatoAValor.DarFormatoANumero(contrato.ValorContrato);
            detalleClienteVista.textBox9.Text = contrato.FechaInicioContrato.ToString();
            detalleClienteVista.textBox10.Text = contrato.FechaTerminacionContrato.ToString();
            detalleClienteVista.textBox11.Text = contrato.EstadoContrato.ToString();
            detalleClienteVista.textBox12.Text = contrato.EstadoTrabajo.ToString();
        }
    }
}
