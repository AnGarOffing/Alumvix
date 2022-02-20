using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Producto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Producto
{
    internal class IngresoProductoController
    {
        IngresoProductoView ingresoProductoView;
        DetalleClienteView detalleClienteView;

        public IngresoProductoController(IngresoProductoView ingresoProductoVista) 
        {
            ingresoProductoView = ingresoProductoVista;
            detalleClienteView = DetalleClienteController.ObtenerInstanciaDetalleClienteView();
            ingresoProductoView.Load += new EventHandler(CargarProductos);
            ingresoProductoView.btnCerrarIngresoProductoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            ingresoProductoView.btnCerrarIngresoProductoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            ingresoProductoView.btnCerrarIngresoProductoView.Click += new EventHandler(CerrarIngresoProductoView);
            ingresoProductoView.btnMinimizarIngresoProductoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            ingresoProductoView.btnMinimizarIngresoProductoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            ingresoProductoView.btnMinimizarIngresoProductoView.Click += new EventHandler(MinimizarIngresoProductoView);
            ingresoProductoView.btnGuardarProducto.Click += new EventHandler(IngresarProducto);
            ingresoProductoView.pnlSuperiorIngresoProductoView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(ingresoProductoView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MinimizarIngresoProductoView(object sender, EventArgs e)
        {
            ingresoProductoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoProductoView(object sender, EventArgs e)
        {
            ingresoProductoView.Hide();
            detalleClienteView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            ingresoProductoView.btnCerrarIngresoProductoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            ingresoProductoView.btnCerrarIngresoProductoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            ingresoProductoView.btnMinimizarIngresoProductoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            ingresoProductoView.btnMinimizarIngresoProductoView.BackColor = Color.Transparent;
        }

        private void CargarProductos(object sender, EventArgs e)
        {
            ProductoDao productoDao = new ProductoDao();
            ingresoProductoView.cbSeleccionarProducto.DataSource = productoDao.ObtenerAllProducts();
            ingresoProductoView.cbSeleccionarProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IngresarProducto(object sender, EventArgs e)
        {
            ProductoDao producto = new ProductoDao();
            string respuesta = ValidacionesDeControles.ValidarBotonIngresoProducto(ingresoProductoView.cbSeleccionarProducto.SelectedIndex, ingresoProductoView.cbSeleccionarProducto.GetItemText(ingresoProductoView.cbSeleccionarProducto.SelectedItem));
            if(respuesta != null) MessageBox.Show(respuesta);
            else
            {
                string mensaje = producto.IngresarProducto(DetalleClienteController.ObtenerIdContrato(), ingresoProductoView.cbSeleccionarProducto.SelectedIndex);        
                ingresoProductoView.cbSeleccionarProducto.SelectedIndex = 0;
                ingresoProductoView.Hide();
                MessageBox.Show(mensaje);
                detalleClienteView.Show();
            }                     
        }
    }
}
