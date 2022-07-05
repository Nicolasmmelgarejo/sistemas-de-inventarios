using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sistemas_de_inventarios
{
    internal class DaoUsuario
    {
        public Usuario GetUsuario(string usuario,string hashPass)
        {

            SqlConnection connection = Connection.Connect();
            connection.Open();

            SqlCommand cmd = new SqlCommand($@"select* from dbo.loginTable where username = '{usuario}' and password = '{hashPass}';" ,connection);

            SqlDataReader reader = cmd.ExecuteReader();

            Usuario usuario1 = null;

            while (reader.Read())
            {
                usuario1 = new Usuario();
                usuario1.name = reader.GetValue(0).ToString();
                usuario1.pass = reader.GetValue(1).ToString();
            }
          

            return usuario1;
        }

    }
}
