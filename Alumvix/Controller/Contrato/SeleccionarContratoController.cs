using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class SeleccionarContratoController
    {
        SeleccionarContratoView seleccionarContratoView;
        DetalleClienteView detalleClienteView;
        public SeleccionarContratoController(SeleccionarContratoView seleccionarContratoVista)
        {
            seleccionarContratoView = seleccionarContratoVista;
            seleccionarContratoView.Activated += new EventHandler(MostrarListadoContratos);
            seleccionarContratoView.btnMostrarContrato.Click += new EventHandler(MostrarContrato);
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
    }
}
