using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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

        public bool ActualizarContrato(int valorContrato, string fechaInicio, string fechaFin, int estadoTrabajo, int tipoFactura, int idContrato)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update CONTRATO set valorContrato = " + valorContrato + ", fechaInicioContrato = '" + fechaInicio + "', fechaTerminacionContrato = '" + fechaFin + "',  FK_ID_ESTADO_TRABAJO = " + estadoTrabajo + ", FK_ID_TIPO_FACTURA = " + tipoFactura 
                                + " where ID_CONTRATO = " + idContrato;
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

        public void ActualizarEstadoContrato(int estadoContrato, int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "update CONTRATO set FK_ID_ESTADO_CONTRATO = " + estadoContrato + " where ID_CONTRATO = " + idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int ConsultarEstadoTrabajo(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select FK_ID_ESTADO_TRABAJO from CONTRATO where ID_CONTRATO = " + idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int idEstadoTrabajo = lectorFilas.GetInt32(0);      
            lectorFilas.Close();
            connection.Close();
            return idEstadoTrabajo;
        }

        internal string ConsultarEstadoContrato(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select nombreEstadoContrato from CONTRATO inner join ESTADO_CONTRATO"
                                +" on CONTRATO.FK_ID_ESTADO_CONTRATO = ESTADO_CONTRATO.ID_ESTADO_CONTRATO"
                                +" where ID_CONTRATO = " + idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            string estadoContrato = lectorFilas.GetString(0);
            lectorFilas.Close();
            connection.Close();
            return estadoContrato;
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
            lectorFilas.Close();
            connection.Close();
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


        public ContratoDto ObtenerContratoPorIdContrato(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select ID_CONTRATO, valorContrato, fechaInicioContrato, fechaTerminacionContrato, nombreEstadoContrato, nombreEstadoTrabajo, NombreTipoFactura from CONTRATO"
                                + " inner join ESTADO_CONTRATO on CONTRATO.FK_ID_ESTADO_CONTRATO = ESTADO_CONTRATO.ID_ESTADO_CONTRATO"
                                + " inner join ESTADO_TRABAJO on CONTRATO.FK_ID_ESTADO_TRABAJO = ESTADO_TRABAJO.ID_ESTADO_TRABAJO"
                                + " inner join TIPO_FACTURA on CONTRATO.FK_ID_TIPO_FACTURA = TIPO_FACTURA.ID_TIPO_FACTURA where ID_CONTRATO = " + idContrato;
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

        public bool EliminarContrato(int idContrato)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "delete from CONTRATO where ID_CONTRATO = " + idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public double ConsultarIVA(int idValorUtil)
        {
            command.Connection = connection;
            command.CommandText = "select valor from VALOR_UTIL where ID_VALOR_UTIL = " + idValorUtil;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            double valorIva = lectorFilas.GetDouble(0);
            lectorFilas.Close();
            connection.Close();
            return valorIva;
        }

        public bool ModificarIVA(int iva)
        {
            bool respuesta = false;
            command.Connection = connection;
            command.CommandText = "update VALOR_UTIL set valor = " + iva + " where ID_VALOR_UTIL = 1";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public List<string> ObtenerEstadosTrabajo()
        {
            command.Connection = connection;
            command.CommandText = "select * from ESTADO_TRABAJO";
            command.CommandType = CommandType.Text;
            connection.Open();
            List<string> tiposFactura = new List<string>();
            lectorFilas = command.ExecuteReader();
            while (lectorFilas.Read())
            {
                tiposFactura.Add(lectorFilas.GetString(1));
            }
            lectorFilas.Close();
            connection.Close();
            return tiposFactura;
        }
    }
}



