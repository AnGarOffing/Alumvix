using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Alumvix.Model.Dto;

namespace Alumvix.Model.Dao
{
    internal class ContratoDao : DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public ContratoDto ObtenerContrato(int idCliente)
        {
            command.Connection = connection;
            command.CommandText = "select ID_CONTRATO, numeroFactura, valorContrato, fechaInicioContrato, fechaTerminacionContrato, nombreEstadoContrato, nombreEstadoTrabajo, NombreTipoFactura from CONTRATO"
                                + " inner join ESTADO_CONTRATO on CONTRATO.FK_ID_ESTADO_CONTRATO = ESTADO_CONTRATO.ID_ESTADO_CONTRATO"
                                + " inner join ESTADO_TRABAJO on CONTRATO.FK_ID_ESTADO_TRABAJO = ESTADO_TRABAJO.ID_ESTADO_TRABAJO"
                                + " inner join TIPO_FACTURA on CONTRATO.FK_ID_TIPO_FACTURA = TIPO_FACTURA.ID_TIPO_FACTURA where FK_ID_CLIENTE = " + idCliente;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            ContratoDto contrato = new ContratoDto();
            lectorFilas.Read();
            contrato.IdContrato = lectorFilas.GetInt32(0);
            contrato.NumeroFactura = lectorFilas.GetString(1);
            contrato.ValorContrato = lectorFilas.GetInt32(2);
            contrato.FechaInicioContrato = lectorFilas.GetDateTime(3).ToString().Substring(0,10);
            contrato.FechaTerminacionContrato = lectorFilas.GetDateTime(4).ToString().Substring(0,10);
            contrato.EstadoContrato = lectorFilas.GetString(5);
            contrato.EstadoTrabajo = lectorFilas.GetString(6);
            contrato.TipoFactura = lectorFilas.GetString(7);
            lectorFilas.Close();
            connection.Close();
            return contrato;
        }
    }


}
