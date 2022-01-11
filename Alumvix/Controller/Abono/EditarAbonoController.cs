using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Abono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Abono
{
    internal class EditarAbonoController
    {
        EditarAbonoView editarAbonoView;
        DetalleAbonoView detalleAbonoView = DetalleAbonoController.ObtenerInstanciaDetalleAbono();

        public EditarAbonoController(EditarAbonoView editarAbonoVista) 
        {
            editarAbonoView = editarAbonoVista;
            editarAbonoView.Load += new EventHandler(CargarDatosAbono);
            editarAbonoView.btnActualizarAbono.Click += new EventHandler(ActualizarAbonoEnBD);
        }

        private void CargarDatosAbono(object sender, EventArgs e)
        {
            AbonoDao formaAbono = new AbonoDao();
            editarAbonoView.txtIActualizarValorAbono.Text = detalleAbonoView.lstvDetalleAbonos.SelectedItems[0].SubItems[1].Text;
            editarAbonoView.dtpActualizarFechaAbono.Text= detalleAbonoView.lstvDetalleAbonos.SelectedItems[0].SubItems[2].Text;          
            editarAbonoView.cbActualizarFormaDePago.DataSource = formaAbono.ConsultarFormasAbono();
            editarAbonoView.cbActualizarFormaDePago.Text = detalleAbonoView.lstvDetalleAbonos.SelectedItems[0].SubItems[3].Text;
            editarAbonoView.cbActualizarFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ActualizarAbonoEnBD(object sender, EventArgs e)
        {
            AbonoDao abonoActualizado = new AbonoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoAbono(editarAbonoView.txtIActualizarValorAbono.Text, editarAbonoView.cbActualizarFormaDePago.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaActualizacionAbono = abonoActualizado.ActualizarAbono(DetalleAbonoController.idAbono, Convert.ToInt32(editarAbonoView.txtIActualizarValorAbono.Text), editarAbonoView.cbActualizarFormaDePago.SelectedIndex, editarAbonoView.dtpActualizarFechaAbono.Text);
                if (respuestaActualizacionAbono)
                {
                    editarAbonoView.txtIActualizarValorAbono.Clear();
                    editarAbonoView.cbActualizarFormaDePago.SelectedIndex = 0;
                    editarAbonoView.Close();
                    MessageBox.Show("El abono ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al actualizar el abono");
            }
        }

    }
}
