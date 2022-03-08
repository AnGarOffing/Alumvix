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
    internal class ResumenContratoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<ResumenContratoDto> ObtenerResumenContratos(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select fechaInicioContrato, nombreCliente, ID_CONTRATO as #Factura,"
                + " NombreTipoFactura as Tipo_Factura, valorContrato, NombreCategoriaFactura  from CONTRATO c"
                + " inner join CLIENTE cl on c.FK_ID_CLIENTE = cl.ID_CLIENTE inner join CATEGORIA_FACTURA cf"
                + " on c.FK_ID_CATEGORIA_FACTURA = cf.ID_CATEGORIA_FACTURA inner join TIPO_FACTURA tf on c.FK_ID_TIPO_FACTURA ="
                + " tf.ID_TIPO_FACTURA where MONTH(fechaInicioContrato) = "+ mes + " and YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<ResumenContratoDto> resumenContratos = new List<ResumenContratoDto>();
            while (lectorFilas.Read())
            {
                resumenContratos.Add(new ResumenContratoDto()
                {
                    FechaInicioContrato = lectorFilas.GetDateTime(0),
                    NombreCliente = lectorFilas.GetString(1),
                    NumeroFactura = lectorFilas.GetInt32(2),
                    TipoFactura = lectorFilas.GetString(3),
                    ValorFactura = lectorFilas.GetInt32(4),
                    Categoria = lectorFilas.GetString(5)
                });
            }
            lectorFilas.Close();
            connection.Close();
            return resumenContratos;
        }
    }
}
