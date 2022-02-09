using Alumvix.Model.Dao;
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
    internal class IngresoGastoInternoController
    {
        IngresoGastoInternoView ingresoGastoInternoView;
        public IngresoGastoInternoController(IngresoGastoInternoView ingresoGastoInternoVista)
        {
            ingresoGastoInternoView = ingresoGastoInternoVista;
            ingresoGastoInternoView.Load += new EventHandler(CargarComboTiposDeGastoInterno);
            ingresoGastoInternoView.txtIngresarValorGastoInterno.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoGastoInternoView.btnGuardarNuevoGastoInterno.Click += new EventHandler(IngresarGastoInterno);
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void CargarComboTiposDeGastoInterno(object sender, EventArgs e)
        {
            GastoInternoDao tipoGastoInterno = new GastoInternoDao();
            ingresoGastoInternoView.cbIngresarTipoGastoInterno.DataSource = tipoGastoInterno.ObtenerTiposDeGastoInterno();
            ingresoGastoInternoView.cbIngresarTipoGastoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IngresarGastoInterno(object sender, EventArgs e)
        {
            GastoInternoDao nuevoGastoInterno = new GastoInternoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGastoInterno(ingresoGastoInternoView.txtIngresarValorGastoInterno.Text, ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                int idTipoGastoInterno = nuevoGastoInterno.ObtenerTipoGastoInternoPorNombre(ingresoGastoInternoView.cbIngresarTipoGastoInterno.GetItemText(ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedItem));
                bool respuestaIngresoGastoInterno = nuevoGastoInterno.IngresarGastoInterno(Convert.ToInt32(ingresoGastoInternoView.txtIngresarValorGastoInterno.Text), ingresoGastoInternoView.dtpFechaIngresoGastoInterno.Text, ingresoGastoInternoView.txtDescripcionGastoInterno.Text, idTipoGastoInterno);
                if (respuestaIngresoGastoInterno)
                {
                    ingresoGastoInternoView.txtIngresarValorGastoInterno.Clear();
                    ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedIndex = 0;
                    ingresoGastoInternoView.Close();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                }
                else MessageBox.Show("Error al guardar el gasto");
            }
        }
    }
}
