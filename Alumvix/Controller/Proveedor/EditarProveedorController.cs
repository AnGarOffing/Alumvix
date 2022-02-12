using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class EditarProveedorController
    {
        EditarProveedorView editarProveedorView;
        ProveedoresView proveedorView = ProveedorController.ObtenerInstancia();

        public EditarProveedorController(EditarProveedorView editarProveedorVista)
        {
            editarProveedorView = editarProveedorVista;
            editarProveedorView.Load += new EventHandler(CargarDatos);
            editarProveedorView.txtEditarNombreProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumerosyLetras);
            editarProveedorView.txtEditarCelularProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarProveedorView.txtEditarTelefonoProveedor.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarProveedorView.btnActualizarProveedor.Click += new EventHandler(ActualizarProveedor);
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
                    ProveedorController.IdProveedor);
                if (respuestaActualizacionProveedor)
                {
                    editarProveedorView.Close();
                    MessageBox.Show("El proveedor ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al intentar actualizar el proveedor");
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            editarProveedorView.txtEditarNombreProveedor.Text = proveedorView.lstvProveedores.SelectedItems[0].SubItems[0].Text;
            editarProveedorView.txtEditarCelularProveedor.Text = proveedorView.lstvProveedores.SelectedItems[0].SubItems[1].Text;
            editarProveedorView.txtEditarTelefonoProveedor.Text = proveedorView.lstvProveedores.SelectedItems[0].SubItems[2].Text;
            editarProveedorView.txtEditarDireccionProveedor.Text = proveedorView.lstvProveedores.SelectedItems[0].SubItems[3].Text;
        }
    }
}
