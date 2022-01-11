﻿    using Alumvix.Model.Dto;
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

        public bool ActualizarGasto(int idGasto, int valorGasto, string fechaGasto, string descripcionGasto)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update GASTO set valorGasto = " + valorGasto + ", fechaGasto = '" + fechaGasto + "', descripcionGasto = '" + descripcionGasto+"'"
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
    }
}
