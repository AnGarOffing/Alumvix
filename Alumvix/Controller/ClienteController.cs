using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        ClienteView vista;

        //CONSTRUCTOR
        public ClienteController(ClienteView view)
        {
            vista = view;
            //Inicializar eventos de la vista
            vista.Load += new EventHandler(ObtenerListadoClientes);
            vista.txtFiltrarCliente.TextChanged += new EventHandler(ObtenerListadoClientes);
        }

        private void ObtenerListadoClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            vista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(vista.txtFiltrarCliente.Text);
        }

        //metodo para mostrar el detalle de un cliente seleccionado en el DataGridClientes
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            
        }

       
    }
}
