using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Abono;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Abono
{
    internal class AbonoController
    {
        DetalleAbonoView detalleAbonoView;
        int idContrato;

        public AbonoController(DetalleAbonoView detalleAbonoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            detalleAbonoView = detalleAbonoVista;
            detalleAbonoView.Load += new EventHandler(MostrarDetalleAbonos);
            detalleAbonoView.btnIngresarAbono.Click += new EventHandler(MostrarIngresoAbonoView);
        }

        private void MostrarDetalleAbonos(object sender, EventArgs e) 
        {
            detalleAbonoView.lstvDetalleAbonos.Items.Clear();
            foreach (AbonoDto abono in DetalleClienteController.ObtenerDetalleAbonos())
            {        
                string[] row = { abono.IdAbono.ToString(), FormatoAValor.DarFormatoANumero(abono.ValorAbono).ToString(), abono.FechaAbono.ToString(), abono.FormaDeAbono };
                ListViewItem itemAbono = new ListViewItem(row);
                detalleAbonoView.lstvDetalleAbonos.Items.Add(itemAbono);
            }
        }

        private void MostrarIngresoAbonoView(object sender, EventArgs e) 
        {
            IngresoAbonoView ingresoAbonoView = IngresoAbonoView.ObtenerInstancia();
            ingresoAbonoView.ShowDialog();
        }
    }
}
