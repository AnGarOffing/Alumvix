using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class IngresoProveedorController
    {
        IngresoProveedorView ingresoProveedorView;
        ProveedoresView proveedoresView;

        public IngresoProveedorController(IngresoProveedorView ingresoProveedorVista)
        {
            ingresoProveedorView = ingresoProveedorVista;
            proveedoresView = ProveedoresController.ObtenerInstancia();
            ingresoProveedorView.txtIngresarNombreProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumerosyLetras);
            ingresoProveedorView.txtIngresarCelularProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoProveedorView.txtIngresarTelefonoProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoProveedorView.btnCerrarIngresoProveedorView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoProveedorView.btnCerrarIngresoProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoProveedorView.btnCerrarIngresoProveedorView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            ingresoProveedorView.btnMinimizarIngresoProveedorView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoProveedorView.btnMinimizarIngresoProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoProveedorView.btnMinimizarIngresoProveedorView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            ingresoProveedorView.btnGuardarNuevoProveedor.Click += new EventHandler(GuardarProveedor);
        }

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            ingresoProveedorView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            ingresoProveedorView.Hide();
            proveedoresView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoProveedorView.btnCerrarIngresoProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoProveedorView.btnCerrarIngresoProveedorView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoProveedorView.btnMinimizarIngresoProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoProveedorView.btnMinimizarIngresoProveedorView.BackColor = Color.Transparent;
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void ValidarEntradaNumerosyLetras(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros y letras");
        }

        private void GuardarProveedor(object sender, EventArgs e)
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            if (ValidacionesDeControles.ValidarBotonIngresoProveedor(ingresoProveedorView.txtIngresarNombreProveedor.Text) == false)
            {
                MessageBox.Show("Debe ingresar un nombre para el proveedor");
            }
            else
            {
                bool respuestaIngresoProveedor = proveedorDao.GuardarProveedor(ingresoProveedorView.txtIngresarNombreProveedor.Text, ingresoProveedorView.txtIngresarCelularProveedor.Text, ingresoProveedorView.txtIngresarTelefonoProveedor.Text, ingresoProveedorView.txtIngresarDireccionProveedor.Text);
                if (respuestaIngresoProveedor)
                {
                    ingresoProveedorView.txtIngresarNombreProveedor.Clear();
                    ingresoProveedorView.txtIngresarCelularProveedor.Clear();
                    ingresoProveedorView.txtIngresarTelefonoProveedor.Clear();
                    ingresoProveedorView.txtIngresarDireccionProveedor.Clear();
                    ingresoProveedorView.Hide();
                    MessageBox.Show("El proveedor ha sido guardado con exito");
                    proveedoresView.Show();
                }
                else MessageBox.Show("Error al intentar guardar el proveedor");
            }
        }
    }
}
