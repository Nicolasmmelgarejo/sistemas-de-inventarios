using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_inventarios
{
    internal class Crypt
    {
        public static string Hash(string input)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(input);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            return (BitConverter.ToString(hash).Replace("-", string.Empty).ToLower());
          
        }
    }   
}
