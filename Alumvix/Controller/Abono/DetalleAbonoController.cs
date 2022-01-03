using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Abono;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Alumvix.Controller.Abono
{
    internal class DetalleAbonoController
    {
        static DetalleAbonoView detalleAbonoView;
        int idContrato;
        int indice;
        static List<int> idsAbonos = new List<int>();
        public static int idAbono;

        public DetalleAbonoController(DetalleAbonoView detalleAbonoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            detalleAbonoView = detalleAbonoVista;
            detalleAbonoView.Activated += new EventHandler(MostrarDetalleAbonos);
            detalleAbonoView.btnIngresarAbono.Click += new EventHandler(MostrarIngresoAbonoView);
            detalleAbonoView.btnEliminarAbono.Click += new EventHandler(EliminarAbono);
            detalleAbonoView.lstvDetalleAbonos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            detalleAbonoView.btnEditarAbono.Click += new EventHandler(MostarEditarAbonoView);
        }

        private void MostrarDetalleAbonos(object sender, EventArgs e) 
        {
            detalleAbonoView.lstvDetalleAbonos.Items.Clear();
            int contadorAbonos = 0;
            idsAbonos.Clear();
            foreach (AbonoDto abono in DetalleClienteController.ObtenerDetalleAbonos())
            {               
                idsAbonos.Add(abono.IdAbono); //almacenamos ids de los abonos que se muestran 
                contadorAbonos++;
                string[] row = { contadorAbonos.ToString(), CambioDeFormato.DarFormatoANumero(abono.ValorAbono).ToString(), CambioDeFormato.CambiarFormatoDeFecha(abono.FechaAbono), abono.FormaDeAbono };
                ListViewItem itemAbono = new ListViewItem(row);
                detalleAbonoView.lstvDetalleAbonos.Items.Add(itemAbono);
            }

        }

        private void MostrarIngresoAbonoView(object sender, EventArgs e) 
        {
            IngresoAbonoView ingresoAbonoView = IngresoAbonoView.ObtenerInstancia();
            ingresoAbonoView.ShowDialog();
        }

        private void EliminarAbono(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea borrar el abono?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool respuesta = new AbonoDao().EliminarAbono(EncontrarIdAbono(idsAbonos, indice));
                if (respuesta) 
                {
                    detalleAbonoView.lstvDetalleAbonos.SelectedItems.Clear();
                    MessageBox.Show("El abono ha sido eliminado con exito");           
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el abono");
                }      
            }          
        }


        private static int EncontrarIdAbono(List<int> idsAbonos, int indice)
        {
            return idsAbonos[indice];
        }


        private void ObtenerIndice(object sender, EventArgs e) 
        {
            indice = detalleAbonoView.lstvDetalleAbonos.Items.IndexOf(detalleAbonoView.lstvDetalleAbonos.SelectedItems[0]);
            idAbono = EncontrarIdAbono(idsAbonos, indice);
        }

        private void MostarEditarAbonoView(object sender, EventArgs e)
        {
            if (detalleAbonoView.lstvDetalleAbonos.SelectedItems.Count > 0)
            {
                EditarAbonoView editarAbonoView = EditarAbonoView.ObtenerInstancia();
                editarAbonoView.ShowDialog();
            }
            else MessageBox.Show("Debe seleccionar un abono de la lista para editarlo");
        }

        public static  DetalleAbonoView ObtenerInstanciaDetalleAbono() 
        {
            return detalleAbonoView;
        }
    }
}
