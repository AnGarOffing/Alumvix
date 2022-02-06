using Alumvix.Model.Dto;
using System;
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
            command.CommandText ="select ID_GASTO, numeroFactura, valorGasto, fechaGasto, descripcionGasto, nombreProveedor, NombreTipoGasto from GASTO"
                                +" inner join PROVEEDOR on GASTO.ID_PROVEEDOR1 = PROVEEDOR.ID_PROVEEDOR"
                                +" inner join TIPO_GASTO on GASTO.FK_ID_TIPO_GASTO = TIPO_GASTO.ID_TIPO_GASTO"
                                +" where FK_ID_CONTRATO2 = "+idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos =new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    IdGasto = lectorFilas.GetInt32(0),
                    NumeroFactura = lectorFilas.GetString(1),
                    ValorGasto = lectorFilas.GetInt32(2),
                    FechaGasto = lectorFilas.GetDateTime(3),
                    DescripcionGasto = lectorFilas.GetString(4),
                    Proveedor = lectorFilas.GetString(5),
                    TipoGasto = lectorFilas.GetString(6),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }

        

        public List<GastoDto> ObtenerGastosSinProveedor()
        {
            command.Connection = connection;
            command.CommandText = "select ID_GASTO, valorGasto, fechaGasto, descripcionGasto, NombreTipoGasto from GASTO" 
                                +" inner join TIPO_GASTO on GASTO.FK_ID_TIPO_GASTO = TIPO_GASTO.ID_TIPO_GASTO"
                                +" where FK_ID_TIPO_GASTO<> 4";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos = new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    IdGasto = lectorFilas.GetInt32(0),
                    ValorGasto = lectorFilas.GetInt32(1),
                    FechaGasto = lectorFilas.GetDateTime(2),
                    DescripcionGasto = lectorFilas.GetString(3),
                    TipoGasto = lectorFilas.GetString(4),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }

        public bool IngresarGasto(string numeroFactura, int valorGasto, string fechaGasto, string descripcionGasto, int proveedor, int tipoGasto,  int idContrato)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into GASTO values('" + numeroFactura + "', " + valorGasto + ",'" + fechaGasto + "','" + descripcionGasto + "'," + proveedor + ","+ tipoGasto +"," + idContrato + ")";
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

        public bool ActualizarGasto(string numeroFactura, int valorGasto, string fechaGasto, string descripcionGasto, int proveedor, int tipoGasto, int idGasto)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update GASTO set numeroFactura = '" + numeroFactura + "', valorGasto = " + valorGasto + ", fechaGasto = '" + fechaGasto + "', descripcionGasto = '" + descripcionGasto+ "', ID_PROVEEDOR1 = " + proveedor + ", FK_ID_TIPO_GASTO = " + tipoGasto 
                                + " where ID_GASTO = " + idGasto;
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

        public List<string> ObtenerTiposDeGastoMaterial()
        {
            command.Connection = connection;
            command.CommandText = "select * from TIPO_GASTO where ID_TIPO_GASTO = 3 or ID_TIPO_GASTO = 4 or ID_TIPO_GASTO = 8";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> tiposDeGasto = new List<string>();
            tiposDeGasto.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                tiposDeGasto.Add(lectorFilas.GetString(1));
            }
            return tiposDeGasto;
        }

        public int ObtenerTipoGastoPorNombre(string nombreTipoGasto)
        {
            int idGasto = 0;
            command.Connection = connection;
            command.CommandText = "select ID_TIPO_GASTO from TIPO_GASTO where NombreTipoGasto = '"+nombreTipoGasto+"'";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            idGasto = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return idGasto;
        }

        public List<GastoDto> ObtenerGastosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGasto) as Valor from GASTO" 
                                  +" inner join TIPO_GASTO on GASTO.FK_ID_TIPO_GASTO = TIPO_GASTO.ID_TIPO_GASTO where FK_ID_CONTRATO2 in"
                                  +" (select ID_CONTRATO from CONTRATO where MONTH(fechaInicioContrato) = "+ mes + " and YEAR(fechaInicioContrato) = "+ anio +") group by NombreTipoGasto";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos = new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    TipoGasto = lectorFilas.GetString(0),
                    ValorGasto = lectorFilas.GetInt32(1),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }

        public List<GastoDto> ObtenerGastosPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGasto) as Valor from GASTO"
                                  + " inner join TIPO_GASTO on GASTO.FK_ID_TIPO_GASTO = TIPO_GASTO.ID_TIPO_GASTO where FK_ID_CONTRATO2 in"
                                  + " (select ID_CONTRATO from CONTRATO where YEAR(fechaInicioContrato) = " + anio + ") group by NombreTipoGasto";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos = new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    TipoGasto = lectorFilas.GetString(0),
                    ValorGasto = lectorFilas.GetInt32(1),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }

        public List<GastoDto> ObtenerGastosPorPeriodo(string fechaInicial, string fechaFinal)
        {
            command.Connection = connection;
            command.CommandText = "select NombreTipoGasto as Tipo, SUM(valorGasto) as Valor from GASTO" 
                                +" inner join TIPO_GASTO on GASTO.FK_ID_TIPO_GASTO = TIPO_GASTO.ID_TIPO_GASTO where FK_ID_CONTRATO2 in"
                                +" (select ID_CONTRATO from CONTRATO where fechaInicioContrato between " + fechaInicial + " and " + fechaFinal +") group by NombreTipoGasto";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<GastoDto> listadoGastos = new List<GastoDto>();
            while (lectorFilas.Read())
            {
                listadoGastos.Add(new GastoDto()
                {
                    TipoGasto = lectorFilas.GetString(0),
                    ValorGasto = lectorFilas.GetInt32(1),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoGastos;
        }
    }
}
