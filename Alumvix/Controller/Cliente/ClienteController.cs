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
using Alumvix.Controller.Login;
using System.Runtime.InteropServices;

namespace Alumvix.Controller
{
    internal class ClienteController
    {
        static List<ClienteDto> registroCliente = new List<ClienteDto>();
        static ClienteView clienteVista;
        static LoginView loginView = LoginController.ObtenerInstancia(); 
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
            clienteVista.Activated += new EventHandler(SeleccionarFiltroCualquiera);
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
            clienteVista.btnModificarIVA.Click += new EventHandler(AbrirEditarValorIVAView);
            clienteVista.btnMinimizarClienteView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            clienteVista.btnMinimizarClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            clienteVista.btnCerrarClienteView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            clienteVista.btnCerrarClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            clienteVista.btnCerrarClienteView.Click += new EventHandler(CerrarFormularioClienteView);
            clienteVista.btnMinimizarClienteView.Click += new EventHandler(MinimizarFormularioClienteView);
            clienteVista.rbContratoAbierto.CheckedChanged += new EventHandler(FiltarCLientesContratosAbiertos);
            clienteVista.rbContratoCerrado.CheckedChanged += new EventHandler(FiltarCLientesContratoCerrado);
            clienteVista.rbCualquierContrato.CheckedChanged += new EventHandler(MostrarAllClientes);
            clienteVista.pnlSuperiorClienteView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void AbrirEditarValorIVAView(object sender, EventArgs e)
        {
            EditarValorIVAView editarValorIVAView = EditarValorIVAView.ObtenerInstancia();
            editarValorIVAView.Show();
            clienteVista.Hide();
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(clienteVista.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void SeleccionarFiltroCualquiera(object sender, EventArgs e)
        {
            clienteVista.rbCualquierContrato.Checked = true;
        }

        private void MostrarAllClientes(object sender, EventArgs e)
        {
            clienteVista.txtFiltrarCliente.Text = "";
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerAllClientes();
            clienteVista.dataGridClientes.ClearSelection();
            registroCliente.Clear();

        }

        private void FiltarCLientesContratoCerrado(object sender, EventArgs e)
        {
            clienteVista.txtFiltrarCliente.Text = "";
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerClientesContratoCerrado();
            clienteVista.dataGridClientes.ClearSelection();
            registroCliente.Clear();
        }

        private void FiltarCLientesContratosAbiertos(object sender, EventArgs e)
        {
            clienteVista.txtFiltrarCliente.Text = "";
            ClienteDao clienteDao = new ClienteDao();
            clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerClientesContratoAbierto();
            clienteVista.dataGridClientes.ClearSelection();
            registroCliente.Clear();
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            clienteVista.btnMinimizarClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            clienteVista.btnMinimizarClienteView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            clienteVista.btnCerrarClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            clienteVista.btnCerrarClienteView.BackColor = Color.Transparent;
        }

        private void MinimizarFormularioClienteView(object sender, EventArgs e)
        {
            clienteVista.WindowState = FormWindowState.Minimized;
        }

        private void CerrarFormularioClienteView(object sender, EventArgs e)
        {
            clienteVista.Hide();
            loginView.Show();
        }

        private void AbrirLogin(object sender, FormClosedEventArgs e)
        {
            clienteVista.Hide();
            loginView.Show();
            
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
            ProveedoresView proveedoresView = ProveedoresView.ObtenerInstancia();
            clienteVista.Hide();
            proveedoresView.Show();
        }

        private void AbrirIngresoClienteView(object sender, EventArgs e)
        {
            IngresoClienteView ingresoClienteView = IngresoClienteView.ObtenerInstancia();          
            ingresoClienteView.Show();
            clienteVista.Hide();
        }

        private void AbrirGastoInternoView(object sender, EventArgs e)
        {
            GastosInternosView gastoInternoView = GastosInternosView.ObtenerInstancia();
            clienteVista.Hide();
            gastoInternoView.Show();
        }

        private void AbrirReporteView(object sender, EventArgs e)
        {
            AdministradorReportesView reporteView = AdministradorReportesView.ObtenerInstancia();
            clienteVista.Hide();
            reporteView.Show();
        }

        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
        }

        private void AbrirEditarClienteView(object sender, EventArgs e)
        {
            if (registroCliente.Count > 0)
            {
                EditarClienteView editarClienteView = EditarClienteView.ObtenerInstancia();
                clienteVista.Hide();
                editarClienteView.Show();
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
            if (clienteVista.rbContratoAbierto.Checked)
            {
                ClienteDao clienteDao = new ClienteDao();
                clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerClientesContratoAbiertoYFiltro(clienteVista.txtFiltrarCliente.Text);
                clienteVista.dataGridClientes.ClearSelection();
                registroCliente.Clear();
            }
            else if (clienteVista.rbContratoCerrado.Checked)
            {
                ClienteDao clienteDao = new ClienteDao();
                clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerClientesContratoCerradoYFiltro(clienteVista.txtFiltrarCliente.Text);
                clienteVista.dataGridClientes.ClearSelection();
                registroCliente.Clear();
            }
            else
            {
                ClienteDao clienteDao = new ClienteDao();
                clienteVista.dataGridClientes.DataSource = clienteDao.ObtenerListadoClientes(clienteVista.txtFiltrarCliente.Text);
                clienteVista.dataGridClientes.ClearSelection();
                registroCliente.Clear();
            }
        }

        public static List<ClienteDto> CargarRegistroCliente()
        {
            return registroCliente;
        }

        
        //metodo para agregar las celdas de una fila seleccionada a la lista "registroCliente"
        private void ObtenerRegistroCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
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
                    //detalleClienteVista = new DetalleClienteView();
                    //detalleClienteVista.ShowDialog();
                    detalleClienteVista = DetalleClienteView.ObtenerInstancia();
                    detalleClienteVista.Show();
                    clienteVista.Hide();
                }
                else
                {
                    //seleccionarContratoView = new SeleccionarContratoView();
                    //seleccionarContratoView.ShowDialog();
                    seleccionarContratoView = SeleccionarContratoView.ObtenerInstancia();
                    seleccionarContratoView.Show();
                    clienteVista.Hide();
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

        public static ClienteView ObtenerInstanciaClienteView()
        {
            return clienteVista;
        }
    }
}
