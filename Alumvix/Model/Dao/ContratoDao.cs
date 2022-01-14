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
            command.CommandText = "select ID_CONTRATO, valorContrato, fechaInicioContrato, fechaTerminacionContrato, nombreEstadoContrato, nombreEstadoTrabajo, NombreTipoFactura from CONTRATO"
                                + " inner join ESTADO_CONTRATO on CONTRATO.FK_ID_ESTADO_CONTRATO = ESTADO_CONTRATO.ID_ESTADO_CONTRATO"
                                + " inner join ESTADO_TRABAJO on CONTRATO.FK_ID_ESTADO_TRABAJO = ESTADO_TRABAJO.ID_ESTADO_TRABAJO"
                                + " inner join TIPO_FACTURA on CONTRATO.FK_ID_TIPO_FACTURA = TIPO_FACTURA.ID_TIPO_FACTURA where FK_ID_CLIENTE = " + idCliente;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            ContratoDto contrato = new ContratoDto();
            lectorFilas.Read();
            contrato.IdContrato = lectorFilas.GetInt32(0);
            contrato.ValorContrato = lectorFilas.GetInt32(1);
            contrato.FechaInicioContrato = lectorFilas.GetDateTime(2).ToString().Substring(0, 10);
            contrato.FechaTerminacionContrato = lectorFilas.GetDateTime(3).ToString().Substring(0, 10);
            contrato.EstadoContrato = lectorFilas.GetString(4);
            contrato.EstadoTrabajo = lectorFilas.GetString(5);
            contrato.TipoFactura = lectorFilas.GetString(6);
            lectorFilas.Close();
            connection.Close();
            return contrato;
        }

        public bool GuardarContrato(int valorContrato, string fechaInicio, string fechaFin, int estadoContrato, int estadoTrabajo, int tipoFactura, int idCliente)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "insert into CONTRATO values(" + valorContrato + ",'" + fechaInicio + "','" + fechaFin + "'," + estadoContrato + ", " + estadoTrabajo + ", " + tipoFactura + ", " + idCliente + ")";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public List<string> ObtenerTiposFactura()
        {
            command.Connection = connection;
            command.CommandText = "select * from TIPO_FACTURA";
            command.CommandType = CommandType.Text;
            connection.Open();
            List<string> tiposFactura = new List<string>();
            lectorFilas = command.ExecuteReader();
            tiposFactura.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                tiposFactura.Add(lectorFilas.GetString(1));
            }
            return tiposFactura;
        }

        public List<ContratoDto> ObtenerContratos(int idCliente)
        {
            command.Connection = connection;
            command.CommandText = "select ID_CONTRATO as '#_Factura', valorContrato as 'Valor', fechaInicioContrato as 'Fecha_Inicio',"
                                +" fechaTerminacionContrato as 'Fecha_Terminacion', nombreEstadoContrato as 'Estado_Contrato', nombreEstadoTrabajo as 'Estado_Trabajo', NombreTipoFactura as 'Tipo_Factura' from CONTRATO"
                                +" inner join ESTADO_CONTRATO on CONTRATO.FK_ID_ESTADO_CONTRATO = ESTADO_CONTRATO.ID_ESTADO_CONTRATO"
                                +" inner join ESTADO_TRABAJO on CONTRATO.FK_ID_ESTADO_TRABAJO = ESTADO_TRABAJO.ID_ESTADO_TRABAJO"
                                +" inner join TIPO_FACTURA on CONTRATO.FK_ID_TIPO_FACTURA = TIPO_FACTURA.ID_TIPO_FACTURA"
                                +" where FK_ID_CLIENTE = " + idCliente;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<ContratoDto> listadoContratos = new List<ContratoDto>();
            while (lectorFilas.Read())
            {
                listadoContratos.Add(new ContratoDto()
                {
                    IdContrato = lectorFilas.GetInt32(0),
                    ValorContrato = lectorFilas.GetInt32(1),
                    FechaInicioContrato = lectorFilas.GetDateTime(2).ToString(),
                    FechaTerminacionContrato = lectorFilas.GetDateTime(3).ToString(),
                    EstadoContrato = lectorFilas.GetString(4),
                    EstadoTrabajo = lectorFilas.GetString(5),
                    TipoFactura = lectorFilas.GetString(6),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoContratos;
        }
    }
}



