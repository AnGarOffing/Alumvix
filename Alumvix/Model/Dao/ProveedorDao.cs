using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Model.Dao
{
    internal class ProveedorDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<string> ConsultarProveedoresParaCB()
        {
            command.Connection = connection;
            command.CommandText = "select * from PROVEEDOR";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> proveedores = new List<string>();
            proveedores.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                proveedores.Add(lectorFilas.GetString(1));
            }
            return proveedores;
        }

        public List<ProveedorDto> ObtenerProveedores()
        {
            command.Connection = connection;
            command.CommandText = "select * from PROVEEDOR where nombreProveedor <> 'No Aplica'";
            command.CommandType = CommandType.Text;
            List<ProveedorDto> listadoProveedores = new List<ProveedorDto>();
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();              
                while (lectorFilas.Read())
                {
                    listadoProveedores.Add(new ProveedorDto()
                    {
                        IdProveedor = lectorFilas.GetInt32(0),
                        NombreProveedor = lectorFilas.GetString(1),
                        CelularProveedor = lectorFilas.GetString(2),
                        TelefonoFijoProveedor = lectorFilas.GetString(3),
                        DireccionProveedor = lectorFilas.GetString(4),
                    });
                }
            }
            catch (SqlNullValueException ex)
            {
                MessageBox.Show("No se encontraron proveedores en la Base de datos");             
                listadoProveedores.Add(new ProveedorDto
                {
                    NombreProveedor = "",
                    CelularProveedor = "",
                    TelefonoFijoProveedor = "",
                    DireccionProveedor = ""
                });
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                listadoProveedores.Add(new ProveedorDto
                {
                    NombreProveedor = "",
                    CelularProveedor = "",
                    TelefonoFijoProveedor = "",
                    DireccionProveedor = ""
                });
            }
            return listadoProveedores;
        }

        public bool ActualizarProveedor(string nombreProveedor, string celularProveedor, string telefonoProveedor, string direccionProveedor, int idProveedor)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update PROVEEDOR set nombreProveedor = '" + nombreProveedor + "', celularProveedor = '" + celularProveedor + "'"
             + ", telefonoFijoProveedor = '" + telefonoProveedor + "', direccionProveedor = '" + direccionProveedor + "' where ID_PROVEEDOR = " + idProveedor;
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            connection.Close();
            return respuesta;
        }

        public bool EliminarProveedor(int idProveedor)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from PROVEEDOR where ID_PROVEEDOR = " + idProveedor;
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool GuardarProveedor(string nombreProveedor, string celularProveedor, string telefonoProveedor, string direccionProveedor)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into PROVEEDOR values('" + nombreProveedor + "', '" + celularProveedor + "', '" + telefonoProveedor + "', '" + direccionProveedor + "')";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
