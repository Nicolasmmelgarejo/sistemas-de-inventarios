using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemas_de_inventarios
{
    internal class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection cn = new SqlConnection($@"Data Source=.\SQLEXPRESS;Initial Catalog=proyectdb;Integrated Security=True");
            
            return cn;
        }
    }
}
