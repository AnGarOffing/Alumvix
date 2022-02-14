using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Cliente;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Cliente
{
    internal class IngresoClienteController
    {
        IngresoClienteView ingresoClienteView;
        ClienteView clienteView = ClienteController.ObtenerInstanciaClienteView();

        public IngresoClienteController(IngresoClienteView ingresoClienteVista)
        {
            ingresoClienteView = ingresoClienteVista;
            ingresoClienteView.Activated += new EventHandler(LimpiarControles);
            ingresoClienteView.LostFocus += new EventHandler(PersistirDatos);
            ingresoClienteView.txtIngresarIdCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.txtIngresarNombreCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaLetrasYNumeros);
            ingresoClienteView.txtIngresarTelefonoCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.txtIngresarCelularCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.btnGuardarNuevoCliente.Click += new EventHandler(GuardarCliente);
            ingresoClienteView.btnMinimizarIngresoClienteView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoClienteView.btnMinimizarIngresoClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoClienteView.btnCerrarIngresoClienteView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoClienteView.btnCerrarIngresoClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoClienteView.btnCerrarIngresoClienteView.Click += new EventHandler(CerrarFormularioIngresoClienteView);
            ingresoClienteView.btnMinimizarIngresoClienteView.Click += new EventHandler(MinimizarFormularioIngresoClienteView);
        }

        private void PersistirDatos(object sender, EventArgs e)
        {
            ClienteDto clienteDto = new ClienteDto();
            clienteDto.IdentificacionCliente =  ingresoClienteView.txtIngresarIdCliente.Text;

            
        }

        private void LimpiarControles(object sender, EventArgs e)
        {
            ingresoClienteView.txtIngresarIdCliente.Clear();
            ingresoClienteView.txtIngresarNombreCliente.Clear();
            ingresoClienteView.txtIngresarDireccionCliente.Clear();
            ingresoClienteView.txtIngresarCorreoCliente.Clear();
            ingresoClienteView.txtIngresarTelefonoCliente.Clear();
            ingresoClienteView.txtIngresarCelularCliente.Clear();
        }

        private void MinimizarFormularioIngresoClienteView(object sender, EventArgs e)
        {
            ingresoClienteView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarFormularioIngresoClienteView(object sender, EventArgs e)
        {
            ingresoClienteView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoClienteView.btnMinimizarIngresoClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoClienteView.btnMinimizarIngresoClienteView.BackColor = Color.Transparent;
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoClienteView.btnCerrarIngresoClienteView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoClienteView.btnCerrarIngresoClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void ValidarEntradaLetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros y letras");
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumeros(e);
        }

        private void GuardarCliente(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            if (ValidacionesDeControles.ValidarBotonIngresoCliente(ingresoClienteView.txtIngresarNombreCliente.Text) == false)
            {
                MessageBox.Show("El campo Nombre no ha sido diligenciado");
            }
            else
            {
                bool respuestaIngresoCliente = clienteDao.GuardarCliente(ingresoClienteView.txtIngresarIdCliente.Text, ingresoClienteView.txtIngresarNombreCliente.Text, ingresoClienteView.txtIngresarCorreoCliente.Text, ingresoClienteView.txtIngresarCelularCliente.Text, ingresoClienteView.txtIngresarTelefonoCliente.Text, ingresoClienteView.txtIngresarDireccionCliente.Text);
                if (respuestaIngresoCliente)
                {
                    ingresoClienteView.txtIngresarIdCliente.Clear();
                    ingresoClienteView.txtIngresarNombreCliente.Clear();
                    ingresoClienteView.txtIngresarDireccionCliente.Clear();
                    ingresoClienteView.txtIngresarCorreoCliente.Clear();
                    ingresoClienteView.txtIngresarTelefonoCliente.Clear();
                    ingresoClienteView.txtIngresarCelularCliente.Clear();
                    ingresoClienteView.Hide();
                    MessageBox.Show("El cliente ha sido guardado con exito");
                    clienteView.Show();
                    
                }
                else MessageBox.Show("Error al guardar el cliente");
            }
        }
    }
}
