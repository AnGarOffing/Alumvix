using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int cantidadContratos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                cantidadContratos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                cantidadContratos = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion a Base de Datos - " + ex);
                cantidadContratos = 0;
            }
            lectorFilas.Close();
            connection.Close();
            return cantidadContratos;            
        }

        public int ObtenerCantidadContratos(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select count(*) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            int cantidadContratos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                cantidadContratos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                cantidadContratos = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
                cantidadContratos = 0;
            }
            lectorFilas.Close();
            connection.Close();
            return cantidadContratos;
        }

        public int ObtenerTotalVentasPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            int totalVentas;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalVentas = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalVentas = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
                totalVentas = 0;
            }
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalVentasPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            int totalVentas;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalVentas = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalVentas = 0;
            }
            catch(SqlException ex)
            {
                totalVentas = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalVentasMesesDeAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO where YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            int totalVentas;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalVentas = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalVentas = 0;
            }
            catch (SqlException ex)
            {
                totalVentas = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalVentas;
        }

        public int ObtenerTotalGastosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGasto) from GASTO where FK_ID_CONTRATO2 in"
                                + " (select ID_CONTRATO from CONTRATO where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio + ")";
            command.CommandType = CommandType.Text;
            int totalGastos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalGastos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalGastos = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
                totalGastos = 0;
            }
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
            int totalGastos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalGastos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalGastos = 0;
            }
            catch(SqlException ex)
            {
                totalGastos = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalGastos;
        }

        public int ObtenerTotalGastosInternosPorMes(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGastoInterno) from GASTO_INTERNO where MONTH(fechaGastoInterno) = " + mes + " and YEAR(fechaGastoInterno) = " + anio;
            command.CommandType = CommandType.Text;
            int totalGastosInternos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalGastosInternos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalGastosInternos = 0;
            }
            catch (SqlException ex)
            {
                totalGastosInternos = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalGastosInternos;
        }

        public int ObtenerTotalGastosInternosPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorGastoInterno) from GASTO_INTERNO where YEAR(fechaGastoInterno) = " + anio;
            command.CommandType = CommandType.Text;
            int totalGastosInternos;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalGastosInternos = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalGastosInternos = 0;
            }
            catch (SqlException ex)
            {
                totalGastosInternos = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalGastosInternos;
        }

        //public List<ReporteDto> ObtenerCuentasMesDeUnAnio(int anio)
        //{
        //    command.Connection = connection;
        //    command.CommandText = "MostrarcuentasMensualesPorAnio";        
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@anio", anio);
        //    connection.Open();
        //    lectorFilas = command.ExecuteReader();
        //    List<ReporteDto> listadoCuentas = new List<ReporteDto>();
        //    while (lectorFilas.Read())
        //    {
        //        listadoCuentas.Add(new ReporteDto()
        //        {                   
        //            Mes = lectorFilas.GetString(0),
        //            TotalVentas = lectorFilas.GetInt32(1),
        //            TotalGastos = lectorFilas.GetInt32(2),
        //        });
        //    }
        //    lectorFilas.Close();
        //    connection.Close();
        //    return listadoCuentas;
        //}

        public int ObtenerTotalVentasPorMesDeUnAnio(int mes, int anio)
        {
            command.Connection = connection;
            command.CommandText = "select SUM(valorContrato) from CONTRATO "
                + " where MONTH(fechaInicioContrato) = " + mes + " and YEAR(fechaInicioContrato) = " + anio;
            command.CommandType = CommandType.Text;
            int totalVentasPorMes;
            try
            {
                connection.Open();
                lectorFilas = command.ExecuteReader();
                lectorFilas.Read();
                totalVentasPorMes = lectorFilas.GetInt32(0);
            }
            catch (SqlNullValueException ex)
            {
                ex = null;
                totalVentasPorMes = 0;
            }
            catch (SqlException ex)
            {
                totalVentasPorMes = 0;
                MessageBox.Show("Error de conexion a Base de Datos " + ex);
            }
            lectorFilas.Close();
            connection.Close();
            return totalVentasPorMes;
        }

        public List<ReporteDto> ObtenerGastosDeContratoMensualesPorAnio(int anio)
        {
            command.Connection = connection;
            command.CommandText = "MostrarGastosDeContratoMensualesPorAnio";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@anio", anio);
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<ReporteDto> reporteGastosMensuales = new List<ReporteDto>();
            while (lectorFilas.Read())
            {
                reporteGastosMensuales.Add(new ReporteDto()
                {
                    IndiceMes = lectorFilas.GetInt32(0),
                    Mes = lectorFilas.GetString(1),
                    TotalGastos = lectorFilas.GetInt32(2),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return reporteGastosMensuales;
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

        public ReporteDto ObtenerCuentasPorPeriodo(string fechaInicial, string fechaFinal )
        {
            //TODO: programar este metodo para poder habilitar la opcion de reporte por periodo
            //command.Connection = connection;
            //command.CommandText = "MostrarCuentasPorPeriodo";
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@fechaInicial", fechaInicial);
            //command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            //connection.Open();
            //lectorFilas = command.ExecuteReader();
            //ReporteDto reporteDto = new ReporteDto();
            //lectorFilas.Read();
            //reporteDto.CantidadContratos = lectorFilas.GetInt32(0);
            //reporteDto.TotalVentas = lectorFilas.GetInt32(1);
            //reporteDto.TotalGastos = lectorFilas.GetInt32(2);
            //lectorFilas.Close();
            //connection.Close();
            //return reporteDto;

            command.Connection = connection;
            command.CommandText = "select COUNT(ID_CONTRATO) as CantidadContratos, SUM(valorContrato) as TotalVentas, SUM(valorGasto) as TotalGastosContratos from CONTRATO"
                                +" inner join GASTO on CONTRATO.ID_CONTRATO = GASTO.FK_ID_CONTRATO2"
                                +" where fechaInicioContrato >= '" + fechaInicial + "' and fechaInicioContrato <= '" + fechaFinal + "'";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            ReporteDto reporteDto = new ReporteDto();
            lectorFilas.Read();
            reporteDto.CantidadContratos = lectorFilas.GetInt32(0);
            reporteDto.TotalVentas = lectorFilas.GetInt32(1);
            reporteDto.TotalGastos = lectorFilas.GetInt32(2);
            lectorFilas.Close();
            connection.Close();
            return reporteDto;
        }
    }
}
