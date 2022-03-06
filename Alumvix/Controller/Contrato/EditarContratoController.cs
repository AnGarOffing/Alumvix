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
using System.Runtime.InteropServices;
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
            editarContratoView.txtEditarValorContrato.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            editarContratoView.btnMinimizarEditarContratoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarContratoView.btnMinimizarEditarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarContratoView.btnCerrarEditarContratoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarContratoView.btnCerrarEditarContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarContratoView.btnCerrarEditarContratoView.Click += new EventHandler(CerrarEditarContratoView);
            editarContratoView.btnMinimizarEditarContratoView.Click += new EventHandler(MinimizarEditarContratoView);
            editarContratoView.btnActualizarContrato.Click += new EventHandler(ActualizarContrato);
            editarContratoView.pnlSuperiorEditarContratoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarContratoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = editarContratoView.txtEditarValorContrato;
            if (txtValor.Text == "" || txtValor.Text == "0") return;
            try
            {
                decimal price;
                price = decimal.Parse(txtValor.Text, System.Globalization.NumberStyles.Currency);
                txtValor.Text = price.ToString("#,#");
                txtValor.SelectionStart = txtValor.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine +
                    "El valor no puede iniciar con punto (.)");
                editarContratoView.txtEditarValorContrato.Text = "";
            }
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
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void CargarDatosAEditar(object sender, EventArgs e)
        {
            editarContratoView.txtEditarValorContrato.Clear();
            editarContratoView.cbEditarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
            editarContratoView.cbEditarTipoFactura.Text = DetalleClienteController.ObtenerInstanciaDetalleClienteView().txtTipoFactura.Text;
            editarContratoView.cbEditarCategoriaFactura.DataSource = contratoDao.ObtenerCategoriasFactura();
            editarContratoView.cbEditarCategoriaFactura.Text = DetalleClienteController.ObtenerInstanciaDetalleClienteView().txtCategoriaFactura.Text;
            tipoFacturaAnterior = editarContratoView.cbEditarTipoFactura.Text;

            editarContratoView.cbEditarEstadoTrabajo.DataSource = contratoDao.ObtenerEstadosTrabajo();
            editarContratoView.cbEditarEstadoTrabajo.Text = detalleClienteView.txtEstadoTrabajo.Text;

            editarContratoView.txtEditarValorContrato.Text = CambioDeFormato.QuitarFormatoANumero(detalleClienteView.txtValorContrato.Text);
            valorContratoAnterior = editarContratoView.txtEditarValorContrato.Text.Replace(".", "");

            editarContratoView.dtpEditarFechaInicioContrato.Text = detalleClienteView.txtFechaInicioContrato.Text;
            editarContratoView.dtpEditarFechaTerminacionContrato.Text = detalleClienteView.txtFechaFinContrato.Text;
        }


        private void ActualizarContrato(object sender, EventArgs e)
        {
            if (ValidacionesDeControles.ValidarBotonIngresoContrato(editarContratoView.txtEditarValorContrato.Text,
                editarContratoView.cbEditarTipoFactura.SelectedIndex,
                editarContratoView.cbEditarCategoriaFactura.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                string valorModificado = editarContratoView.txtEditarValorContrato.Text.Replace(".", "");
                int valorContratoCalculado;
                ContratoDao contratoDao = new ContratoDao();
                if ((editarContratoView.cbEditarTipoFactura.SelectedIndex == 1 && valorContratoAnterior != valorModificado) || (editarContratoView.cbEditarTipoFactura.SelectedItem.ToString() != tipoFacturaAnterior && editarContratoView.cbEditarTipoFactura.SelectedItem.ToString() == "LEGAL"))
                {
                    valorContratoCalculado = Logica.AplicarIVA(Convert.ToInt32(valorModificado), 1);
                }else
                if ((tipoFacturaAnterior != editarContratoView.cbEditarTipoFactura.SelectedItem.ToString() && tipoFacturaAnterior == "LEGAL") && (valorContratoAnterior == valorModificado))
                {
                    valorContratoCalculado = Logica.QuitarIVA(Convert.ToInt32(valorModificado));
                }
                else valorContratoCalculado = Convert.ToInt32(valorModificado);
                bool respuestaActualizacionContrato = contratoDao.ActualizarContrato(Convert.ToInt32(valorContratoCalculado.ToString()), editarContratoView.dtpEditarFechaInicioContrato.Text, editarContratoView.dtpEditarFechaTerminacionContrato.Text, editarContratoView.cbEditarEstadoTrabajo.SelectedIndex + 1, editarContratoView.cbEditarTipoFactura.SelectedIndex, editarContratoView.cbEditarCategoriaFactura.SelectedIndex, Convert.ToInt32(detalleClienteView.txtNumeroFactura.Text));
                if (respuestaActualizacionContrato)
                {
                    editarContratoView.txtEditarValorContrato.Clear();
                    editarContratoView.cbEditarTipoFactura.SelectedIndex = 0;
                    editarContratoView.cbEditarCategoriaFactura.SelectedIndex = 0;
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
