using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Gasto;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class IngresoGastoController
    {
        IngresoGastoView ingresoGastoView;
        DetalleGastoView detalleGastoView;
        int idContrato;

        public IngresoGastoController(IngresoGastoView ingresoGastoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            ingresoGastoView = ingresoGastoVista;
            detalleGastoView = DetalleGastoController.ObtenerInstanciaDetalleGasto();
            ingresoGastoView.Load += new EventHandler(LimpiarCampos);
            ingresoGastoView.Load += new EventHandler(CargarTiposDeGastoMaterial);
            ingresoGastoView.Load += new EventHandler(CargarProveedores);
            ingresoGastoView.Activated += new EventHandler(ActualizarIdContrato);
            ingresoGastoView.txtIngresarValorGasto.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoGastoView.txtIngresarValorGasto.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            ingresoGastoView.txtNumeroFactura.KeyPress += new KeyPressEventHandler(ValidarEntradaLetrasYNumeros);
            //ingresoGastoView.cbIngresarTipoGasto.SelectedIndexChanged += new EventHandler(HabilitarControlesFactyProv);
            ingresoGastoView.btnCerrarIngresoGastoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoGastoView.btnCerrarIngresoGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoGastoView.btnCerrarIngresoGastoView.Click += new EventHandler(CerrarIngresoGastoView);
            ingresoGastoView.btnMinimizarIngresoGastoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoGastoView.btnMinimizarIngresoGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoGastoView.btnMinimizarIngresoGastoView.Click += new EventHandler(MinimizarIngresoGastoView);
            ingresoGastoView.btnGuardarNuevoGasto.Click += new EventHandler(IngresarGasto);
            ingresoGastoView.pnlSuperiorIngresoGastoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(ingresoGastoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = ingresoGastoView.txtIngresarValorGasto;
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
                ingresoGastoView.txtIngresarValorGasto.Text = "";
            }
        }

        private void MinimizarIngresoGastoView(object sender, EventArgs e)
        {
            ingresoGastoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoView(object sender, EventArgs e)
        {
            ingresoGastoView.Hide();
            detalleGastoView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoGastoView.btnCerrarIngresoGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoGastoView.btnCerrarIngresoGastoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoGastoView.btnMinimizarIngresoGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoGastoView.btnMinimizarIngresoGastoView.BackColor = Color.Transparent;
        }

        private void ValidarEntradaLetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void ActualizarIdContrato(object sender, EventArgs e)
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            ingresoGastoView.txtIngresarValorGasto.Clear();
            ingresoGastoView.txtDescripcionGasto.Clear();
        }

        private void IngresarGasto(object sender, EventArgs e)
        {
            bool respuesta = false;
            GastoDao gastoActualizado = new GastoDao();
            if (ingresoGastoView.txtNumeroFactura.Enabled == false)
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGastoSinFactura(ingresoGastoView.txtIngresarValorGasto.Text, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex);
            }
            else
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGasto(ingresoGastoView.txtIngresarValorGasto.Text, ingresoGastoView.txtNumeroFactura.Text, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex, ingresoGastoView.cbIngresarProveedor.SelectedIndex);
            }
            if (respuesta)
            {
                GastoDao nuevoGasto = new GastoDao();
                //string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(ingresoGastoView.txtIngresarValorGasto.Text);
                int valorSinFormato = Convert.ToInt32(ingresoGastoView.txtIngresarValorGasto.Text.Replace(".", ""));
                int idTipoGasto = nuevoGasto.ObtenerTipoGastoPorNombre(ingresoGastoView.cbIngresarTipoGasto.GetItemText(ingresoGastoView.cbIngresarTipoGasto.SelectedItem));
                bool respuestaIngresoGasto = gastoActualizado.IngresarGasto(ingresoGastoView.txtNumeroFactura.Text, valorSinFormato, ingresoGastoView.dtpFechaIngresoGasto.Text, ingresoGastoView.txtDescripcionGasto.Text, ingresoGastoView.cbIngresarProveedor.SelectedIndex, idTipoGasto, idContrato);
                if (respuestaIngresoGasto)
                {
                    //editarGastoView.txtActualizarValorGasto.Clear();
                    //ingresoGastoView.Close();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                    ingresoGastoView.Hide();
                    detalleGastoView.Show();
                }
                else MessageBox.Show("Error al guardar el gasto");
            }
            else
            {
                if (ingresoGastoView.cbIngresarProveedor.SelectedIndex == 0 || ingresoGastoView.txtIngresarValorGasto.Text == "" || ingresoGastoView.txtNumeroFactura.Text == "")
                {
                    MessageBox.Show("Debe diligenciar todos los campos");
                }         
            }
        }

        private void CargarTiposDeGastoMaterial(object sender, EventArgs e)
        {
            GastoDao tipoGasto = new GastoDao();
            ingresoGastoView.cbIngresarTipoGasto.DataSource = tipoGasto.ObtenerTiposDeGastoDeContrato();
            ingresoGastoView.cbIngresarTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarProveedores(object sender, EventArgs e)
        {
            ProveedorDao proveedor = new ProveedorDao();
            ingresoGastoView.cbIngresarProveedor.DataSource = proveedor.ConsultarProveedoresParaCB();
            ingresoGastoView.cbIngresarProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void HabilitarControlesFactyProv(object sender, EventArgs e)
        {
            if (ingresoGastoView.cbIngresarTipoGasto.SelectedIndex == 2)
            {
                ingresoGastoView.cbIngresarProveedor.Enabled = true;
                ingresoGastoView.cbIngresarProveedor = RefrescarComboBoxProveedores(ingresoGastoView.cbIngresarProveedor);
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = 0;
                ingresoGastoView.txtNumeroFactura.Enabled = true;
                ingresoGastoView.txtNumeroFactura.Text = "";
            }
            else
            {
                ingresoGastoView.cbIngresarProveedor = RefrescarComboBoxProveedores(ingresoGastoView.cbIngresarProveedor);
                ingresoGastoView.cbIngresarProveedor.Enabled = false;
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = 1;
                ingresoGastoView.txtNumeroFactura.Text = "No Aplica";
                ingresoGastoView.txtNumeroFactura.Enabled = false;
            }
        }

        private ComboBox RefrescarComboBoxProveedores(ComboBox comboBoxProveedores) 
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            comboBoxProveedores.DataSource = proveedorDao.ConsultarProveedoresParaCB();
            return comboBoxProveedores;
        }
    }
}
