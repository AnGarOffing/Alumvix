using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.View;
using Alumvix.View.Cliente;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        static List<string> registroCliente = new List<string>();
        ClienteView clienteVista;
        DetalleClienteView detalleClienteVista;
        static int idCliente;

        public ClienteController(ClienteView view)
        {
            clienteVista = view;
            clienteVista.Load += new EventHandler(ObtenerListadoClientes);
            clienteVista.txtFiltrarCliente.TextChanged += new EventHandler(ObtenerListadoClientes);
            clienteVista.dataGridClientes.CellClick += new DataGridViewCellEventHandler(ObtenerRegistroCliente);
            clienteVista.btnDetalleCliente.Click += new EventHandler(AbrirDetalleClienteForm);  
        }


        private void ObtenerListadoClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(clienteVista.txtFiltrarCliente.Text);
            clienteVista.dataGridClientes.ClearSelection();
        }

        public static List<string> CargarRegistroCliente()
        {
            return registroCliente;
        }

        
        //metodo para agregar las celdas de una fila seleccionada a la lista "registroCliente"
        private void ObtenerRegistroCliente(object sender, DataGridViewCellEventArgs e)
        {
            registroCliente.Clear();
            clienteVista.dataGridClientes.CurrentRow.Selected = true;
            idCliente = Convert.ToInt32(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["identificacionCliente"].Value.ToString());
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["nombreCliente"].Value.ToString());
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["correoElectronicoCliente"].Value.ToString());
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["celularCliente"].Value.ToString());
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["telefonoFijoCliente"].Value.ToString());
            registroCliente.Add(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["direccionCliente"].Value.ToString());
        }

        private void AbrirDetalleClienteForm(object sender, EventArgs e)
        {
            if (registroCliente.Count > 0)
            {
                detalleClienteVista = new DetalleClienteView();
                detalleClienteVista.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado un cliente");
            }

        }

        public static int ObtenerIdCliente()
        {
            return idCliente;
        }
    }
}
