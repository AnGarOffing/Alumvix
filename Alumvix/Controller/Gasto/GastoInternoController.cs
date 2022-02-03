using Alumvix.Controller.Reporte;
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
    internal class GastoInternoController
    {
        GastoInternoView gastoInternoView;
        //static List<int> idsGastosInternos = new List<int>();
        //public static int idGastoInterno;

        public GastoInternoController(GastoInternoView gastoInternoVista)
        {
            gastoInternoView = gastoInternoVista;
            gastoInternoView.Activated += new EventHandler(MostrarGastosInternos);
        }

        private void MostrarGastosInternos(object sender, EventArgs e)
        {
            gastoInternoView.lstvGastosInternos.Items.Clear();
            //idsGastos.Clear();
            GastoInternoDao gastoInternoDao = new GastoInternoDao();
            List<GastoInternoDto> listadoGastosInternos = gastoInternoDao.ObtenerGastosInternos();
            foreach (GastoInternoDto gastoInternoDto in listadoGastosInternos)
            {
                //idsGastosInternos.Add(gastoInterno.IdGastoInterno); //almacenamos ids de los gastos internos que se muestran 
                string[] row = { gastoInternoDto.TipoGastoInterno,CambioDeFormato.DarFormatoANumero(gastoInternoDto.ValorGastoInterno), CambioDeFormato.CambiarFormatoDeFecha(gastoInternoDto.FechaGastoInterno), gastoInternoDto.DescripcionGastoInterno};
                ListViewItem itemGastoInterno = new ListViewItem(row);
                gastoInternoView.lstvGastosInternos.Items.Add(itemGastoInterno);
            }
        }
    }
}
