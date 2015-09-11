using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEncrypt
{
    public class Autre_dll
    {
        public static string Encrypter(string Chaine)
        {
            return Chaine + "_E_AUT";
        }
        public static string Decrypter(string Chaine)
        {
            return Chaine + "_D_AUT";
        }
    }
}
