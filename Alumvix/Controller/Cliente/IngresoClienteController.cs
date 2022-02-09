using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Cliente
{
    internal class IngresoClienteController
    {
        IngresoClienteView ingresoClienteView;

        public IngresoClienteController(IngresoClienteView ingresoClienteVista)
        {
            ingresoClienteView = ingresoClienteVista;
            ingresoClienteView.txtIngresarIdCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.txtIngresarNombreCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaLetrasYNumeros);
            ingresoClienteView.txtIngresarTelefonoCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.txtIngresarCelularCliente.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoClienteView.btnGuardarNuevoCliente.Click += new EventHandler(GuardarCliente);
        }

        private void ValidarEntradaLetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros y letras");
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
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
                    ingresoClienteView.Close();
                    MessageBox.Show("El cliente ha sido guardado con exito");
                }
                else MessageBox.Show("Error al guardar el cliente");
            }
        }
    }
}
