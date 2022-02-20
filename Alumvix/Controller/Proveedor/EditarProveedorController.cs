using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class EditarProveedorController
    {
        EditarProveedorView editarProveedorView;
        ProveedoresView proveedoresView;

        public EditarProveedorController(EditarProveedorView editarProveedorVista)
        {
            editarProveedorView = editarProveedorVista;
            proveedoresView = ProveedoresController.ObtenerInstancia();
            editarProveedorView.Activated += new EventHandler(CargarDatos);
            editarProveedorView.txtEditarNombreProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumerosyLetras);
            editarProveedorView.txtEditarCelularProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarProveedorView.txtEditarTelefonoProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarProveedorView.btnCerrarEditarProveedorView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarProveedorView.btnCerrarEditarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarProveedorView.btnCerrarEditarProveedorView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            editarProveedorView.btnMinimizarEditarProveedorView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarProveedorView.btnMinimizarEditarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarProveedorView.btnMinimizarEditarProveedorView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            editarProveedorView.btnActualizarProveedor.Click += new EventHandler(ActualizarProveedor);
            editarProveedorView.pnlSuperiorEditarProveedorView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarProveedorView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            editarProveedorView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            editarProveedorView.Hide();
            proveedoresView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarProveedorView.btnCerrarEditarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarProveedorView.btnCerrarEditarProveedorView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarProveedorView.btnMinimizarEditarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarProveedorView.btnMinimizarEditarProveedorView.BackColor = Color.Transparent;
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

        private void ActualizarProveedor(object sender, EventArgs e)
        {
            ProveedorDao proveedor = new ProveedorDao();
            if (ValidacionesDeControles.ValidarBotonIngresoProveedor(editarProveedorView.txtEditarNombreProveedor.Text) == false)
            {
                MessageBox.Show("Debe proporcionar un nombre para el proveedor");
            }
            else
            {
                bool respuestaActualizacionProveedor = proveedor.ActualizarProveedor(
                    editarProveedorView.txtEditarNombreProveedor.Text,
                    editarProveedorView.txtEditarCelularProveedor.Text,
                    editarProveedorView.txtEditarTelefonoProveedor.Text,
                    editarProveedorView.txtEditarDireccionProveedor.Text,
                    ProveedoresController.IdProveedor);
                if (respuestaActualizacionProveedor)
                {
                    editarProveedorView.Hide();
                    MessageBox.Show("El proveedor ha sido actualizado con exito");
                    proveedoresView.Show();
                }
                else MessageBox.Show("Error al intentar actualizar el proveedor");
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            editarProveedorView.txtEditarNombreProveedor.Text = proveedoresView.lstvProveedores.SelectedItems[0].SubItems[0].Text;
            editarProveedorView.txtEditarCelularProveedor.Text = proveedoresView.lstvProveedores.SelectedItems[0].SubItems[1].Text;
            editarProveedorView.txtEditarTelefonoProveedor.Text = proveedoresView.lstvProveedores.SelectedItems[0].SubItems[2].Text;
            editarProveedorView.txtEditarDireccionProveedor.Text = proveedoresView.lstvProveedores.SelectedItems[0].SubItems[3].Text;
        }
    }
}
