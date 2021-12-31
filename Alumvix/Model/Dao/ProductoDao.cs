using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Alumvix.Model.Dao
{
    internal class ProductoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<ProductoDto> ObtenerListadoProductos(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select ID_PRODUCTO, nombreProducto from CONTRATO "
                                +"inner join CONTRATO_PRODUCTO on CONTRATO.ID_CONTRATO = CONTRATO_PRODUCTO.FK_ID_CONTRATO3 "
                                +"inner join PRODUCTO on CONTRATO_PRODUCTO.FK_ID_PRODUCTO = PRODUCTO.ID_PRODUCTO where ID_CONTRATO ="+idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();

            lectorFilas = command.ExecuteReader();
            List<ProductoDto> listaProductos = new List<ProductoDto>();
            while (lectorFilas.Read())
            {
                listaProductos.Add(new ProductoDto
                {
                    IdProducto = lectorFilas.GetInt32(0),
                    NombreProducto = lectorFilas.GetString(1),                  
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listaProductos;
        }
    }
}
