using Alumvix.Controller.Reporte;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
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
    internal class GastoInternoController
    {
        static GastoInternoView gastoInternoView;
        ClienteView clienteView;
        List<int> idsGastosInternos = new List<int>();
        public int idGastoInterno;
        int indice;

        public GastoInternoController(GastoInternoView gastoInternoVista)
        {
            gastoInternoView = gastoInternoVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            gastoInternoView.Activated += new EventHandler(MostrarGastosInternos);
            gastoInternoView.lstvGastosInternos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            gastoInternoView.btnCerrarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            gastoInternoView.btnCerrarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            gastoInternoView.btnCerrarGastoInternoView.Click += new EventHandler(CerrarGastoInternoView);
            gastoInternoView.btnMinimizarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            gastoInternoView.btnMinimizarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            gastoInternoView.btnMinimizarGastoInternoView.Click += new EventHandler(MinimizarGastoInternoView);
            gastoInternoView.btnIngresarGastoInterno.Click += new EventHandler(AbrirIngresoGastoInternoView);
            gastoInternoView.btnEliminarGastoInterno.Click += new EventHandler(EliminarGastoInterno);
            gastoInternoView.btnEditarGastoInterno.Click += new EventHandler(AbrirEditarGastoInternoView);
        }

        public static GastoInternoView ObtenerInstanciaClienteView()
        {
            return gastoInternoView;
        }

        private void MinimizarGastoInternoView(object sender, EventArgs e)
        {
            gastoInternoView.WindowState = FormWindowState.Minimized;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            gastoInternoView.btnCerrarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            gastoInternoView.btnCerrarGastoInternoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            gastoInternoView.btnMinimizarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            gastoInternoView.btnMinimizarGastoInternoView.BackColor = Color.Transparent;
        }

        private void CerrarGastoInternoView(object sender, EventArgs e)
        {
            gastoInternoView.Hide();
            clienteView.Show();
        }

        private void AbrirEditarGastoInternoView(object sender, EventArgs e)
        {
            if (gastoInternoView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                EditarGastoInternoView editarGastoInternoView = EditarGastoInternoView.ObtenerInstancia();
                gastoInternoView.Hide();
                editarGastoInternoView.Show();
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista");
        }

        public void AbrirIngresoGastoInternoView(object sender, EventArgs e)
        {
            IngresoGastoInternoView ingresoGastoInternoView = IngresoGastoInternoView.ObtenerInstancia();
            gastoInternoView.Hide();
            ingresoGastoInternoView.Show();
        }

        private void EliminarGastoInterno(object sender, EventArgs e)
        {
            if (gastoInternoView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el gasto?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new GastoInternoDao().EliminarGastoInterno(idGastoInterno);
                    if (respuesta)
                    {
                        gastoInternoView.lstvGastosInternos.SelectedItems.Clear();
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

        private void MostrarGastosInternos(object sender, EventArgs e)
        {
            gastoInternoView.lstvGastosInternos.Items.Clear();
            idsGastosInternos.Clear();
            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternos();
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                idsGastosInternos.Add(gastoInternoDto.IdGastoInterno); //almacenamos ids de los gastos internos que se muestran 
                string[] row = { gastoInternoDto.TipoGastoInterno,CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno), CambioDeFormato.CambiarFormatoDeFecha(gastoInternoDto.FechaGastoInterno), gastoInternoDto.DescripcionGastoInterno};
                ListViewItem itemGastoInterno = new ListViewItem(row);
                gastoInternoView.lstvGastosInternos.Items.Add(itemGastoInterno);
            }
        }

        private int EncontrarIdGastoInterno(List<int> idsGastosInternos, int indice)
        {
            return idsGastosInternos[indice];
        }


        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (gastoInternoView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                indice = gastoInternoView.lstvGastosInternos.Items.IndexOf(gastoInternoView.lstvGastosInternos.SelectedItems[0]);
                idGastoInterno = EncontrarIdGastoInterno(idsGastosInternos, indice);
            }
        }

        public static GastoInternoView ObtenerInstancia()
        {
            return gastoInternoView;
        }
    }
}
