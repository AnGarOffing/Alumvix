using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using Alumvix.View.Reporte;
using Alumvix.View.Gasto;
using Alumvix.View.Proveedor;
using System.Drawing;
using Alumvix.View.Login;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        static List<ClienteDto> registroCliente = new List<ClienteDto>();
        ClienteView clienteVista;
        DetalleClienteView detalleClienteVista;
        SeleccionarContratoView seleccionarContratoView;
        static int idCliente;
        static string nombreCliente;
        Logica logica;

        public bool Validaciones { get; private set; }

        public ClienteController(ClienteView view)
        {
            logica = new Logica();
            clienteVista = view;
            clienteVista.Activated += new EventHandler(ObtenerListadoClientes);
            clienteVista.Activated += new EventHandler(PersonalizarFormulario);
            clienteVista.txtFiltrarCliente.TextChanged += new EventHandler(ObtenerListadoClientes);
            clienteVista.dataGridClientes.CellClick += new DataGridViewCellEventHandler(ObtenerRegistroCliente);
            clienteVista.btnDetalleCliente.Click += new EventHandler(AbrirDetalleClienteView);
            clienteVista.btnEliminarCliente.Click += new EventHandler(EliminarCliente);
            clienteVista.btnReporte.Click += new EventHandler(AbrirReporteView);
            clienteVista.btnActualizarCliente.Click += new EventHandler(AbrirEditarClienteView);
            clienteVista.btnGastosInternos.Click += new EventHandler(AbrirGastoInternoView);
            clienteVista.txtFiltrarCliente.KeyPress += new KeyPressEventHandler(ValidarEntrada);
            clienteVista.btnIngresarCliente.Click += new EventHandler(AbrirIngresoClienteView);
            clienteVista.btnProveedores.Click += new EventHandler(AbrirProveedoresView);
            clienteVista.FormClosed += new FormClosedEventHandler(AbrirLogin);
        }

        private void AbrirLogin(object sender, FormClosedEventArgs e)
        {
            LoginView loginView = LoginView.ObtenerInstancia();
            clienteVista.Dispose();
            loginView.ShowDialog();
            
        }

        private void PersonalizarFormulario(object sender, EventArgs e)
        {
            clienteVista.dataGridClientes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            clienteVista.dataGridClientes.AutoResizeColumns();
            clienteVista.dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clienteVista.dataGridClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            clienteVista.dataGridClientes.Columns[0].HeaderText = "Id";
            clienteVista.dataGridClientes.Columns[1].HeaderText = "Identificación";
            clienteVista.dataGridClientes.Columns[2].HeaderText = "Nombre";
            clienteVista.dataGridClientes.Columns[3].HeaderText = "Email";
            clienteVista.dataGridClientes.Columns[4].HeaderText = "Celular";
            clienteVista.dataGridClientes.Columns[5].HeaderText = "Telefono";
            clienteVista.dataGridClientes.Columns[6].HeaderText = "Dirección";
        }

        private void AbrirProveedoresView(object sender, EventArgs e)
        {
            ProveedorView proveedoresView = ProveedorView.ObtenerInstancia();
            proveedoresView.ShowDialog();
        }

        private void AbrirIngresoClienteView(object sender, EventArgs e)
        {
            IngresoClienteView ingresoClienteView = IngresoClienteView.ObtenerInstancia();
            ingresoClienteView.ShowDialog();
        }

        private void AbrirGastoInternoView(object sender, EventArgs e)
        {
            GastoInternoView gastoInternoView = GastoInternoView.ObtenerInstancia();
            gastoInternoView.ShowDialog();
        }

        private void AbrirReporteView(object sender, EventArgs e)
        {
            AdministradorReportesView reporteView = AdministradorReportesView.ObtenerInstancia();
            reporteView.ShowDialog();
        }

        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros y letras");
        }

        private void AbrirEditarClienteView(object sender, EventArgs e)
        {
            if (registroCliente.Count > 0)
            {
                EditarClienteView editarClienteView = EditarClienteView.ObtenerInstancia();
                editarClienteView.ShowDialog();
            }
            else MessageBox.Show("No ha seleccionado un cliente");
        }

        private void EliminarCliente(object sender, EventArgs e)
        {
            if (registroCliente.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el cliente?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new ClienteDao().EliminarCliente(idCliente);
                    if (respuesta)
                    {
                        MessageBox.Show("El cliente ha sido eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el cliente");
                    }
                }
            }else MessageBox.Show("No ha seleccionado un cliente");
        }

        private void ObtenerListadoClientes(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(clienteVista.txtFiltrarCliente.Text);
            clienteVista.dataGridClientes.ClearSelection();
            registroCliente.Clear();
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
                    detalleClienteVista.ShowDialog();

                    
                }
                else
                {
                    seleccionarContratoView = new SeleccionarContratoView();
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
