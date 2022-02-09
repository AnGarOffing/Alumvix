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
    internal class UsuarioDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<UsuarioDto> ObtenerListadoUsuarios()
        {
            command.Connection = connection;
            command.CommandText = "select * from USUARIO";
            command.CommandType = CommandType.Text;
            connection.Open();

            lectorFilas = command.ExecuteReader();
            List<UsuarioDto> listaUsuarios = new List<UsuarioDto>();
            while (lectorFilas.Read())
            {
                listaUsuarios.Add(new UsuarioDto
                {
                    Usuario = lectorFilas.GetString(1),
                    Password = lectorFilas.GetString(2),
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listaUsuarios;
        }
    }

    
}
