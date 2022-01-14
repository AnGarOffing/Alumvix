using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
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
            ingresoGastoView.Load += new EventHandler(LimpiarCampos);
            ingresoGastoView.Load += new EventHandler(CargarTiposDeGastoMaterial);
            ingresoGastoView.Load += new EventHandler(CargarProveedores);
            ingresoGastoView.cbIngresarTipoGasto.SelectedIndexChanged += new EventHandler(HabilitarControlesFactyProv);
            ingresoGastoView.btnGuardarNuevoGasto.Click += new EventHandler(IngresarGasto);
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            ingresoGastoView.txtIngresarValorGasto.Clear();
            ingresoGastoView.txtDescripcionGasto.Clear();
        }

        private void IngresarGasto(object sender, EventArgs e)
        {
            bool respuesta = false;
            GastoDao GastoActualizado = new GastoDao();
            if (ingresoGastoView.txtNumeroFactura.Enabled == false)
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGastoSinFactura(ingresoGastoView.txtIngresarValorGasto.Text, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex);
            }
            else
            {
                respuesta = ValidacionesDeControles.ValidarBotonIngresoGasto(ingresoGastoView.txtIngresarValorGasto.Text, ingresoGastoView.txtNumeroFactura.Text, ingresoGastoView.cbIngresarTipoGasto.SelectedIndex, ingresoGastoView.cbIngresarProveedor.SelectedIndex);
            }
            if (respuesta)
            {
                //TODO Buscar la forma de enviar idProveedor con valor null hacia la BD        
                GastoDao nuevoGasto = new GastoDao();
                string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(ingresoGastoView.txtIngresarValorGasto.Text);
                int idTipoGasto = nuevoGasto.ObtenerTipoGastoPorNombre(ingresoGastoView.cbIngresarTipoGasto.GetItemText(ingresoGastoView.cbIngresarTipoGasto.SelectedItem));
                bool respuestaIngresoGasto = GastoActualizado.IngresarGasto(ingresoGastoView.txtNumeroFactura.Text, Convert.ToInt32(valorSinFormato), ingresoGastoView.dtpFechaIngresoGasto.Text, ingresoGastoView.txtDescripcionGasto.Text, ingresoGastoView.cbIngresarProveedor.SelectedIndex, idTipoGasto, idContrato);
                if (respuestaIngresoGasto)
                {
                    //editarGastoView.txtActualizarValorGasto.Clear();
                    ingresoGastoView.Close();
                    MessageBox.Show("El gasto ha sido guardado con exito");
                }
                else MessageBox.Show("Error al guardar el gasto");
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos");
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

        private void HabilitarControlesFactyProv(object sender, EventArgs e)
        {
            if (ingresoGastoView.cbIngresarTipoGasto.SelectedIndex == 2)
            {
                ingresoGastoView.cbIngresarProveedor.Enabled = true;
                ingresoGastoView.cbIngresarProveedor = RefrescarComboBoxProveedores(ingresoGastoView.cbIngresarProveedor);
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = 0;
                ingresoGastoView.txtNumeroFactura.Enabled = true;
                ingresoGastoView.txtNumeroFactura.Text = "";
            }
            else 
            {
                ingresoGastoView.cbIngresarProveedor = RefrescarComboBoxProveedores(ingresoGastoView.cbIngresarProveedor);
                ingresoGastoView.cbIngresarProveedor.Enabled = false;
                ingresoGastoView.cbIngresarProveedor.SelectedIndex = 1;
                ingresoGastoView.txtNumeroFactura.Text = "No Aplica";
                ingresoGastoView.txtNumeroFactura.Enabled = false;
            } 
        }

        private ComboBox RefrescarComboBoxProveedores(ComboBox comboBoxProveedores) 
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            comboBoxProveedores.DataSource = proveedorDao.ConsultarProveedoresParaCB();
            return comboBoxProveedores;
        }
    }
}
