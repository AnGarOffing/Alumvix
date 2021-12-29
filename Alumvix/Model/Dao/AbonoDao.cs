using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dao
{
    internal class AbonoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<AbonoDto> ObtenerAbonos(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select * from ABONO where FK_ID_CONTRATO =" + idContrato + "";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<AbonoDto> listadoAbonos = new List<AbonoDto>();
            while (lectorFilas.Read())
            {
                listadoAbonos.Add(new AbonoDto()
                {
                    IdAbono = lectorFilas.GetInt32(0),
                    ValorAbono = lectorFilas.GetInt32(1),
                    FechaAbono = lectorFilas.GetDateTime(2)
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoAbonos;
        }
    }
}
