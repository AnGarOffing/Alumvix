using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class EditarContratoController
    {

        EditarContratoView editarContratoView;
        DetalleClienteView detalleClienteView;
        ContratoDao contratoDao;
        string valorContratoAnterior;
        string tipoFacturaAnterior;

        public EditarContratoController(EditarContratoView editarContratoVista)
        {
            contratoDao = new ContratoDao();
            editarContratoView = editarContratoVista;
            detalleClienteView = DetalleClienteController.ObtenerInstanciaDetalleClienteView();
            editarContratoView.Load += new EventHandler(CargarDatosAEditar);
            editarContratoView.txtEditarValorContrato.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarContratoView.btnMinimizarEditarContratoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarContratoView.btnMinimizarEditarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarContratoView.btnCerrarEditarContratoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarContratoView.btnCerrarEditarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarContratoView.btnCerrarEditarContratoView.Click += new EventHandler(CerrarEditarContratoView);
            editarContratoView.btnMinimizarEditarContratoView.Click += new EventHandler(MinimizarEditarContratoView);
            editarContratoView.btnActualizarContrato.Click += new EventHandler(ActualizarContrato);          
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarContratoView.btnMinimizarEditarContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarContratoView.btnMinimizarEditarContratoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarContratoView.btnCerrarEditarContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarContratoView.btnCerrarEditarContratoView.BackColor = Color.Transparent;
        }

        private void MinimizarEditarContratoView(object sender, EventArgs e)
        {
            editarContratoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarEditarContratoView(object sender, EventArgs e)
        {
            editarContratoView.Hide();
            detalleClienteView = DetalleClienteView.ObtenerInstancia();
            detalleClienteView.Show();
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void CargarDatosAEditar(object sender, EventArgs e)
        {
            editarContratoView.txtEditarValorContrato.Clear();
            editarContratoView.cbEditarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
            editarContratoView.cbEditarTipoFactura.Text = DetalleClienteController.ObtenerInstanciaDetalleClienteView().txtTipoFactura.Text;
            tipoFacturaAnterior = editarContratoView.cbEditarTipoFactura.Text;

            editarContratoView.cbEditarEstadoTrabajo.DataSource = contratoDao.ObtenerEstadosTrabajo();
            editarContratoView.cbEditarEstadoTrabajo.Text = detalleClienteView.txtEstadoTrabajo.Text;

            editarContratoView.txtEditarValorContrato.Text = detalleClienteView.txtValorContrato.Text;
            valorContratoAnterior = editarContratoView.txtEditarValorContrato.Text;

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
                if ((editarContratoView.cbEditarTipoFactura.SelectedIndex == 1 && valorContratoAnterior != editarContratoView.txtEditarValorContrato.Text) || (editarContratoView.cbEditarTipoFactura.Text != tipoFacturaAnterior && editarContratoView.cbEditarTipoFactura.Text == "LEGAL"))
                {
                    valorContratoCalculado = Logica.AplicarIVA(Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(editarContratoView.txtEditarValorContrato.Text)), 1);
                }else
                if ((tipoFacturaAnterior != editarContratoView.cbEditarTipoFactura.Text && tipoFacturaAnterior == "LEGAL") && (valorContratoAnterior == editarContratoView.txtEditarValorContrato.Text))
                {
                    valorContratoCalculado = Logica.QuitarIVA(Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(editarContratoView.txtEditarValorContrato.Text)));
                }
                else valorContratoCalculado = Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(editarContratoView.txtEditarValorContrato.Text));
                bool respuestaActualizacionContrato = contratoDao.ActualizarContrato(Convert.ToInt32(CambioDeFormato.QuitarFormatoANumero(valorContratoCalculado.ToString())), editarContratoView.dtpEditarFechaInicioContrato.Text, editarContratoView.dtpEditarFechaTerminacionContrato.Text, editarContratoView.cbEditarEstadoTrabajo.SelectedIndex + 1, editarContratoView.cbEditarTipoFactura.SelectedIndex,Convert.ToInt32(detalleClienteView.txtNumeroFactura.Text));
                if (respuestaActualizacionContrato)
                {
                    editarContratoView.txtEditarValorContrato.Clear();
                    editarContratoView.cbEditarTipoFactura.SelectedIndex = 0;
                    //editarContratoView.Close();
                    editarContratoView.Hide();
                    MessageBox.Show("El contrato ha sido actualizado con exito");
                    detalleClienteView = DetalleClienteView.ObtenerInstancia();
                    detalleClienteView.Show();
                }
                else MessageBox.Show("Error al intentar actualizar el contrato");
            }
        }
    }
}
