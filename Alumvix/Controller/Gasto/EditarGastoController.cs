using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class EditarGastoController
    {
        EditarGastoView editarGastoView;
        DetalleGastoView detalleGastoView = DetalleGastoController.ObtenerInstanciaDetalleGasto();

        public EditarGastoController(EditarGastoView editarGastoVista) 
        {
            editarGastoView = editarGastoVista;
            editarGastoView.Load += new EventHandler(CargarDatosGasto);
            editarGastoView.btnActualizarGasto.Click += new EventHandler(ActualizarGastoEnBD);
        }

        private void CargarDatosGasto(object sender, EventArgs e)
        {
            editarGastoView.txtIActualizarValorGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[1].Text;
            editarGastoView.dtpActualizarFechaGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[2].Text;
            editarGastoView.txtActualizarDescripcionGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[3].Text;
        }

        private void ActualizarGastoEnBD(object sender, EventArgs e)
        {
            GastoDao GastoActualizado = new GastoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGasto(editarGastoView.txtIActualizarValorGasto.Text) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaActualizacionGasto = GastoActualizado.ActualizarGasto(DetalleGastoController.idGasto, Convert.ToInt32(editarGastoView.txtIActualizarValorGasto.Text), editarGastoView.dtpActualizarFechaGasto.Text, editarGastoView.txtActualizarDescripcionGasto.Text);
                if (respuestaActualizacionGasto)
                {
                    editarGastoView.txtIActualizarValorGasto.Clear();
                    editarGastoView.Close();
                    MessageBox.Show("El gasto ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al actualizar el gasto");
            }
        }

    }
}
