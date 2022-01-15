using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class EditarContratoController
    {

        EditarContratoView editarContratoView;
        DetalleClienteView detalleClienteView;
        ContratoDao contratoDao;
        string valorContratoAComparar;

        public EditarContratoController(EditarContratoView editarContratoVista)
        {
            contratoDao = new ContratoDao();
            editarContratoView = editarContratoVista;
            detalleClienteView = DetalleClienteController.ObtenerInstanciaDetalleClienteView();
            editarContratoView.Load += new EventHandler(CargarDatosAEditar);
            editarContratoView.btnActualizarContrato.Click += new EventHandler(ActualizarContrato);          
        }

        private void CargarDatosAEditar(object sender, EventArgs e)
        {
            editarContratoView.txtEditarValorContrato.Clear();
            editarContratoView.cbEditarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
            editarContratoView.cbEditarTipoFactura.Text = DetalleClienteController.ObtenerInstanciaDetalleClienteView().txtTipoFactura.Text;

            editarContratoView.cbEditarEstadoTrabajo.DataSource = contratoDao.ObtenerEstadosTrabajo();
            editarContratoView.cbEditarEstadoTrabajo.Text = detalleClienteView.txtEstadoTrabajo.Text;

            editarContratoView.txtEditarValorContrato.Text = detalleClienteView.txtValorContrato.Text;
            valorContratoAComparar = editarContratoView.txtEditarValorContrato.Text;

            editarContratoView.dtpEditarFechaInicioContrato.Text = detalleClienteView.txtFechaInicioContrato.Text;
            editarContratoView.dtpEditarFechaTerminacionContrato.Text = detalleClienteView.txtFechaFinContrato.Text;
        }


        private void ActualizarContrato(object sender, EventArgs e)
        {
            if (ValidacionesDeControles.ValidarBotonIngresoContrato(editarContratoView.txtEditarValorContrato.Text, editarContratoView.cbEditarTipoFactura.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                int valorContratoCalculado;
                ContratoDao contratoDao = new ContratoDao();
                if (editarContratoView.cbEditarTipoFactura.SelectedIndex == 1 && valorContratoAComparar != editarContratoView.txtEditarValorContrato.Text)
                {
                    valorContratoCalculado = Logica.AplicarIVA(Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(editarContratoView.txtEditarValorContrato.Text)), 1);
                }
                else valorContratoCalculado = Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(editarContratoView.txtEditarValorContrato.Text));
                bool respuestaActualizacionContrato = contratoDao.ActualizarContrato(Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(valorContratoCalculado.ToString())), editarContratoView.dtpEditarFechaInicioContrato.Text, editarContratoView.dtpEditarFechaTerminacionContrato.Text, editarContratoView.cbEditarEstadoTrabajo.SelectedIndex + 1, editarContratoView.cbEditarTipoFactura.SelectedIndex,Convert.ToInt32(detalleClienteView.txtNumeroFactura.Text));
                if (respuestaActualizacionContrato)
                {
                    editarContratoView.txtEditarValorContrato.Clear();
                    editarContratoView.cbEditarTipoFactura.SelectedIndex = 0;
                    editarContratoView.Close();
                    MessageBox.Show("El contrato ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al intentar actualizar el contrato");
            }
        }
    }
}
