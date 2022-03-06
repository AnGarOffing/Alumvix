using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Abono;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Abono
{
    internal class EditarAbonoController
    {
        ActualizarAbonoView editarAbonoView;
        DetalleAbonoView detalleAbonoView; 

        public EditarAbonoController(ActualizarAbonoView actualizarAbonoVista) 
        {
            editarAbonoView = actualizarAbonoVista;
            detalleAbonoView = DetalleAbonoController.ObtenerInstanciaDetalleAbono();
            editarAbonoView.Activated += new EventHandler(CargarDatosAbono);
            editarAbonoView.txtIActualizarValorAbono.KeyPress += new KeyPressEventHandler(ValidarEntrada);
            editarAbonoView.txtIActualizarValorAbono.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            editarAbonoView.btnCerrarEditarAbonoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarAbonoView.btnCerrarEditarAbonoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarAbonoView.btnCerrarEditarAbonoView.Click += new EventHandler(CerrarEditarAbonoView);
            editarAbonoView.btnMinimizarEditarAbonoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarAbonoView.btnMinimizarEditarAbonoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarAbonoView.btnMinimizarEditarAbonoView.Click += new EventHandler(MinimizarEditarAbonoView);
            editarAbonoView.btnActualizarAbono.Click += new EventHandler(ActualizarAbonoEnBD);
            editarAbonoView.pnlSuperiorEditarAbonoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarAbonoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = editarAbonoView.txtIActualizarValorAbono;
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
                editarAbonoView.txtIActualizarValorAbono.Text = "";
            }
        }

        private void MinimizarEditarAbonoView(object sender, EventArgs e)
        {
            editarAbonoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarEditarAbonoView(object sender, EventArgs e)
        {
            editarAbonoView.Hide();
            detalleAbonoView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarAbonoView.btnCerrarEditarAbonoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarAbonoView.btnCerrarEditarAbonoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarAbonoView.btnMinimizarEditarAbonoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarAbonoView.btnMinimizarEditarAbonoView.BackColor = Color.Transparent;
        }

        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void CargarDatosAbono(object sender, EventArgs e)
        {
            AbonoDao abono = new AbonoDao();
            editarAbonoView.txtIActualizarValorAbono.Text = CambioDeFormato.QuitarFormatoANumero(detalleAbonoView.lstvDetalleAbonos.SelectedItems[0].SubItems[1].Text);
            editarAbonoView.dtpActualizarFechaAbono.Text= detalleAbonoView.lstvDetalleAbonos.SelectedItems[0].SubItems[2].Text;          
            editarAbonoView.cbActualizarFormaDePago.DataSource = abono.ConsultarFormasAbono();
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
                int valorSinFormato = Convert.ToInt32(editarAbonoView.txtIActualizarValorAbono.Text.Replace(".", ""));
                //string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(editarAbonoView.txtIActualizarValorAbono.Text);
                bool respuestaActualizacionAbono = abonoActualizado.ActualizarAbono(DetalleAbonoController.idAbono, Convert.ToInt32(valorSinFormato), editarAbonoView.cbActualizarFormaDePago.SelectedIndex, editarAbonoView.dtpActualizarFechaAbono.Text);
                if (respuestaActualizacionAbono)
                {
                    editarAbonoView.txtIActualizarValorAbono.Clear();
                    editarAbonoView.cbActualizarFormaDePago.SelectedIndex = 0;
                    MessageBox.Show("El abono ha sido actualizado con exito");
                    editarAbonoView.Hide();
                    detalleAbonoView.Show();
                }
                else MessageBox.Show("Error al actualizar el abono");
            }
        }
    }
}
