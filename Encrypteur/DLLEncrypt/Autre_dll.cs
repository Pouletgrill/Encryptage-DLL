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
            string chaine = "";
            int indice=0;
            int indice_Incr_Modulo = 26;

            for (int i = 0; i < Chaine.Length; i++)
            {
                indice = i % indice_Incr_Modulo;
                //entre 65 et 90 	MAJUSCULE
                if (Chaine[i] >= 65 && Chaine[i] <= 90)
                {
                    if (Chaine[i] + indice > 90)
                        chaine += Convert.ToChar(Chaine[i] + indice + 6);
                    else
                        chaine += Convert.ToChar(Chaine[i] + indice);
                }
                //entre 97 et 122	minuscule
                else if (Chaine[i] >= 97 && Chaine[i] <= 122)
                {
                    if (Chaine[i] + indice > 122)
                        chaine += Convert.ToChar(((Chaine[i] + indice) % 122) + 64);
                    else
                        chaine += Convert.ToChar(Chaine[i] + indice);
                }
                else//si le caractère n'est pas dans l'alphabete
                {
                    chaine += Chaine[i];
                }
            }
            return chaine;
        }
        public static string Decrypter(string Chaine)
        {
            string chaine = "";
            int indice = 0;
            int indice_Incr_Modulo = 26;

            for (int i = 0; i < Chaine.Length; i++)
            {
                indice = i % indice_Incr_Modulo;
                //entre 65 et 90 	MAJUSCULE
                if (Chaine[i] >= 65 && Chaine[i] <= 90)
                {
                    if (Chaine[i] - indice < 65)
                        chaine += Convert.ToChar(Chaine[i] - indice + 58);
                    else
                        chaine += Convert.ToChar(Chaine[i] - indice);
                }
                //entre 97 et 122	minuscule
                else if (Chaine[i] >= 97 && Chaine[i] <= 122)
                {
                    if (Chaine[i] - indice < 97)
                        chaine += Convert.ToChar(Chaine[i] - indice - 6);
                    else
                        chaine += Convert.ToChar(Chaine[i] - indice);
                }
                else//si le caractère n'est pas dans l'alphabete
                {
                    chaine += Chaine[i];
                }
            }
            return chaine;
        }
    }
}
