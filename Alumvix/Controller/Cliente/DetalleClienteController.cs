using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumvix.View.Cliente;

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        DetalleClienteView detalleClienteVista;
        List<string> registroCliente = ClienteController.CargarRegistroCliente();

        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);
        }


        //metodo para mostrar el detalle de un cliente en la vista "DetalleClienteView"
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.txtIdentificacion.Text = registroCliente[0].ToString();
            detalleClienteVista.txtNombre.Text = registroCliente[1].ToString();
            detalleClienteVista.txtCorreo.Text = registroCliente[2].ToString();
            detalleClienteVista.txtCelular.Text = registroCliente[3].ToString();
            detalleClienteVista.txtFijo.Text = registroCliente[4].ToString();
            detalleClienteVista.txtDireccion.Text = registroCliente[5].ToString();
        }

    }
}
