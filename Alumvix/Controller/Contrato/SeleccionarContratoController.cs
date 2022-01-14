using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class SeleccionarContratoController
    {
        static SeleccionarContratoView seleccionarContratoView;
        DetalleClienteView detalleClienteView;
        public SeleccionarContratoController(SeleccionarContratoView seleccionarContratoVista)
        {
            seleccionarContratoView = seleccionarContratoVista;
            seleccionarContratoView.Activated += new EventHandler(MostrarListadoContratos);
            seleccionarContratoView.Activated += new EventHandler(MostrarNombreClienteEnTitulo);
            seleccionarContratoView.btnMostrarContrato.Click += new EventHandler(MostrarContrato);
        }

        private void MostrarNombreClienteEnTitulo(object sender, EventArgs e)
        {
            seleccionarContratoView.lblTituloSeleccionarContrato.Text = "Contratos de " + ClienteController.ObtenerNombreCliente();
        }

        private void MostrarContrato(object sender, EventArgs e)
        {
            detalleClienteView = new DetalleClienteView();
            detalleClienteView.Show();
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
