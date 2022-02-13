using Alumvix.Model.Dao;
using Alumvix.Model.Negocio;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class IngresoContratoController
    {
        IngresoContratoView ingresoContratoView;
        ClienteView clienteView;
        DetalleClienteView detalleClienteView;
        public IngresoContratoController(IngresoContratoView ingresoContratoVista)
        {
            ingresoContratoView = ingresoContratoVista;
            ingresoContratoView.Load += new EventHandler(CargarTiposFactura);
            ingresoContratoView.txtIngresarValorContrato.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoContratoView.txtIngresarValorContrato.TextChanged += new EventHandler(AplicarSeparadoresAValor);
            ingresoContratoView.btnMinimizarIngresoContratoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoContratoView.btnMinimizarIngresoContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoContratoView.btnCerrarIngresoContratoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoContratoView.btnCerrarIngresoContratoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoContratoView.btnCerrarIngresoContratoView.Click += new EventHandler(CerrarIngresoContratoView);
            ingresoContratoView.btnMinimizarIngresoContratoView.Click += new EventHandler(MinimizarIngresoContratoView);
            ingresoContratoView.btnGuardarNuevoContrato.Click += new EventHandler(GuardarContrato);
        }

        private void AplicarSeparadoresAValor(object sender, EventArgs e)
        {
            TextBox txtValor = ingresoContratoView.txtIngresarValorContrato;
            if (txtValor.Text == "" || txtValor.Text == "0") return;
            decimal price;
            price = decimal.Parse(txtValor.Text, System.Globalization.NumberStyles.Currency);
            txtValor.Text = price.ToString("#,#");
            txtValor.SelectionStart = txtValor.Text.Length;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoContratoView.btnMinimizarIngresoContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoContratoView.btnMinimizarIngresoContratoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoContratoView.btnCerrarIngresoContratoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoContratoView.btnCerrarIngresoContratoView.BackColor = Color.Transparent;
        }

        private void MinimizarIngresoContratoView(object sender, EventArgs e)
        {
            ingresoContratoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoContratoView(object sender, EventArgs e)
        {
            ingresoContratoView.Hide();
            detalleClienteView = DetalleClienteView.ObtenerInstancia();
            detalleClienteView.Show();
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void GuardarContrato(object sender, EventArgs e)
        {
            int valorSinFormato = Convert.ToInt32(ingresoContratoView.txtIngresarValorContrato.Text.Replace(".", ""));
            if (ValidacionesDeControles.ValidarBotonIngresoContrato(valorSinFormato.ToString(), ingresoContratoView.cbIngresarTipoFactura.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                if (ingresoContratoView.dtpFechaTerminacionContrato.Value.Date <= ingresoContratoView.dtpFechaInicioContrato.Value.Date)
                {
                    MessageBox.Show("La fecha de Terminacion no puede ser inferior a la fecha de inicio");
                }
                else
                {
                    int valorContratoCalculado;
                    ContratoDao contratoDao = new ContratoDao();
                    if (ingresoContratoView.cbIngresarTipoFactura.SelectedIndex == 1)
                    {
                        valorContratoCalculado = Logica.AplicarIVA(Convert.ToInt32(valorSinFormato.ToString()), 1);
                    }
                    else valorContratoCalculado = Convert.ToInt32(valorSinFormato.ToString());

                    bool respuestaIngresoContrato = contratoDao.GuardarContrato(valorContratoCalculado, ingresoContratoView.dtpFechaInicioContrato.Text, ingresoContratoView.dtpFechaTerminacionContrato.Text, 1, 1, ingresoContratoView.cbIngresarTipoFactura.SelectedIndex, ClienteController.ObtenerIdCliente());
                    if (respuestaIngresoContrato)
                    {
                        ingresoContratoView.txtIngresarValorContrato.Clear();
                        ingresoContratoView.cbIngresarTipoFactura.SelectedIndex = 0;
                        //ingresoContratoView.Close();
                        ingresoContratoView.Hide();
                        MessageBox.Show("El contrato ha sido guardado con exito");
                        clienteView = ClienteView.ObtenerInstancia();
                        clienteView.Show();
                    }
                    else MessageBox.Show("Error al guardar el contrato");
                }
               
            }      
        }

        private void CargarTiposFactura(object sender, EventArgs e)
        {
            ingresoContratoView.txtIngresarValorContrato.Clear();
            ContratoDao contratoDao = new ContratoDao();
            ingresoContratoView.cbIngresarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
        }
    }
}
