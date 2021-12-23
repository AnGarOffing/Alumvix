using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Inicializar eventos de la vista, en este caso el evento click del botón
            vista.btnConsultaClientes.Click += new EventHandler(ListarClientes);
        }

        private void ListarClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            vista.dataGridClientes.DataSource = clienteDao.ObtenerClientes();
        }
    }
}
