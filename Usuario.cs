using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_inventarios
{
    public class Usuario
    {
        public string name;
        public string pass;
        public string id;

       public  Usuario(string Name,string Password, string ID)
        {
            this.name = Name;
            this.pass = Password;
            this.id = ID;
        }

        public Usuario() { }
    }
}
