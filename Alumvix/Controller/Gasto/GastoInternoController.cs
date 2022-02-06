using Alumvix.Controller.Reporte;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class GastoInternoController
    {
        static GastoInternoView gastoInternoView;
        List<int> idsGastosInternos = new List<int>();
        public int idGastoInterno;
        int indice;

        public GastoInternoController(GastoInternoView gastoInternoVista)
        {
            gastoInternoView = gastoInternoVista;
            gastoInternoView.Activated += new EventHandler(MostrarGastosInternos);
            gastoInternoView.lstvGastosInternos.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            gastoInternoView.btnIngresarGastoInterno.Click += new EventHandler(AbrirIngresoGastoInternoView);
            gastoInternoView.btnEliminarGastoInterno.Click += new EventHandler(EliminarGastoInterno);
            gastoInternoView.btnEditarGastoInterno.Click += new EventHandler(AbrirEditarGastoInternoView);
        }

        private void AbrirEditarGastoInternoView(object sender, EventArgs e)
        {
            if (gastoInternoView.lstvGastosInternos.SelectedItems.Count > 0)
            {
                EditarGastoInternoView editarGastoInternoView = EditarGastoInternoView.ObtenerInstancia();
                editarGastoInternoView.ShowDialog();
            }
            else MessageBox.Show("Debe seleccionar un gasto de la lista");
        }

        public void AbrirIngresoGastoInternoView(object sender, EventArgs e)
        {
            IngresoGastoInternoView ingresoGastoInternoView = IngresoGastoInternoView.ObtenerInstancia();
            ingresoGastoInternoView.ShowDialog();
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
