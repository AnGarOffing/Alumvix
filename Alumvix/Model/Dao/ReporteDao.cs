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
    internal class ReporteDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public int ObtenerCantidadContratos(int mes, int anio) 
        {
            command.Connection = connection;
            command.CommandText = "select count(*) from CONTRATO where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int cantidadContratos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return cantidadContratos;
        }

        public int ObtenerCantidadContratos(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select count(*) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int cantidadContratos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return cantidadContratos;
        }

        public int ObtenerTotalVentasPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalVentas = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalVentasPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalVentas = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalVentasMesesDeAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalVentas = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalGastosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGasto) from GASTO where FK_ID_CONTRATO2 in" 
                                +" (select ID_CONTRATO from CONTRATO where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio + ")";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalGastos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalGastos;
        }

        public int ObtenerTotalGastosPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGasto) from GASTO where FK_ID_CONTRATO2 in"
                                + " (select ID_CONTRATO from CONTRATO where YEAR(fechaInicioContrato) = " + anio + ")";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalGastos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalGastos;
        }

        public int ObtenerTotalGastosInternosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGastoInterno) from GASTO_INTERNO where MONTH(fechaGastoInterno) = " + mes + " and YEAR(fechaGastoInterno) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalGastosInternos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalGastosInternos;
        }

        public int ObtenerTotalGastosInternosPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGastoInterno) from GASTO_INTERNO where YEAR(fechaGastoInterno) = " + anio;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            lectorFilas.Read();
            int totalGastosInternos = lectorFilas.GetInt32(0);
            lectorFilas.Close();
            connection.Close();
            return totalGastosInternos;
        }

        public List<ReporteDto> ObtenerCuentasMesDeUnAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "MostrarcuentasMensualesPorAnio";        
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@anio", anio);
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<ReporteDto> listadoCuentas = new List<ReporteDto>();
            while (lectorFilas.Read())
            {
                listadoCuentas.Add(new ReporteDto()
                {
                    
                    Mes = lectorFilas.GetString(0),
                    TotalVentas = lectorFilas.GetInt32(1),
                    TotalGastos = lectorFilas.GetInt32(2),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listadoCuentas;
        }

        public List<int> ObtenerIndicesDeMeses(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select MONTH(fechaInicioContrato) as Mes from CONTRATO where YEAR(fechaInicioContrato) = " + anio + " group by MONTH(fechaInicioContrato)";
            command.CommandType = CommandType.Text;
            connection.Open();
            List<int> listadoIndicesMeses = new List<int>();
            lectorFilas = command.ExecuteReader();        
            while (lectorFilas.Read())
            {
                listadoIndicesMeses.Add(lectorFilas.GetInt32(0));
            }
            lectorFilas.Close();
            connection.Close();
            return listadoIndicesMeses;
        }
    }
}
