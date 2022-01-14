using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio;
using Alumvix.View;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        static List<ClienteDto> registroCliente = new List<ClienteDto>();
        ClienteView clienteVista;
        DetalleClienteView detalleClienteVista;
        static int idCliente;
        static string nombreCliente;
        Logica logica;

        public ClienteController(ClienteView view)
        {
            logica = new Logica();
            clienteVista = view;
            clienteVista.Load += new EventHandler(ObtenerListadoClientes);
            clienteVista.txtFiltrarCliente.TextChanged += new EventHandler(ObtenerListadoClientes);
            clienteVista.dataGridClientes.CellClick += new DataGridViewCellEventHandler(ObtenerRegistroCliente);
            clienteVista.btnDetalleCliente.Click += new EventHandler(AbrirDetalleClienteView);  
        }


        private void ObtenerListadoClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(clienteVista.txtFiltrarCliente.Text);
            clienteVista.dataGridClientes.ClearSelection();
        }

        public static List<ClienteDto> CargarRegistroCliente()
        {
            return registroCliente;
        }

        
        //metodo para agregar las celdas de una fila seleccionada a la lista "registroCliente"
        private void ObtenerRegistroCliente(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDto clienteDto = new ClienteDto();
            registroCliente.Clear();
            clienteVista.dataGridClientes.CurrentRow.Selected = true;
            idCliente = Convert.ToInt32(clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
            clienteDto.IdentificacionCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["identificacionCliente"].Value.ToString();
            clienteDto.NombreCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["nombreCliente"].Value.ToString();
            clienteDto.CorreoElectronicoCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["correoElectronicoCliente"].Value.ToString();
            clienteDto.CelularCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["celularCliente"].Value.ToString();
            clienteDto.TelefonoFijoCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["telefonoFijoCliente"].Value.ToString();
            clienteDto.DireccionCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["direccionCliente"].Value.ToString();
            registroCliente.Add(clienteDto);
            nombreCliente = clienteVista.dataGridClientes.Rows[e.RowIndex].Cells["nombreCliente"].Value.ToString();
        }

        private void AbrirDetalleClienteView(object sender, EventArgs e)
        {
            if (registroCliente.Count > 0)
            {
                int contadorContratos = logica.ConsultarCantidadContratos(ObtenerIdCliente());
                if (contadorContratos == 0)
                {
                    if (MessageBox.Show("El cliente no tiene contratos ¿Desea crear uno?", "CREAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        IngresoContratoView ingresoContratoView = IngresoContratoView.ObtenerInstancia();
                        ingresoContratoView.ShowDialog();
                    }
                }
                else if (contadorContratos > 0 && contadorContratos <= 1)
                {
                    detalleClienteVista = new DetalleClienteView();
                    detalleClienteVista.Show();
                }
                else
                {
                    SeleccionarContratoView seleccionarContratoView  = SeleccionarContratoView.ObtenerInstancia();
                    seleccionarContratoView.ShowDialog();
                    
                } 
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

        public static string ObtenerNombreCliente()
        {
            return nombreCliente;
        }
    }
}
