using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class EditarGastoController
    {
        EditarGastoView editarGastoView;
        DetalleGastoView detalleGastoView = DetalleGastoController.ObtenerInstanciaDetalleGasto();

        public EditarGastoController(EditarGastoView editarGastoVista) 
        {
            editarGastoView = editarGastoVista;
            editarGastoView.Activated += new EventHandler(CargarDatosGasto);
            editarGastoView.cbEditarTipoGasto.SelectedIndexChanged += new EventHandler(HabilitarProveedores);
            editarGastoView.btnActualizarGasto.Click += new EventHandler(ActualizarGastoEnBD);
        }

        private void CargarDatosGasto(object sender, EventArgs e)
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            GastoDao gastoDao = new GastoDao();
            editarGastoView.txtEditarNumeroFactura.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[1].Text;
            editarGastoView.txtActualizarValorGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[2].Text;
            editarGastoView.dtpActualizarFechaGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[3].Text;
            editarGastoView.txtActualizarDescripcionGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[4].Text;
            editarGastoView.cbEditarProveedor.DataSource = proveedorDao.ConsultarProveedoresParaCB();
            editarGastoView.cbEditarProveedor.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[5].Text;
            editarGastoView.cbEditarTipoGasto.DataSource = gastoDao.ObtenerTiposDeGastoMaterial();
            editarGastoView.cbEditarTipoGasto.Text = detalleGastoView.lstvDetalleGastos.SelectedItems[0].SubItems[6].Text;
        }

        private void ActualizarGastoEnBD(object sender, EventArgs e)
        {
            GastoDao GastoActualizado = new GastoDao();
            if (ValidacionesDeControles.ValidarBotonIngresoGasto(editarGastoView.txtActualizarValorGasto.Text, editarGastoView.txtEditarNumeroFactura.Text, editarGastoView.cbEditarTipoGasto.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                //TODO : CORREGIR BUG
                int? idProveedor = null;
                if (editarGastoView.cbEditarProveedor.Enabled == true)
                {
                    idProveedor = editarGastoView.cbEditarProveedor.SelectedIndex;
                } 
                GastoDao gastoDao = new GastoDao();
                int idTipoGasto = gastoDao.ObtenerTipoGastoPorNombre(editarGastoView.cbEditarTipoGasto.GetItemText(editarGastoView.cbEditarTipoGasto.SelectedItem));
                bool respuestaActualizacionGasto = GastoActualizado.ActualizarGasto(editarGastoView.txtEditarNumeroFactura.Text, Convert.ToInt32(editarGastoView.txtActualizarValorGasto.Text), editarGastoView.dtpActualizarFechaGasto.Text, editarGastoView.txtActualizarDescripcionGasto.Text, idProveedor, idTipoGasto, DetalleGastoController.idGasto);
                if (respuestaActualizacionGasto)
                {
                    //editarGastoView.txtActualizarValorGasto.Clear();
                    editarGastoView.Close();
                    MessageBox.Show("El gasto ha sido actualizado con exito");
                }
                else MessageBox.Show("Error al actualizar el gasto");
            }
        }

        private void HabilitarProveedores(object sender, EventArgs e)
        {
            if (editarGastoView.cbEditarTipoGasto.SelectedIndex == 2)
            {
                editarGastoView.cbEditarProveedor.Enabled = true;
                editarGastoView.cbEditarProveedor.SelectedIndex = 0;
            }
            else
            {
                editarGastoView.cbEditarProveedor.Enabled = false;
                editarGastoView.cbEditarProveedor.SelectedIndex = -1;
            }
        }

    }
}
