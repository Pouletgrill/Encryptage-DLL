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
            string chaine = "";
            for (int i = 0; i < Chaine.Length; i++)
            {
                if (i < indice)//si le caractère fait partie de ceux a inverser
                {
                    chaine += Chaine[Chaine.Length - indice + i];
                }
                else
                {
                    chaine += Chaine[i - indice];
                }
            }
            return chaine;
        }
        public static string Decrypter(string Chaine, int indice)
        {
            string chaineA = "";
            string chaineB = "";
            for (int i = 0; i < Chaine.Length; i++)
            {
                if (i<indice)//si le caractère fait partie de ceux a inverser
                {
                    chaineB += Chaine[i];
                }
                else
                {
                    chaineA += Chaine[i];
                }
            }
            return chaineA+chaineB;//Inversage des chaine
        }
    }
}
