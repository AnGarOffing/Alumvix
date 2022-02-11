using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Abono;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Alumvix.View.Cliente;

namespace Alumvix.Controller.Abono
{
    internal class DetalleAbonoController
    {
        static DetalleAbonoView detalleAbonoView;
        DetalleClienteView detalleClienteView;
        int idContrato;
        int indice;
        static List<int> idsAbonos = new List<int>();
        public static int idAbono;

        public DetalleAbonoController(DetalleAbonoView detalleAbonoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            detalleClienteView = DetalleClienteController.ObtenerInstanciaDetalleClienteView();
            detalleAbonoView = detalleAbonoVista;
            detalleAbonoView.Activated += new EventHandler(MostrarDetalleAbonos);
            detalleAbonoView.btnIngresarAbono.Click += new EventHandler(MostrarIngresoAbonoView);
            detalleAbonoView.btnEliminarAbono.Click += new EventHandler(EliminarAbono);
            detalleAbonoView.lstvDetalleAbonos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            detalleAbonoView.btnEditarAbono.Click += new EventHandler(MostrarEditarAbonoView);
            detalleAbonoView.btnCerrarDetalleAbonoView.Click += new EventHandler(CerrarDetalleAbonoView);
        }

        private void CerrarDetalleAbonoView(object sender, EventArgs e)
        {
            detalleAbonoView.Hide();
            detalleClienteView.Show();
        }

        public static DetalleAbonoView ObtenerInstancia()
        {
            return detalleAbonoView;
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
            detalleAbonoView.Hide();
            ingresoAbonoView.Show();
        }

        private void EliminarAbono(object sender, EventArgs e)
        {
            if (detalleAbonoView.lstvDetalleAbonos.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el abono?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new AbonoDao().EliminarAbono(idAbono);
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
            else MessageBox.Show("Debe seleccionar un abono de la lista");
                    
        }


        private static int EncontrarIdAbono(List<int> idsAbonos, int indice)
        {
            return idsAbonos[indice];
        }


        private void ObtenerIndice(object sender, EventArgs e) 
        {
            if (detalleAbonoView.lstvDetalleAbonos.SelectedItems.Count > 0)
            {
                indice = detalleAbonoView.lstvDetalleAbonos.Items.IndexOf(detalleAbonoView.lstvDetalleAbonos.SelectedItems[0]);
                idAbono = EncontrarIdAbono(idsAbonos, indice);
            }         
        }

        private void MostrarEditarAbonoView(object sender, EventArgs e)
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
