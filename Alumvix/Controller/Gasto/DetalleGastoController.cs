using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class DetalleGastoController
    {
        static DetalleGastoView detalleGastoView;
        DetalleClienteView detalleClienteView;
        int indice;
        List<int> idsGastos = new List<int>();
        public static int idGasto;

        public DetalleGastoController(DetalleGastoView detalleGastoVista) 
        {
            detalleGastoView = detalleGastoVista;
            detalleClienteView = DetalleClienteController.ObtenerInstanciaDetalleClienteView();
            detalleGastoView.Activated += new EventHandler(MostrarDetalleGastos);
            detalleGastoView.btnIngresarGasto.Click += new EventHandler(MostrarIngresoGastoView);
            detalleGastoView.btnEliminarGasto.Click += new EventHandler(EliminarGasto);
            detalleGastoView.lstvDetalleGastos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            detalleGastoView.btnEditarGasto.Click += new EventHandler(MostarEditarGastoView);
            detalleGastoView.btnCerrarDetalleGastoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            detalleGastoView.btnCerrarDetalleGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            detalleGastoView.btnCerrarDetalleGastoView.Click += new EventHandler(CerrarDetalleGastoView);
            detalleGastoView.btnMinimizarDetalleGastoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            detalleGastoView.btnMinimizarDetalleGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            detalleGastoView.btnMinimizarDetalleGastoView.Click += new EventHandler(MinimizarDetalleGastoView);
        }

        private void MinimizarDetalleGastoView(object sender, EventArgs e)
        {
            detalleGastoView.WindowState = FormWindowState.Minimized;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            detalleGastoView.btnCerrarDetalleGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            detalleGastoView.btnCerrarDetalleGastoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            detalleGastoView.btnMinimizarDetalleGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            detalleGastoView.btnMinimizarDetalleGastoView.BackColor = Color.Transparent;
        }

        private void CerrarDetalleGastoView(object sender, EventArgs e)
        {
            detalleGastoView.Hide();
            detalleClienteView.Show();
        }

        private void MostrarDetalleGastos(object sender, EventArgs e)
        {
            detalleGastoView.lstvDetalleGastos.Items.Clear();
            int contadorGastos = 0;
            idsGastos.Clear();
            foreach (GastoDto gasto in DetalleClienteController.ObtenerDetalleGastos())
            {
                idsGastos.Add(gasto.IdGasto); //almacenamos ids de los gastos que se muestran 
                contadorGastos++;
                string[] row = { contadorGastos.ToString(), gasto.NumeroFactura, CambioDeFormato.DarFormatoANumero(gasto.ValorGasto).ToString(), CambioDeFormato.CambiarFormatoDeFecha(gasto.FechaGasto), gasto.TipoGasto, gasto.Proveedor, gasto.DescripcionGasto };
                ListViewItem itemGasto = new ListViewItem(row);
                detalleGastoView.lstvDetalleGastos.Items.Add(itemGasto);
            }        
        }

        private void MostrarIngresoGastoView(object sender, EventArgs e)
        {
            IngresoGastoView ingresoGastoView = IngresoGastoView.ObtenerInstancia();
            detalleGastoView.Hide();
            ingresoGastoView.ShowDialog();
        }

        private void EliminarGasto(object sender, EventArgs e)
        {
            if (detalleGastoView.lstvDetalleGastos.SelectedItems.Count > 0)
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
            else MessageBox.Show("Debe seleccionar un gasto de la lista");
        }

        private int EncontrarIdGasto(List<int> idsGastos, int indice)
        {
            Console.WriteLine(idsGastos[indice]);
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
                detalleGastoView.Hide();
                editarGastoView.Show();
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista para editarlo");
        }
    }
}
