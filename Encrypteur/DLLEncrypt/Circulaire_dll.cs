﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEncrypt
{
    public class Circulaire_dll
    {
        public static string Encrypter(string Chaine, int indice)
        {
            return Chaine + "_E_CIR";
        }
        public static string Decrypter(string Chaine, int indice)
        {
            return Chaine + "_D_CIR";
        }
    }
}
