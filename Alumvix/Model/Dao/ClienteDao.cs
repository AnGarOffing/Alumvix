using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Alumvix.Model.Dto;


namespace Alumvix.Model.Dao
{
    internal class ClienteDao : DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<ClienteDto> ObtenerListadoClientes(string condicion)
        {
            command.Connection = connection;
            command.CommandText = "MostrarClientes";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Condicion", condicion);
            connection.Open();

            lectorFilas = command.ExecuteReader();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            while (lectorFilas.Read())
            {
                listaClientes.Add(new ClienteDto
                {
                    IdCliente = lectorFilas.GetInt32(0),
                    IdentificacionCliente = lectorFilas.GetString(1),
                    NombreCliente = lectorFilas.GetString(2),
                    CorreoElectronicoCliente = lectorFilas.GetString(3),
                    CelularCliente = lectorFilas.GetString(4),
                    TelefonoFijoCliente = lectorFilas.GetString(5),
                    DireccionCliente = lectorFilas.GetString(6)
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listaClientes;
        }

        public bool EliminarCliente(int idCliente)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from CLIENTE where ID_CLIENTE = " + idCliente;
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool ActualizarCliente(int idCliente, string identificacionCliente, string nombreCliente, string email, string celularCliente, string telefonoFijo, string direccionCliente)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update CLIENTE set identificacionCliente = '" + identificacionCliente + "', nombreCliente = '"+ nombreCliente +"'"
             + ", correoElectronicoCliente = '" + email + "', celularCliente = '" + celularCliente
             + "', telefonoFijoCliente = '" + telefonoFijo + "', direccionCliente = '" + direccionCliente + "' where ID_CLIENTE = " + idCliente;
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

        public bool GuardarCliente(string identificacionCliente, string nombreCliente, string correoCliente, string celularCliente, string telefonoCliente, string direccionCliente)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into CLIENTE values('" + identificacionCliente + "',' "+ nombreCliente + "','" + correoCliente + "','" + celularCliente + "','" + telefonoCliente + "','" + direccionCliente + "')";
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
