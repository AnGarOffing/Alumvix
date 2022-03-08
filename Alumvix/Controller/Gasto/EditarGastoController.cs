using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class EditarGastoController
    {
        EditarGastoView editarGastoView;
        DetalleGastoView detalleGastoView;

        public EditarGastoController(EditarGastoView editarGastoVista) 
        {
            editarGastoView = editarGastoVista;
            detalleGastoView = DetalleGastoController.ObtenerInstanciaDetalleGasto();
            editarGastoView.Activated += new EventHandler(CargarDatosGasto);
            editarGastoView.txtActualizarValorGasto.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarGastoView.txtActualizarValorGasto.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            //editarGastoView.cbEditarTipoGasto.SelectedIndexChanged += new EventHandler(HabilitarControlesFactyProv);
            editarGastoView.btnMinimizarEditarGastoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarGastoView.btnMinimizarEditarGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarGastoView.btnCerrarEditarGastoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarGastoView.btnCerrarEditarGastoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarGastoView.btnCerrarEditarGastoView.Click += new EventHandler(CerrarEditarGastoView);
            editarGastoView.btnMinimizarEditarGastoView.Click += new EventHandler(MinimizarEditarGastoView);
            editarGastoView.btnActualizarGasto.Click += new EventHandler(ActualizarGastoEnBD);
            editarGastoView.pnlSuperiorEditarGastoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarGastoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = editarGastoView.txtActualizarValorGasto;
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
                editarGastoView.txtActualizarValorGasto.Text = "";
            }
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarGastoView.btnMinimizarEditarGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarGastoView.btnMinimizarEditarGastoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarGastoView.btnCerrarEditarGastoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarGastoView.btnCerrarEditarGastoView.BackColor = Color.Transparent;
        }

        private void MinimizarEditarGastoView(object sender, EventArgs e)
        {
            editarGastoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarEditarGastoView(object sender, EventArgs e)
        {
            editarGastoView.Hide();
            detalleGastoView.Show();    
        }

        private void CargarDatosGasto(object sender, EventArgs e)
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            GastoDao gastoDao = new GastoDao();
            editarGastoView.txtEditarNumeroFactura.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[1].Text;
            editarGastoView.txtActualizarValorGasto.Text = CambioDeFormato.QuitarFormatoANumero(detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[2].Text);
            editarGastoView.dtpActualizarFechaGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[3].Text;
            editarGastoView.txtActualizarDescripcionGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[6].Text; 
            editarGastoView.cbEditarProveedor.DataSource = proveedorDao.ConsultarProveedoresParaCB();
            editarGastoView.cbEditarProveedor.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[5].Text;
            editarGastoView.cbEditarTipoGasto.DataSource = gastoDao.ObtenerTiposDeGastoDeContrato();
            editarGastoView.cbEditarTipoGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[4].Text;
        }

        private void ActualizarGastoEnBD(object sender, EventArgs e)
        {
            bool respuesta = false;
            GastoDao GastoActualizado = new GastoDao();
            if (editarGastoView.txtEditarNumeroFactura.Enabled == false)
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGastoSinFactura(editarGastoView.txtActualizarValorGasto.Text, editarGastoView.cbEditarTipoGasto.SelectedIndex);
            }
            else
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGasto(editarGastoView.txtActualizarValorGasto.Text, editarGastoView.txtEditarNumeroFactura.Text, editarGastoView.cbEditarTipoGasto.SelectedIndex, editarGastoView.cbEditarProveedor.SelectedIndex);
            }
            if (respuesta)
            {       
                GastoDao gastoDao = new GastoDao();
                //string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(editarGastoView.txtActualizarValorGasto.Text);
                int valorSinFormato = Convert.ToInt32(editarGastoView.txtActualizarValorGasto.Text.Replace(".", ""));
                int idTipoGasto = gastoDao.ObtenerTipoGastoPorNombre(editarGastoView.cbEditarTipoGasto.GetItemText(editarGastoView.cbEditarTipoGasto.SelectedItem));
                bool respuestaActualizacionGasto = GastoActualizado.ActualizarGasto(editarGastoView.txtEditarNumeroFactura.Text, Convert.ToInt32(valorSinFormato), editarGastoView.dtpActualizarFechaGasto.Text, editarGastoView.txtActualizarDescripcionGasto.Text, editarGastoView.cbEditarProveedor.SelectedIndex, idTipoGasto, DetalleGastoController.idGasto);
                if (respuestaActualizacionGasto)
                {
                    //editarGastoView.txtActualizarValorGasto.Clear();
                    editarGastoView.Hide();
                    MessageBox.Show("El gasto ha sido actualizado con exito");
                    detalleGastoView.Show();
                }
                else MessageBox.Show("Error al actualizar el gasto");
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }                                                                      
        }

        private void HabilitarControlesFactyProv(object sender, EventArgs e)
        {
            if (editarGastoView.cbEditarTipoGasto.SelectedIndex == 2)
            {
                editarGastoView.cbEditarProveedor.Enabled = true;
                ProveedorDao proveedorDao = new ProveedorDao();
                editarGastoView.cbEditarProveedor.DataSource = proveedorDao.ConsultarProveedoresParaCB();
                editarGastoView.cbEditarProveedor.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[5].Text;
                editarGastoView.txtEditarNumeroFactura.Enabled = true;
                editarGastoView.txtEditarNumeroFactura.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                editarGastoView.cbEditarProveedor.Enabled = false;
                editarGastoView.cbEditarProveedor.SelectedIndex = 1;
                editarGastoView.txtEditarNumeroFactura.Text = "No Aplica";
                editarGastoView.txtEditarNumeroFactura.Enabled = false;
            }
        }

    }
}
