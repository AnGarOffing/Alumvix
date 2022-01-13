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
    internal class ProveedorDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<string> ConsultarProveedoresParaCB()
        {
            command.Connection = connection;
            command.CommandText = "select * from PROVEEDOR";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> proveedores = new List<string>();
            proveedores.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                proveedores.Add(lectorFilas.GetString(1));
            }
            return proveedores;
        }
    }
}
