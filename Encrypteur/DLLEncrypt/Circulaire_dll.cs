using System;
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
            for (int i = 0; i < Chaine.Length;i++ )
            {
                if (i<indice)
                {
                    chaine += Chaine[Chaine.Length-indice+i];
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
            string chaine = "";
            for (int i = 0; i < Chaine.Length;i++ )
            {
                if (i<=indice)
                {
                    chaine += Chaine[i + indice]; //grillpoulet
                }
                else
                {
                    chaine += Chaine[i - indice-1];//WTF
                }
            }
                return chaine;
        }
    }
}
