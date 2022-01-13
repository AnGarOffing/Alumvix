using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class IngresoGastoController
    {
        IngresoGastoView ingresoGastoView;
        int idContrato;

        public IngresoGastoController(IngresoGastoView ingresoGastoVista) 
        {
            idContrato = DetalleClienteController.ObtenerIdContrato();
            ingresoGastoView = ingresoGastoVista;
            ingresoGastoView.Load += new EventHandler(CargarTiposDeGastoMaterial);
            ingresoGastoView.Load += new EventHandler(CargarProveedores);
            ingresoGastoView.cbIngresarTipoGasto.SelectedIndexChanged += new EventHandler(HabilitarProveedores);
            ingresoGastoView.btnGuardarNuevoGasto.Click += new EventHandler(IngresarGasto);
        }   

        private void IngresarGasto(object sender, EventArgs e)
        {
            GastoDao nuevoGasto = new GastoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGasto(ingresoGastoView.txtIngresarValorGasto.Text, ingresoGastoView.txtNumeroFactura.Text, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool respuestaIngresoAbono = nuevoGasto.IngresarGasto(ingresoGastoView.txtNumeroFactura.Text, Convert.ToInt32(ingresoGastoView.txtIngresarValorGasto.Text), ingresoGastoView.dtpFechaIngresoGasto.Text, ingresoGastoView.txtDescripcionGasto.Text, ingresoGastoView.cbIngresarProveedor.SelectedIndex, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex, idContrato);
                if (respuestaIngresoAbono)
                {
                    ingresoGastoView.txtIngresarValorGasto.Clear();
                    ingresoGastoView.txtDescripcionGasto.Clear();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                } 
                else MessageBox.Show("Error al guardar el gasto");
            }
        }

        private void CargarTiposDeGastoMaterial(object sender, EventArgs e)
        {
            GastoDao tipoGasto = new GastoDao();
            ingresoGastoView.cbIngresarTipoGasto.DataSource = tipoGasto.ObtenerTiposDeGastoMaterial();
            ingresoGastoView.cbIngresarTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarProveedores(object sender, EventArgs e)
        {
            ProveedorDao proveedor = new ProveedorDao();
            ingresoGastoView.cbIngresarProveedor.DataSource = proveedor.ConsultarProveedoresParaCB();
            ingresoGastoView.cbIngresarProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void HabilitarProveedores(object sender, EventArgs e)
        {
            if (ingresoGastoView.cbIngresarTipoGasto.SelectedIndex == 2)
            {
                ingresoGastoView.cbIngresarProveedor.Enabled = true;
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = 0;
            }
            else 
            {
                ingresoGastoView.cbIngresarProveedor.Enabled = false;
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = -1;
            } 
        }
    }
}
