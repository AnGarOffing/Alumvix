using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Producto
{
    internal class IngresoProductoController
    {
        IngresoProductoView ingresoProductoView;

        public IngresoProductoController(IngresoProductoView ingresoProductoVista) 
        {
            ingresoProductoView = ingresoProductoVista;
            ingresoProductoView.Load += new EventHandler(CargarProductos);
            ingresoProductoView.btnGuardarProducto.Click += new EventHandler(IngresarProducto);
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
                ingresoProductoView.Close();
                MessageBox.Show(mensaje);                              
            }                     
        }
    }
}
