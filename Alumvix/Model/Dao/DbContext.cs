using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alumvix.Model.Dao
{
    internal class DbContext
    {
        protected SqlConnection connection = new SqlConnection("Server=DESKTOP-PPUHH0V\\SQLEXPRESS;DataBase=ALUMVIX;Integrated Security=true");
        //protected SqlConnection connection = new SqlConnection("Server=DESKTOP-N7D39RE\\SQLEXPRESS;DataBase=ALUMVIX;Integrated Security=true");
    }
}
 