using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Cliente;

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        DetalleClienteView detalleClienteVista;
        List<ClienteDto> registroCliente = ClienteController.CargarRegistroCliente();
        ContratoDao contrato = new ContratoDao();
        ContratoDto contratoDto = new ContratoDao().ObtenerContrato(ClienteController.ObtenerIdCliente());

        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);
            detalleClienteVista.Load += new EventHandler(MostrarContrato);
            detalleClienteVista.Load += new EventHandler(MostrarGastos);

        }


        //metodo para mostrar info de un cliente en la vista "DetalleClienteView"
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.textBox1.Text = registroCliente[0].IdentificacionCliente.ToString();
            detalleClienteVista.textBox2.Text = registroCliente[0].NombreCliente.ToString();
            detalleClienteVista.textBox3.Text = registroCliente[0].TelefonoFijoCliente.ToString();
            detalleClienteVista.textBox4.Text = registroCliente[0].DireccionCliente.ToString();
            detalleClienteVista.textBox5.Text = registroCliente[0].CorreoElectronicoCliente.ToString();
            detalleClienteVista.textBox6.Text = registroCliente[0].CelularCliente.ToString();
            
           
        }

        //metodo para mostrar la info de un contrato en la vista DetalleClienteView
        private void MostrarContrato(object sender, EventArgs e)
        {
            
            detalleClienteVista.textBox7.Text = contratoDto.IdContrato.ToString();
            detalleClienteVista.textBox8.Text = FormatoAValor.DarFormatoANumero(contratoDto.ValorContrato);
            detalleClienteVista.textBox9.Text = contratoDto.FechaInicioContrato.ToString();
            detalleClienteVista.textBox10.Text = contratoDto.FechaTerminacionContrato.ToString();
            detalleClienteVista.textBox11.Text = contratoDto.EstadoContrato.ToString();
            detalleClienteVista.textBox12.Text = contratoDto.EstadoTrabajo.ToString();
        }

        private void MostrarGastos(object sender, EventArgs e) 
        {
            List<GastoDto> gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);
            int cont = 1;
            foreach  (GastoDto gasto in gastos)
            {
                
                string[] row = { cont.ToString(), gasto.ValorGasto.ToString() };
                ListViewItem itemGasto = new ListViewItem(row);
                detalleClienteVista.lstvGastos.Items.Add(itemGasto);
                cont++;
            }
        }
    }
}
