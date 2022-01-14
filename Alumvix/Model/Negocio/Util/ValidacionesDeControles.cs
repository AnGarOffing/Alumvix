using Alumvix.Controller.Cliente;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Model.Negocio.Util
{
    internal class ValidacionesDeControles
    {
        static bool respuesta;

        //metodo que valida las entradas de un ingreso o un abono
        public static bool ValidarBotonIngresoAbono(string valorAbono, int formaDeAbono) 
        {
            respuesta = false;  
            if (valorAbono != "")
            {
                if (formaDeAbono != 0)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public static bool ValidarBotonIngresoGasto(string valorGasto, string numeroFactura, int tipoGasto, int proveedor)
        {
            respuesta = false;
            if (valorGasto != "" && numeroFactura != "" && tipoGasto != 0 && proveedor != 0) 
            {
                if (proveedor == 1) MessageBox.Show("No ha elegido un proveedor valido");
                else respuesta = true;
            }
            return respuesta;
        }
        public static bool ValidarBotonIngresoGastoSinFactura(string valorGasto, int tipoGasto)
        {
            respuesta = false;
            if (valorGasto != "" && tipoGasto != 0) respuesta = true;
            return respuesta;
        }


        public static string ValidarBotonIngresoProducto(int indiceProducto, string nombreProducto)
        {
            string mensaje = null;
            if (indiceProducto == 0)
            {
                mensaje = "Debe seleccionar un producto";
            }
            else
            {
                bool duplicado = false;
                List<ProductoDto> listadoProductos = new List<ProductoDto>();
                listadoProductos = new ProductoDao().ObtenerListadoProductos(DetalleClienteController.ObtenerIdContrato());
                foreach (ProductoDto item in listadoProductos)
                {
                    if (item.NombreProducto.Equals(nombreProducto))
                    {
                        duplicado = true;
                    }
                    if (duplicado) mensaje = "El producto ya esta asociado al contrato";
                }
            }
            return mensaje;   
        }
    }
}
