using Alumvix.Controller.Cliente;
using Alumvix.Model;
using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Abono;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Abono
{
    internal class IngresoAbonoController
    {
        IngresoAbonoView ingresoAbonoView;
        int idContrato;

        public IngresoAbonoController(IngresoAbonoView ingresoAbonoVista)
        {
            ingresoAbonoView = ingresoAbonoVista;
            idContrato = DetalleClienteController.ObtenerIdContrato();
            ingresoAbonoView.Load += new EventHandler(CargarFormasDeAbono);
            ingresoAbonoView.Load += new EventHandler(LimpiarControles);
            ingresoAbonoView.btnGuardarNuevoAbono.Click += new EventHandler(IngresarAbono);
        }

        private void CargarFormasDeAbono(object sender, EventArgs e)
        {
            AbonoDao formaAbono = new AbonoDao();
            ingresoAbonoView.cbFormaDePago.DataSource = formaAbono.ConsultarFormasAbono();
            ingresoAbonoView.cbFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IngresarAbono(object sender, EventArgs e)
        {
            AbonoDao nuevoAbono = new AbonoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoAbono(ingresoAbonoView.txtIngresarValorAbono.Text, ingresoAbonoView.cbFormaDePago.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaIngresoAbono = nuevoAbono.IngresarAbono(Convert.ToInt32(ingresoAbonoView.txtIngresarValorAbono.Text), ingresoAbonoView.dtpFechaIngresoAbono.Text, idContrato, ingresoAbonoView.cbFormaDePago.SelectedIndex);
                if (respuestaIngresoAbono) MessageBox.Show("El abono ha sido guardado con exito");
                else MessageBox.Show("Error al guardar el abono");
            }                     
        }

        private void LimpiarControles(object sender, EventArgs e)
        {
            ingresoAbonoView.txtIngresarValorAbono.Clear();
            ingresoAbonoView.cbFormaDePago.SelectedIndex = 0;
        }
    }
}
