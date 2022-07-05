using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_inventarios
{
    internal class ServicioUsuarios
    {
        public Usuario GetUsuario(string usuario,string password)
        {
            //llamar a hash
            string passhasheada = Crypt.Hash(password);

            //llamar a dao 
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.GetUsuario(usuario, passhasheada);

              
        }
    }
}
