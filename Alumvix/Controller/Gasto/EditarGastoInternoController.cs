using Alumvix.Model.Dao;
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
    internal class EditarGastoInternoController
    {
        EditarGastoInternoView editarGastoInternoView;
        GastoInternoView gastoInternoView = GastoInternoController.ObtenerInstancia();

        public EditarGastoInternoController(EditarGastoInternoView editarGastoInternoVista)
        {
            editarGastoInternoView = editarGastoInternoVista;
            editarGastoInternoView.Load += new EventHandler(CargarDatos);
            editarGastoInternoView.txtEditarValorGastoInterno.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarGastoInternoView.btnActualizarGastoInterno.Click += new EventHandler(ActualizarGastoInterno);
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void ActualizarGastoInterno(object sender, EventArgs e)
        {
            bool respuesta = false;
            GastoInternoDao gastoActualizado = new GastoInternoDao();
            respuesta = ValidacionesDeControles.ValidarBotonIngresoGastoInterno(editarGastoInternoView.txtEditarValorGastoInterno.Text, editarGastoInternoView.cbEditarTipoGastoInterno.SelectedIndex);
            if (respuesta)
            {
                int idTipoGastoInterno = gastoActualizado.ObtenerTipoGastoInternoPorNombre(editarGastoInternoView.cbEditarTipoGastoInterno.GetItemText(editarGastoInternoView.cbEditarTipoGastoInterno.SelectedItem));
                string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(editarGastoInternoView.txtEditarValorGastoInterno.Text);
                bool respuestaIngresoGastoInterno = gastoActualizado.ActualizarGastoInterno(Convert.ToInt32(valorSinFormato), editarGastoInternoView.dtpEditarFechaGastoInterno.Text, editarGastoInternoView.txtEditarDescripcionGastoInterno.Text, idTipoGastoInterno);
                if (respuestaIngresoGastoInterno)
                {
                    editarGastoInternoView.Close();
                    MessageBox.Show("El gasto ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al actualizar el gasto");
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            GastoInternoDao tipoGastoInterno = new GastoInternoDao();
            editarGastoInternoView.cbEditarTipoGastoInterno.DataSource = tipoGastoInterno.ObtenerTiposDeGastoInterno();
            editarGastoInternoView.cbEditarTipoGastoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
            editarGastoInternoView.cbEditarTipoGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[0].Text;
            editarGastoInternoView.txtEditarValorGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[1].Text;
            editarGastoInternoView.txtEditarDescripcionGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[3].Text;
            editarGastoInternoView.dtpEditarFechaGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[2].Text;
        }
    }
}
