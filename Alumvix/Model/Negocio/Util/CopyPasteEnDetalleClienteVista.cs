using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumvix.View.Cliente;

namespace Alumvix.Model.Logica.Util
{
    internal class CopyPasteEnDetalleClienteVista
    {
        DetalleClienteView detalleClienteVista;
        public CopyPasteEnDetalleClienteVista(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(TransformarTextBoxes);
        }

        private void TransformarTextBoxes(object sender, EventArgs e) 
        {
            
            detalleClienteVista.txtIdentificacion.ReadOnly = true;
            detalleClienteVista.txtIdentificacion.BorderStyle = 0;
            detalleClienteVista.txtIdentificacion.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtIdentificacion.TabStop = false;
           
            detalleClienteVista.txtNombre.ReadOnly = true;
            detalleClienteVista.txtNombre.BorderStyle = 0;
            detalleClienteVista.txtNombre.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtNombre.TabStop = false;
            
            detalleClienteVista.txtTelefono.ReadOnly = true;
            detalleClienteVista.txtTelefono.BorderStyle = 0;
            detalleClienteVista.txtTelefono.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtTelefono.TabStop = false;

            
            detalleClienteVista.txtDireccion.ReadOnly = true;
            detalleClienteVista.txtDireccion.BorderStyle = 0;
            detalleClienteVista.txtDireccion.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtDireccion.TabStop = false;
            
            detalleClienteVista.txtCorreo.ReadOnly = true;
            detalleClienteVista.txtCorreo.BorderStyle = 0;
            detalleClienteVista.txtCorreo.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtCorreo.TabStop = false;
           
            detalleClienteVista.txtCelular.ReadOnly = true;
            detalleClienteVista.txtCelular.BorderStyle = 0;
            detalleClienteVista.txtCelular.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtCelular.TabStop = false;
           
            detalleClienteVista.txtNumeroContrato.ReadOnly = true;
            detalleClienteVista.txtNumeroContrato.BorderStyle = 0;
            detalleClienteVista.txtNumeroContrato.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtNumeroContrato.TabStop = false;
           
            detalleClienteVista.txtValorContrato.ReadOnly = true;
            detalleClienteVista.txtValorContrato.BorderStyle = 0;
            detalleClienteVista.txtValorContrato.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtValorContrato.TabStop = false;
            
            detalleClienteVista.txtFechaInicioContrato.ReadOnly = true;
            detalleClienteVista.txtFechaInicioContrato.BorderStyle = 0;
            detalleClienteVista.txtFechaInicioContrato.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtFechaInicioContrato.TabStop = false;
            
            detalleClienteVista.txtFechaFinContrato.ReadOnly = true;
            detalleClienteVista.txtFechaFinContrato.BorderStyle = 0;
            detalleClienteVista.txtFechaFinContrato.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtFechaFinContrato.TabStop = false;
            
            detalleClienteVista.txtEstadoContrato.ReadOnly = true;
            detalleClienteVista.txtEstadoContrato.BorderStyle = 0;
            detalleClienteVista.txtEstadoContrato.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtEstadoContrato.TabStop = false;
           
            detalleClienteVista.txtEstadoTrabajo.ReadOnly = true;
            detalleClienteVista.txtEstadoTrabajo.BorderStyle = 0;
            detalleClienteVista.txtEstadoTrabajo.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtEstadoTrabajo.TabStop = false;

            detalleClienteVista.txtTotalGastos.ReadOnly = true;
            detalleClienteVista.txtTotalGastos.BorderStyle = 0;
            detalleClienteVista.txtTotalGastos.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtTotalGastos.TabStop = false;

            detalleClienteVista.txtTotalAbonos.ReadOnly = true;
            detalleClienteVista.txtTotalAbonos.BorderStyle = 0;
            detalleClienteVista.txtTotalAbonos.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtTotalAbonos.TabStop = false;

            detalleClienteVista.txtRestaPorPagar.ReadOnly = true;
            detalleClienteVista.txtRestaPorPagar.BorderStyle = 0;
            detalleClienteVista.txtRestaPorPagar.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtRestaPorPagar.TabStop = false;

            detalleClienteVista.txtUtilidad.ReadOnly = true;
            detalleClienteVista.txtUtilidad.BorderStyle = 0;
            detalleClienteVista.txtUtilidad.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.txtUtilidad.TabStop = false;
        }
    }
}
