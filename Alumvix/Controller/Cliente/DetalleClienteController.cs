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

namespace Alumvix.Controller.Cliente
{
    internal class DetalleClienteController
    {
        DetalleClienteView detalleClienteVista;
        List<ClienteDto> registroCliente;
        static ContratoDto contratoDto;
        static List<GastoDto> gastos;
        static List<AbonoDto> abonos;
        static List<ProductoDto> productos;
        Logica logica;
        string nombreProducto;


        public DetalleClienteController(DetalleClienteView detalleClienteView)
        {
            contratoDto = new ContratoDao().ObtenerContrato(ClienteController.ObtenerIdCliente());
            abonos = new AbonoDao().ObtenerAbonos(contratoDto.IdContrato);
            gastos = new GastoDao().ObtenerGastos(contratoDto.IdContrato);
            productos = new ProductoDao().ObtenerListadoProductos(contratoDto.IdContrato);
            registroCliente = ClienteController.CargarRegistroCliente();
            logica = new Logica();
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(MostrarClienteSeleccionado);
            detalleClienteVista.Load += new EventHandler(MostrarContrato);
            detalleClienteVista.Activated += new EventHandler(MostrarGastos);
            detalleClienteVista.Activated += new EventHandler(MostrarAbonos);
            detalleClienteVista.Activated += new EventHandler(MostrarCuentas);
            detalleClienteVista.Activated += new EventHandler(MostrarProductos);
            detalleClienteVista.btnDetallesAbonos.Click += new EventHandler(AbrirDetalleAbonos);
            detalleClienteVista.btnDetallesGastos.Click += new EventHandler(AbrirDetalleGastos);
            detalleClienteVista.btnAbrirIngresoProducto.Click += new EventHandler(AbrirIngresoProductoView);
            detalleClienteVista.btnEliminarProducto.Click += new EventHandler(EliminarProducto);
            detalleClienteVista.lstvProductos.SelectedIndexChanged += new EventHandler(ObtenerNombreProducto);
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

        private void MostrarContrato(object sender, EventArgs e)
        {
            detalleClienteVista.txtNumeroFactura.Text = contratoDto.NumeroFactura.ToString();
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
            detalleGasto.ShowDialog();
        }

        private void AbrirIngresoProductoView(object sender, EventArgs e)
        {
            IngresoProductoView ingresoProductoView = IngresoProductoView.ObtenerInstancia();
            ingresoProductoView.ShowDialog();   
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea borrar el abono?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void ObtenerNombreProducto(object sender, EventArgs e)
        {
            nombreProducto = detalleClienteVista.lstvProductos.SelectedItems[0].Text;
        }
    }
}
