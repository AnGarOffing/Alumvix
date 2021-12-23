using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Alumvix.Model.Dto;


namespace Alumvix.Model.Dao
{
    internal class ClienteDao : DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<Cliente> ObtenerClientes()
        {
            command.Connection = connection;
            command.CommandText = "Select * from CLIENTE";
            command.CommandType = CommandType.Text;
            connection.Open();

            lectorFilas = command.ExecuteReader();
            List<Cliente> listaClientes = new List<Cliente>();
            while (lectorFilas.Read())
            {
                listaClientes.Add(new Cliente
                {
                    Id = lectorFilas.GetInt32(0),
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
    }
}
