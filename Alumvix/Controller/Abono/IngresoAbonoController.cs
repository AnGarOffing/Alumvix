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
            ingresoAbonoView.Activated += new EventHandler(ActualizarIdContrato);
            ingresoAbonoView.btnGuardarNuevoAbono.Click += new EventHandler(IngresarAbono);
        }

        private void ActualizarIdContrato(object sender, EventArgs e)
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
        }

        private void CargarFormasDeAbono(object sender, EventArgs e)
        {
            AbonoDao formaAbono = new AbonoDao();
            ingresoAbonoView.cbIngresarFormaDePago.DataSource = formaAbono.ConsultarFormasAbono();
            ingresoAbonoView.cbIngresarFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IngresarAbono(object sender, EventArgs e)
        {
            AbonoDao nuevoAbono = new AbonoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoAbono(ingresoAbonoView.txtIngresarValorAbono.Text, ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaIngresoAbono = nuevoAbono.IngresarAbono(Convert.ToInt32(ingresoAbonoView.txtIngresarValorAbono.Text), ingresoAbonoView.dtpIngresarFechaAbono.Text, idContrato, ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex);
                if (respuestaIngresoAbono)
                {
                    ingresoAbonoView.txtIngresarValorAbono.Clear();
                    ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex = 0;
                    ingresoAbonoView.Close();
                    MessageBox.Show("El abono ha sido guardado con exito");
                } 
                else MessageBox.Show("Error al guardar el abono");
            }                     
        }

        private void LimpiarControles(object sender, EventArgs e)
        {
            ingresoAbonoView.txtIngresarValorAbono.Clear();
            ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex = 0;
        }
    }
}
