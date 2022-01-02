using Alumvix.Model.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Alumvix.Model.Dao
{
    internal class AbonoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<AbonoDto> ObtenerAbonos(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "MostrarDetalleAbonos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idContrato", idContrato);
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<AbonoDto> listadoAbonos = new List<AbonoDto>();
            while (lectorFilas.Read())
            {
                listadoAbonos.Add(new AbonoDto()
                {
                    IdAbono = lectorFilas.GetInt32(0),
                    ValorAbono = lectorFilas.GetInt32(1),
                    FechaAbono = lectorFilas.GetDateTime(2),
                    FormaDeAbono = lectorFilas.GetString(3)
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoAbonos;
        }

        public bool IngresarAbono(int valorAbono, string fechaAbono, int idContrato, int formaDeAbono) 
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into ABONO values("+valorAbono+",'"+fechaAbono+"',"+idContrato+","+formaDeAbono+")";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;   
        }

        public List<string> ConsultarFormasAbono() 
        {
            command.Connection = connection;
            command.CommandText = "select * from FORMA_ABONO";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> formasAbono = new List<string>();
            formasAbono.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                formasAbono.Add(lectorFilas.GetString(1));                   
            }
            return formasAbono;
        }

        public bool EliminarAbono(int idAbono) 
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from ABONO where ID_ABONO = "+idAbono;
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
