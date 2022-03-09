using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class IngresoGastoInternoController
    {
        IngresoGastoInternoView ingresoGastoInternoView;
        GastosInternosView gastoInternoView;
        public IngresoGastoInternoController(IngresoGastoInternoView ingresoGastoInternoVista)
        {
            ingresoGastoInternoView = ingresoGastoInternoVista;
            gastoInternoView = GastosInternosController.ObtenerInstanciaGastosInternosView();
            ingresoGastoInternoView.Activated += new EventHandler(CargarYLimpiarControles);
            ingresoGastoInternoView.txtIngresarValorGastoInterno.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoGastoInternoView.txtIngresarValorGastoInterno.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            ingresoGastoInternoView.btnCerrarIngresoGastoInternoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoGastoInternoView.btnCerrarIngresoGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoGastoInternoView.btnCerrarIngresoGastoInternoView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            ingresoGastoInternoView.btnMinimizarIngresoGastoInternoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoGastoInternoView.btnMinimizarIngresoGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoGastoInternoView.btnMinimizarIngresoGastoInternoView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            ingresoGastoInternoView.btnGuardarNuevoGastoInterno.Click += new EventHandler(IngresarGastoInterno);
            ingresoGastoInternoView.pnlSuperiorIngresoGastoInterno.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(ingresoGastoInternoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = ingresoGastoInternoView.txtIngresarValorGastoInterno;
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
                ingresoGastoInternoView.txtIngresarValorGastoInterno.Text = "";
            }
        }

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            ingresoGastoInternoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            ingresoGastoInternoView.Hide();
            gastoInternoView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoGastoInternoView.btnCerrarIngresoGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoGastoInternoView.btnCerrarIngresoGastoInternoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoGastoInternoView.btnMinimizarIngresoGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoGastoInternoView.btnMinimizarIngresoGastoInternoView.BackColor = Color.Transparent;
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void CargarYLimpiarControles(object sender, EventArgs e)
        {
            GastoInternoDao tipoGastoInterno = new GastoInternoDao();
            ingresoGastoInternoView.cbIngresarTipoGastoInterno.DataSource = tipoGastoInterno.ObtenerTiposDeGastoInterno();
            ingresoGastoInternoView.cbIngresarTipoGastoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
            ingresoGastoInternoView.txtIngresarValorGastoInterno.Clear();
            ingresoGastoInternoView.txtDescripcionGastoInterno.Clear();
        }

        private void IngresarGastoInterno(object sender, EventArgs e)
        {
            
            GastoInternoDao nuevoGastoInterno = new GastoInternoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGastoInterno(ingresoGastoInternoView.txtIngresarValorGastoInterno.Text, ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                int valorSinFormato = Convert.ToInt32(ingresoGastoInternoView.txtIngresarValorGastoInterno.Text.Replace(".", ""));
                int idTipoGastoInterno = nuevoGastoInterno.ObtenerTipoGastoInternoPorNombre(ingresoGastoInternoView.cbIngresarTipoGastoInterno.GetItemText(ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedItem));
                bool respuestaIngresoGastoInterno = nuevoGastoInterno.IngresarGastoInterno(valorSinFormato, ingresoGastoInternoView.dtpFechaIngresoGastoInterno.Text, ingresoGastoInternoView.txtDescripcionGastoInterno.Text, idTipoGastoInterno);
                if (respuestaIngresoGastoInterno)
                {
                    ingresoGastoInternoView.txtIngresarValorGastoInterno.Clear();
                    ingresoGastoInternoView.cbIngresarTipoGastoInterno.SelectedIndex = 0;
                    ingresoGastoInternoView.Hide();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                    gastoInternoView.Show();
                }
                else MessageBox.Show("Error al guardar el gasto");
            }
        }
    }
}
