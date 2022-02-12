using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View.Cliente;
using Alumvix.View.Abono;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio;
using Alumvix.View.Gasto;
using Alumvix.View.Producto;
using Alumvix.View.Contrato;
using Alumvix.Controller.Contrato;
using Alumvix.View.Login;
using Alumvix.Controller.Login;
using Alumvix.View;
using System.Drawing;

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        static DetalleClienteView detalleClienteVista;
        List<ClienteDto> registroCliente;
        static ContratoDto contratoDto;
        static List<GastoDto> gastos;
        static List<AbonoDto> abonos;
        static List<ProductoDto> productos;
        Logica logica;
        string nombreProducto;
        //LoginView loginView = LoginController.ObtenerInstancia();
        //ClienteView clienteView = ClienteController.ObtenerInstanciaClienteView();
        //SeleccionarContratoView seleccionarContratoView = SeleccionarContratoController.ObtenerInstanciaSeleccionarContratoView();
        SeleccionarContratoView seleccionarContratoView;
        ClienteView clienteView;
        LoginView loginView;

        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            loginView = LoginController.ObtenerInstancia();
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            seleccionarContratoView = SeleccionarContratoController.ObtenerInstanciaSeleccionarContratoView();
            contratoDto = SeleccionarContrato();
            abonos = new AbonoDao().ObtenerAbonos(contratoDto.IdContrato);
            gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);
            productos = new ProductoDao().ObtenerListadoProductos(contratoDto.IdContrato);
            registroCliente = ClienteController.CargarRegistroCliente();
            logica = new Logica();
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Activated += new EventHandler(MostrarClienteSeleccionado);
            detalleClienteVista.Activated += new EventHandler(MostrarContrato);
            detalleClienteVista.Activated += new EventHandler(MostrarGastos);
            detalleClienteVista.Activated += new EventHandler(MostrarAbonos);
            detalleClienteVista.Activated += new EventHandler(MostrarCuentas);
            detalleClienteVista.Activated += new EventHandler(MostrarProductos);           
            detalleClienteVista.btnDetallesAbonos.Click += new EventHandler(AbrirDetalleAbonos);
            detalleClienteVista.btnDetallesGastos.Click += new EventHandler(AbrirDetalleGastos);
            detalleClienteVista.btnAbrirIngresoProducto.Click += new EventHandler(AbrirIngresoProductoView);
            detalleClienteVista.btnEliminarProducto.Click += new EventHandler(EliminarProducto);  
            detalleClienteVista.lstvProductos.SelectedIndexChanged += new EventHandler(ObtenerNombreProducto);
            detalleClienteVista.btnIngresarContrato.Click += new EventHandler(AbrirIngresoContratoView);
            detalleClienteVista.FormClosed += new FormClosedEventHandler(CerrarFormularioContratos);
            detalleClienteVista.btnMinimizarDetalleClienteView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            detalleClienteVista.btnMinimizarDetalleClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            detalleClienteVista.btnMinimizarDetalleClienteView.Click += new EventHandler(MinimizarDetalleClienteView);
            detalleClienteVista.btnCerrarDetalleClienteView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            detalleClienteVista.btnCerrarDetalleClienteView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            detalleClienteVista.btnCerrarSesion.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            detalleClienteVista.btnCerrarSesion.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
            detalleClienteVista.btnEliminarContrato.Click += new EventHandler(EliminarContrato);
            detalleClienteVista.btnEditarContrato.Click += new EventHandler(AbrirEditarContratoView);
            detalleClienteVista.btnCerrarSesion.Click += new EventHandler(CerrarSesion);
            detalleClienteVista.btnCerrarDetalleClienteView.Click += new EventHandler(CerrarDetalleClienteView);
        }

        private void MinimizarDetalleClienteView(object sender, EventArgs e)
        {
            detalleClienteVista.WindowState = FormWindowState.Minimized;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            detalleClienteVista.btnCerrarSesion.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            detalleClienteVista.btnCerrarSesion.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            detalleClienteVista.btnMinimizarDetalleClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            detalleClienteVista.btnMinimizarDetalleClienteView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            detalleClienteVista.btnCerrarDetalleClienteView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            detalleClienteVista.btnCerrarDetalleClienteView.BackColor = Color.Transparent;
        }

        private void CerrarDetalleClienteView(object sender, EventArgs e)
        {
            detalleClienteVista.Hide();
            clienteView.Show();
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            detalleClienteVista.Hide();
            clienteView.Hide();
            loginView.Show();
        }

        private void AbrirEditarContratoView(object sender, EventArgs e)
        {
            //EditarContratoView editarAbonoView = new EditarContratoView();
            //editarAbonoView.ShowDialog();   
            EditarContratoView editarAbonoView = new EditarContratoView();
            detalleClienteVista.Hide();
            editarAbonoView.Show();
        }

        private void EliminarContrato(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea borrar el contrato?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool respuesta = new ContratoDao().EliminarContrato(contratoDto.IdContrato);
                if (respuesta)
                {
                    //detalleClienteVista.Dispose();
                    detalleClienteVista.Hide();
                    MessageBox.Show("El contrato ha sido eliminado con exito");
                    
                    clienteView = ClienteView.ObtenerInstancia();
                    clienteView.Show();


                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el contrato");
                }
            }
        }

        private void CerrarFormularioContratos(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(SeleccionarContratoView))
                {
                    frm.Close();
                }
            }       
        }

        private ContratoDto SeleccionarContrato()
        {
            ContratoDto contratoARetornar = null;
            ContratoDao contratoDao = new ContratoDao();
            List<ContratoDto> listadoContratos= contratoDao.ObtenerContratos(ClienteController.ObtenerIdCliente());
            int sumaContratos = listadoContratos.Count;
            if (sumaContratos == 1)
            {
                contratoARetornar = contratoDao.ObtenerContrato(ClienteController.ObtenerIdCliente());
            }
            else if (sumaContratos > 1)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(SeleccionarContratoView))
                    {
                        seleccionarContratoView = (SeleccionarContratoView)frm;
                        contratoARetornar = contratoDao.ObtenerContratoPorIdContrato(Convert.ToInt32(seleccionarContratoView.lstvListadoContratos.SelectedItems[0].SubItems[0].Text));
                        break;
                    }else contratoARetornar = contratoDao.ObtenerContrato(ClienteController.ObtenerIdCliente());
                }                
            }
            return contratoARetornar;
        }

        //metodo para mostrar info de un cliente en la vista "DetalleClienteView"
        private void MostrarClienteSeleccionado(object sender, EventArgs e)
        {
            detalleClienteVista.txtIdentificacion.Text = registroCliente[0].IdentificacionCliente.ToString();
            detalleClienteVista.txtNombre.Text = registroCliente[0].NombreCliente.ToString();
            detalleClienteVista.txtTelefono.Text = registroCliente[0].TelefonoFijoCliente.ToString();
            detalleClienteVista.txtDireccion.Text = registroCliente[0].DireccionCliente.ToString();
            detalleClienteVista.txtCorreo.Text = registroCliente[0].CorreoElectronicoCliente.ToString();
            detalleClienteVista.txtCelular.Text = registroCliente[0].CelularCliente.ToString();
        }

        private void ValidarEstadoContrato()
        {
            int estadoTrabajo = 0;
            ContratoDao contratoDao = new ContratoDao();
            int sumaAbonos = 0;
            foreach (AbonoDto abono in abonos)
            {
                sumaAbonos += abono.ValorAbono;
            }
            if (contratoDto != null)
            {
                estadoTrabajo = contratoDao.ConsultarEstadoTrabajo(Convert.ToInt32(contratoDto.IdContrato));
                if (sumaAbonos >= DetalleClienteController.contratoDto.ValorContrato)
                {
                    if (estadoTrabajo == 2)
                    {
                        contratoDao.ActualizarEstadoContrato(2, DetalleClienteController.contratoDto.IdContrato);
                        contratoDto.EstadoContrato = contratoDao.ConsultarEstadoContrato(contratoDto.IdContrato);
                    }
                }
            }
        }

        private void MostrarContrato(object sender, EventArgs e)
        {
            contratoDto = SeleccionarContrato();
            ValidarEstadoContrato();               
            detalleClienteVista.txtNumeroFactura.Text = contratoDto.IdContrato.ToString();
            detalleClienteVista.txtTipoFactura.Text = contratoDto.TipoFactura.ToString();
            detalleClienteVista.txtValorContrato.Text = CambioDeFormato.DarFormatoANumero(contratoDto.ValorContrato);
            detalleClienteVista.txtFechaInicioContrato.Text = contratoDto.FechaInicioContrato.ToString();
            detalleClienteVista.txtFechaFinContrato.Text = contratoDto.FechaTerminacionContrato.ToString();
            detalleClienteVista.txtEstadoContrato.Text = contratoDto.EstadoContrato.ToString();
            detalleClienteVista.txtEstadoTrabajo.Text = contratoDto.EstadoTrabajo.ToString();
        }

        private void MostrarGastos(object sender, EventArgs e) 
        {
            int cont = 1;
            detalleClienteVista.lstvGastos.Items.Clear();
            gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);
            foreach  (GastoDto gasto in gastos)
            {              
                string[] row = { cont.ToString(), CambioDeFormato.DarFormatoANumero(gasto.ValorGasto).ToString()};
                ListViewItem itemGasto = new ListViewItem(row);
                detalleClienteVista.lstvGastos.Items.Add(itemGasto);
                cont++;
            }
        }

        private void MostrarAbonos(object sender, EventArgs e)
        {
            int cont = 1;
            detalleClienteVista.lstvAbonos.Items.Clear();
            abonos = new AbonoDao().ObtenerAbonos(contratoDto.IdContrato);
            foreach (AbonoDto abono in abonos)
            {
                string[] row = { cont.ToString(), CambioDeFormato.DarFormatoANumero(abono.ValorAbono).ToString()};
                ListViewItem itemAbono = new ListViewItem(row);
                detalleClienteVista.lstvAbonos.Items.Add(itemAbono);
                cont++;
            }
        }

        private void MostrarCuentas(object sender, EventArgs e)
        {
            detalleClienteVista.txtTotalGastos.Text = CambioDeFormato.DarFormatoANumero(logica.SumarGastos(gastos)).ToString();
            detalleClienteVista.txtTotalAbonos.Text = CambioDeFormato.DarFormatoANumero(logica.SumarAbonos(abonos)).ToString();
            detalleClienteVista.txtRestaPorPagar.Text = CambioDeFormato.DarFormatoANumero(logica.ObtenerRestantePorPagar(logica.SumarAbonos(abonos), contratoDto.ValorContrato)).ToString();
            detalleClienteVista.txtUtilidad.Text = CambioDeFormato.DarFormatoANumero(logica.ObtenerUtilidad(logica.SumarAbonos(abonos), logica.SumarGastos(gastos))).ToString();
        }

        private void MostrarProductos(object sender, EventArgs e) 
        {
            detalleClienteVista.lstvProductos.Clear();
            foreach (ProductoDto producto in ObtenerProductos())
            {
                ListViewItem itemProducto = new ListViewItem(producto.NombreProducto);
                detalleClienteVista.lstvProductos.Items.Add(itemProducto);
            }          
        }

        private void AbrirDetalleAbonos(object sender, EventArgs e) 
        {
            DetalleAbonoView detalleAbono = DetalleAbonoView.ObtenerInstancia();
            detalleClienteVista.Hide();
            detalleAbono.ShowDialog();
        }

        public static int ObtenerIdContrato() 
        {
            return contratoDto.IdContrato;
        }

        public static List<AbonoDto> ObtenerDetalleAbonos()
        {
            abonos = new AbonoDao().ObtenerAbonos(contratoDto.IdContrato);
            return abonos;
        }

        private List<ProductoDto> ObtenerProductos()
        {
            productos = new ProductoDao().ObtenerListadoProductos(contratoDto.IdContrato);
            return productos;
        }

        public static List<GastoDto> ObtenerDetalleGastos()
        {
            gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);
            return gastos;
        }

        private void AbrirDetalleGastos(object sender, EventArgs e)
        {
            DetalleGastoView detalleGasto = DetalleGastoView.ObtenerInstancia();
            detalleClienteVista.Hide();
            detalleGasto.ShowDialog();
        }

        private void AbrirIngresoProductoView(object sender, EventArgs e)
        {
            IngresoProductoView ingresoProductoView = IngresoProductoView.ObtenerInstancia();
            ingresoProductoView.ShowDialog();   
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            if (detalleClienteVista.lstvProductos.SelectedItems.Count > 0 && detalleClienteVista.lstvProductos.Items.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el producto?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ProductoDao productoDao = new ProductoDao();
                    bool respuesta = productoDao.EliminarProducto(contratoDto.IdContrato, productoDao.ObtenerIdUnProducto(nombreProducto));
                    if (respuesta)
                    {
                        detalleClienteVista.lstvProductos.SelectedItems.Clear();
                        MessageBox.Show("El producto ha sido eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el producto");
                    }
                }
            }
            else MessageBox.Show("No ha seleccionado un producto");          
        }

        private void ObtenerNombreProducto(object sender, EventArgs e)
        {
            if (detalleClienteVista.lstvProductos.SelectedItems.Count > 0)
            {
                nombreProducto = detalleClienteVista.lstvProductos.SelectedItems[0].Text;
            }
            
        }

        private void AbrirIngresoContratoView(object sender, EventArgs e)
        {
            IngresoContratoView ingresoContratoView = IngresoContratoView.ObtenerInstancia();
            detalleClienteVista.Hide();
            ingresoContratoView.Show();
        }

        public static DetalleClienteView ObtenerInstanciaDetalleClienteView()
        {
            return detalleClienteVista;
        }


    }
}
