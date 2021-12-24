using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View;
using Alumvix.View.Cliente;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        static List<string> registroCliente = new List<string>();
        ClienteView vista;
        DetalleClienteView detalleClienteVista;

        //sobrecarga de constructor: uno recibe ClienteView y el otro recibe DetalleClienteView
        public ClienteController(ClienteView view)
        {
            vista = view;
            vista.Load += new EventHandler(ObtenerListadoClientes);
            vista.txtFiltrarCliente.TextChanged += new EventHandler(ObtenerListadoClientes);
            vista.dataGridClientes.CellClick += new DataGridViewCellEventHandler(ObtenerRegistroCliente);
            vista.btnDetalleCliente.Click += new EventHandler(AbrirDetalleClienteForm);  
        }

        public ClienteController(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);

        }

        private void ObtenerListadoClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            vista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(vista.txtFiltrarCliente.Text);
        }

        //metodo para mostrar el detalle de un cliente seleccionado en el DataGridClientes
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.txtIdentificacion.Text = registroCliente[0].ToString();
            detalleClienteVista.txtNombre.Text = registroCliente[1].ToString();
            detalleClienteVista.txtCorreo.Text = registroCliente[2].ToString();
            detalleClienteVista.txtCelular.Text = registroCliente[3].ToString();
            detalleClienteVista.txtFijo.Text = registroCliente[4].ToString();
            detalleClienteVista.txtDireccion.Text = registroCliente[5].ToString();
        }
        
        private void AbrirDetalleClienteForm(object sender, EventArgs e)
        {
            detalleClienteVista = new DetalleClienteView();
            detalleClienteVista.Show();
        }
       

        //metodo para agregar las celdas de una fila seleccionada a la lista "registroCliente"
        private void ObtenerRegistroCliente(object sender, DataGridViewCellEventArgs e)
        {
            registroCliente.Clear();
            vista.dataGridClientes.CurrentRow.Selected = true;
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["identificacionCliente"].Value.ToString());
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["nombreCliente"].Value.ToString());
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["correoElectronicoCliente"].Value.ToString());
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["celularCliente"].Value.ToString());
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["telefonoFijoCliente"].Value.ToString());
            registroCliente.Add(vista.dataGridClientes.Rows[e.RowIndex].Cells["direccionCliente"].Value.ToString());
        }
    }
}
