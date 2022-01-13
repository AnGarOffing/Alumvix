using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class DetalleGastoController
    {
        static DetalleGastoView detalleGastoView;
        int indice;
        List<int> idsGastos = new List<int>();
        public static int idGasto;

        public DetalleGastoController(DetalleGastoView detalleGastoVista) 
        {
            detalleGastoView = detalleGastoVista;
            detalleGastoView.Activated += new EventHandler(MostrarDetalleGastos);
            detalleGastoView.btnIngresarAbono.Click += new EventHandler(MostrarIngresoGastoView);
            detalleGastoView.btnEliminarGasto.Click += new EventHandler(EliminarGasto);
            detalleGastoView.lstvDetalleGastos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            detalleGastoView.btnEditarGasto.Click += new EventHandler(MostarEditarGastoView);
        }

        private void MostrarDetalleGastos(object sender, EventArgs e)
        {
            detalleGastoView.lstvDetalleGastos.Items.Clear();
            int contadorGastos = 0;
            foreach (GastoDto gasto in DetalleClienteController.ObtenerDetalleGastos())
            {
                idsGastos.Add(gasto.IdGasto); //almacenamos ids de los gastos que se muestran 
                contadorGastos++;
                string[] row = { contadorGastos.ToString(), gasto.NumeroFactura, CambioDeFormato.DarFormatoANumero(gasto.ValorGasto).ToString(), CambioDeFormato.CambiarFormatoDeFecha(gasto.FechaGasto), gasto.DescripcionGasto, gasto.Proveedor, gasto.TipoGasto };
                ListViewItem itemGasto = new ListViewItem(row);
                detalleGastoView.lstvDetalleGastos.Items.Add(itemGasto);
            }        
        }

        private void MostrarIngresoGastoView(object sender, EventArgs e)
        {
            IngresoGastoView ingresoGastoView = IngresoGastoView.ObtenerInstancia();
            ingresoGastoView.ShowDialog();
        }

        private void EliminarGasto(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea borrar el gasto?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool respuesta = new GastoDao().EliminarGasto(EncontrarIdGasto(idsGastos, indice));
                if (respuesta)
                {
                    detalleGastoView.lstvDetalleGastos.SelectedItems.Clear();
                    MessageBox.Show("El gasto ha sido eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el gasto");
                }
            }
        }

        private int EncontrarIdGasto(List<int> idsGastos, int indice)
        {
            return idsGastos[indice];
        }

        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (detalleGastoView.lstvDetalleGastos.SelectedItems.Count > 0)
            {
                indice = detalleGastoView.lstvDetalleGastos.Items.IndexOf(detalleGastoView.lstvDetalleGastos.SelectedItems[0]);
                idGasto = EncontrarIdGasto(idsGastos, indice);
            }        
        }

        public static DetalleGastoView ObtenerInstanciaDetalleGasto()
        {
            return detalleGastoView;
        }

        private void MostarEditarGastoView(object sender, EventArgs e)
        {
            if (detalleGastoView.lstvDetalleGastos.SelectedItems.Count > 0)
            {
                EditarGastoView editarGastoView = EditarGastoView.ObtenerInstancia();
                editarGastoView.ShowDialog();
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista para editarlo");
        }
    }
}
