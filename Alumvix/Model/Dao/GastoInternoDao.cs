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

        public bool IngresarGastoInterno(int valorGastoInterno, string fechaGastoInterno, string descripcionGastoInterno, int tipoGastoInterno)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into GASTO_INTERNO values(" + valorGastoInterno + ",'" + fechaGastoInterno + "','" + descripcionGastoInterno + "'," + tipoGastoInterno + ")";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public List<string> ObtenerTiposDeGastoInterno()
        {
            command.Connection = connection;
            command.CommandText = "select * from TIPO_GASTO where ID_TIPO_GASTO <> 3 and ID_TIPO_GASTO <> 4 and ID_TIPO_GASTO <> 8";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> tiposDeGastoInterno = new List<string>();
            tiposDeGastoInterno.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                tiposDeGastoInterno.Add(lectorFilas.GetString(1));
            }
            return tiposDeGastoInterno;
        }

        public int ObtenerTipoGastoInternoPorNombre(string nombreTipoGasto)
        {
            int idGastoInterno = 0;
            command.Connection = connection;
            command.CommandText = "select ID_TIPO_GASTO from TIPO_GASTO where NombreTipoGasto = '" + nombreTipoGasto + "'";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            idGastoInterno = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return idGastoInterno;
        }

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

        public bool EliminarGastoInterno(int idGastoInterno)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from GASTO_INTERNO where ID_GASTO_INTERNO = " + idGastoInterno;
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

        public List<GastoInternoDto> ObtenerGastosInternosPorPeriodo(string fechaInicial, string fechaFinal)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGastoInterno) as Valor from GASTO_INTERNO" 
                                +" inner join TIPO_GASTO on GASTO_INTERNO.FK_ID_TIPO_GASTO1 = TIPO_GASTO.ID_TIPO_GASTO where fechaGastoInterno between " + fechaInicial + " and " + fechaInicial + " group by NombreTipoGasto";
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

        public int ObtenerTotalGastosInternosPorPeriodo(string fechaInicial, string fechaFinal)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGastoInterno) from GASTO_INTERNO where fechaGastoInterno between '" + fechaInicial + "' and '" + fechaFinal + "'";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalGastosInternos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalGastosInternos;
        }

        public bool ActualizarGastoInterno(int valorGastoInterno, string fechaGastoInterno, string descripcionGastoInterno, int idGastoInterno)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update GASTO_INTERNO set valorGastoInterno = " + valorGastoInterno + ","
                +" fechaGastoInterno = '" + fechaGastoInterno + "', descripcionGastoInterno = '" + descripcionGastoInterno + "'" 
                +" where FK_ID_TIPO_GASTO1 = " + idGastoInterno;
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
    }
}
