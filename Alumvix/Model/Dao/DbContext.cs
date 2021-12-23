using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alumvix.Model.Dao
{
    public class DbContext
    {
        protected SqlConnection _connection = new SqlConnection(
            "Server=DESKTOP-N7D39RE\\SQLEXPRESS;DataBase=ALUMVIX;Integrated Security=true");
    }
}
