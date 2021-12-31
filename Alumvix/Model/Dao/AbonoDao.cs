using Alumvix.Model.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public void IngresarAbono() 
        {

        }
    }
}
