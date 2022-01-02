using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class IngresoGastoController
    {
        IngresoGastoView ingresoGastoView;
        int idContrato;

        public IngresoGastoController(IngresoGastoView ingresoGastoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            ingresoGastoView = ingresoGastoVista;
            ingresoGastoView.btnGuardarNuevoGasto.Click += new EventHandler(IngresarGasto);
        }

        private void IngresarGasto(object sender, EventArgs e)
        {
            GastoDao nuevoGasto = new GastoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGasto(ingresoGastoView.txtIngresarValorGasto.Text) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaIngresoAbono = nuevoGasto.IngresarGasto(Convert.ToInt32(ingresoGastoView.txtIngresarValorGasto.Text), ingresoGastoView.dtpFechaIngresoGasto.Text, ingresoGastoView.txtDescripcionGasto.Text, idContrato);
                if (respuestaIngresoAbono)
                {
                    ingresoGastoView.txtIngresarValorGasto.Clear();
                    ingresoGastoView.txtDescripcionGasto.Clear();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                } 
                else MessageBox.Show("Error al guardar el gasto");
            }
        }
    }
}
