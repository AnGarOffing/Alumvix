using Alumvix.Model.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alumvix.Model.Dao
{
    internal class GastoDao: DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<GastoDto> ObtenerGastos(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select * from GASTO where FK_ID_CONTRATO2 ="+idContrato+"";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos =new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    IdGasto = lectorFilas.GetInt32(0),
                    ValorGasto = lectorFilas.GetInt32(1),
                    FechaGasto = lectorFilas.GetDateTime(2),
                    DescripcionGasto = lectorFilas.GetString(3)
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }
    }
}
