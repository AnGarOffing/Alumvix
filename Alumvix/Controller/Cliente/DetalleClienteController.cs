using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View.Cliente;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        DetalleClienteView detalleClienteVista;
        List<ClienteDto> registroCliente;
        ContratoDto contratoDto;
        List<GastoDto> gastos;
        List<AbonoDto> abonos;
        Logica logica;


        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            contratoDto = new ContratoDao().ObtenerContrato(ClienteController.ObtenerIdCliente());
            abonos = new AbonoDao().ObtenerAbonos(contratoDto.IdContrato);
            gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);          
            registroCliente = ClienteController.CargarRegistroCliente();
            logica = new Logica();
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);
            detalleClienteVista.Load += new EventHandler(MostrarContrato);
            detalleClienteVista.Load += new EventHandler(MostrarGastos);
            detalleClienteVista.Load += new EventHandler(MostrarAbonos);
            detalleClienteVista.Load += new EventHandler(MostrarCuentas);
        }


        //metodo para mostrar info de un cliente en la vista "DetalleClienteView"
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.txtIdentificacion.Text = registroCliente[0].IdentificacionCliente.ToString();
            detalleClienteVista.txtNombre.Text = registroCliente[0].NombreCliente.ToString();
            detalleClienteVista.txtTelefono.Text = registroCliente[0].TelefonoFijoCliente.ToString();
            detalleClienteVista.txtDireccion.Text = registroCliente[0].DireccionCliente.ToString();
            detalleClienteVista.txtCorreo.Text = registroCliente[0].CorreoElectronicoCliente.ToString();
            detalleClienteVista.txtCelular.Text = registroCliente[0].CelularCliente.ToString();
        }


        //metodo para mostrar la info de un contrato en la vista DetalleClienteView
        private void MostrarContrato(object sender, EventArgs e)
        {
            
            detalleClienteVista.txtNumeroContrato.Text = contratoDto.IdContrato.ToString();
            detalleClienteVista.txtValorContrato.Text = FormatoAValor.DarFormatoANumero(contratoDto.ValorContrato);
            detalleClienteVista.txtFechaInicioContrato.Text = contratoDto.FechaInicioContrato.ToString();
            detalleClienteVista.txtFechaFinContrato.Text = contratoDto.FechaTerminacionContrato.ToString();
            detalleClienteVista.txtEstadoContrato.Text = contratoDto.EstadoContrato.ToString();
            detalleClienteVista.txtEstadoTrabajo.Text = contratoDto.EstadoTrabajo.ToString();
        }

        private void MostrarGastos(object sender, EventArgs e) 
        {
            int cont = 1;
            foreach  (GastoDto gasto in gastos)
            {              
                string[] row = { cont.ToString(), FormatoAValor.DarFormatoANumero(gasto.ValorGasto).ToString()};
                ListViewItem itemGasto = new ListViewItem(row);
                detalleClienteVista.lstvGastos.Items.Add(itemGasto);
                cont++;
            }
        }

        private void MostrarAbonos(object sender, EventArgs e)
        {
            int cont = 1;
            foreach (AbonoDto abono in abonos)
            {
                string[] row = { cont.ToString(), FormatoAValor.DarFormatoANumero(abono.ValorAbono).ToString()};
                ListViewItem itemAbono = new ListViewItem(row);
                detalleClienteVista.lstvAbonos.Items.Add(itemAbono);
                cont++;
            }
        }

        private void MostrarCuentas(object sender, EventArgs e)
        {
            detalleClienteVista.txtTotalGastos.Text = FormatoAValor.DarFormatoANumero(logica.SumarGastos(gastos)).ToString();
            detalleClienteVista.txtTotalAbonos.Text = FormatoAValor.DarFormatoANumero(logica.SumarAbonos(abonos)).ToString();
            detalleClienteVista.txtRestaPorPagar.Text = FormatoAValor.DarFormatoANumero(logica.ObtenerRestantePorPagar(logica.SumarAbonos(abonos), contratoDto.ValorContrato)).ToString();
            detalleClienteVista.txtUtilidad.Text = FormatoAValor.DarFormatoANumero(logica.ObtenerUtilidad(logica.SumarAbonos(abonos), logica.SumarGastos(gastos))).ToString();
        }

        private void MostrarProductos(object sender, EventArgs e) 
        {

        }

        
    }
}
