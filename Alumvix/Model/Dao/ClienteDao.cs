﻿using System.Collections.Generic;
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
    }
}