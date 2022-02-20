using Alumvix.Controller.Cliente;
using Alumvix.Controller.Reporte;
using Alumvix.Model;
using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Abono;
using Alumvix.View.Cliente;
using Alumvix.View.Reporte;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alumvix.Controller.Abono
{
    internal class IngresoAbonoController
    {
        IngresoAbonoView ingresoAbonoView;
        AdministradorReportesView administradorReportesView;
        DetalleAbonoView detalleAbonoView;
        int idContrato;

        public IngresoAbonoController(IngresoAbonoView ingresoAbonoVista)
        {
            ingresoAbonoView = ingresoAbonoVista;
            detalleAbonoView = DetalleAbonoController.ObtenerInstancia();
            administradorReportesView = AdministradorReportesController.ObtenerInstancia();
            idContrato = DetalleClienteController.ObtenerIdContrato();
            ingresoAbonoView.Activated += new EventHandler(CargarFormasDeAbono);
            ingresoAbonoView.Activated += new EventHandler(LimpiarControles);
            ingresoAbonoView.Activated += new EventHandler(ActualizarIdContrato);
            ingresoAbonoView.txtIngresarValorAbono.KeyPress += new KeyPressEventHandler(ValidarEntrada);
            ingresoAbonoView.txtIngresarValorAbono.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            ingresoAbonoView.btnCerrarIngresoAbonoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoAbonoView.btnCerrarIngresoAbonoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoAbonoView.btnCerrarIngresoAbonoView.Click += new EventHandler(CerrarIngresoAbonoView);
            ingresoAbonoView.btnMinimizarIngresoAbonoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoAbonoView.btnMinimizarIngresoAbonoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoAbonoView.btnMinimizarIngresoAbonoView.Click += new EventHandler(MinimizarIngresoAbonoView);
            ingresoAbonoView.btnGuardarNuevoAbono.Click += new EventHandler(IngresarAbono);
            ingresoAbonoView.pnlSuperiorIngresoAbonoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(ingresoAbonoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = ingresoAbonoView.txtIngresarValorAbono;
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
                ingresoAbonoView.txtIngresarValorAbono.Text = "";
            }
        }

        private void MinimizarIngresoAbonoView(object sender, EventArgs e)
        {
            ingresoAbonoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoAbonoView(object sender, EventArgs e)
        {
            ingresoAbonoView.Hide();
            detalleAbonoView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoAbonoView.btnCerrarIngresoAbonoView.BackColor = Color.FromArgb(223, 240, 254);
        }
            
        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoAbonoView.btnCerrarIngresoAbonoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoAbonoView.btnMinimizarIngresoAbonoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoAbonoView.btnMinimizarIngresoAbonoView.BackColor = Color.Transparent;
        }

        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
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
                int valorSinFormato = Convert.ToInt32(ingresoAbonoView.txtIngresarValorAbono.Text.Replace(".", ""));
                bool respuestaIngresoAbono = nuevoAbono.IngresarAbono(valorSinFormato, ingresoAbonoView.dtpIngresarFechaAbono.Text, idContrato, ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex);
                if (respuestaIngresoAbono)
                {
                    ingresoAbonoView.txtIngresarValorAbono.Clear();
                    ingresoAbonoView.cbIngresarFormaDePago.SelectedIndex = 0;
                    ingresoAbonoView.Hide();
                    MessageBox.Show("El abono ha sido guardado con exito");
                    detalleAbonoView.Show();
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
