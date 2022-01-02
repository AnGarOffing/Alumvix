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

        public bool IngresarGasto(int valorGasto, string fechaGasto, string descripcionGasto, int idContrato)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into GASTO values(" + valorGasto + ",'" + fechaGasto + "','" + descripcionGasto + "'," + idContrato + ")";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool EliminarGasto(int idGasto)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from GASTO where ID_GASTO = " + idGasto;
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
