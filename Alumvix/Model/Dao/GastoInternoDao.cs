using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alumvix.Model.Dao
{
    internal class GastoInternoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<GastoInternoDto> ObtenerGastosInternos()
        {
            command.Connection = connection;
            command.CommandText = "select ID_GASTO_INTERNO, valorGastoInterno, fechaGastoInterno,"
                                +" descripcionGastoInterno, NombreTipoGasto from GASTO_INTERNO" 
                                +" inner join TIPO_GASTO on GASTO_INTERNO.FK_ID_TIPO_GASTO1 = TIPO_GASTO.ID_TIPO_GASTO";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoInternoDto> listadoGastosInternos = new List<GastoInternoDto>();
            while (lectorFilas.Read())
            {
                listadoGastosInternos.Add(new GastoInternoDto()
                {
                    IdGastoInterno = lectorFilas.GetInt32(0),
                    ValorGastoInterno = lectorFilas.GetInt32(1),
                    FechaGastoInterno = lectorFilas.GetDateTime(2),
                    DescripcionGastoInterno = lectorFilas.GetString(3),
                    TipoGastoInterno = lectorFilas.GetString(4),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastosInternos;
        }

        public List<GastoInternoDto> ObtenerGastosInternosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGastoInterno)"
                                +" as Valor from GASTO_INTERNO inner join TIPO_GASTO on GASTO_INTERNO.FK_ID_TIPO_GASTO1 =" 
                                +" TIPO_GASTO.ID_TIPO_GASTO where MONTH(fechaGastoInterno) = "+ mes + " and YEAR(fechaGastoInterno) = "+ anio +" group by NombreTipoGasto";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoInternoDto> listadoGastosInternos = new List<GastoInternoDto>();
            while (lectorFilas.Read())
            {
                listadoGastosInternos.Add(new GastoInternoDto()
                {
                    TipoGastoInterno = lectorFilas.GetString(0),
                    ValorGastoInterno = lectorFilas.GetInt32(1),                   
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastosInternos;
        }

        public List<GastoInternoDto> ObtenerGastosInternosPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGastoInterno)"
                                + " as Valor from GASTO_INTERNO inner join TIPO_GASTO on GASTO_INTERNO.FK_ID_TIPO_GASTO1 ="
                                + " TIPO_GASTO.ID_TIPO_GASTO where YEAR(fechaGastoInterno) = " + anio + " group by NombreTipoGasto";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoInternoDto> listadoGastosInternos = new List<GastoInternoDto>();
            while (lectorFilas.Read())
            {
                listadoGastosInternos.Add(new GastoInternoDto()
                {
                    TipoGastoInterno = lectorFilas.GetString(0),
                    ValorGastoInterno = lectorFilas.GetInt32(1),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastosInternos;
        }
    }
}
