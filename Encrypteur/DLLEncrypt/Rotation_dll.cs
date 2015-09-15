using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEncrypt
{
    public class Rotation_dll
    {
        public static string Encrypter(string Chaine, int indice)
        {
            string chaine = "";
            for (int i = 0; i < Chaine.Length; i++)
            {
                //entre 65 et 90 	MAJUSCULE
                //entre 97 et 122	minuscule
                if ((Chaine[i] >= 65 && Chaine[i] <= 90) || (Chaine[i] >= 97 && Chaine[i] <= 122))
                {
                    if ((Chaine[i] + indice) > 90 && (Chaine[i] + indice) < 97)
                    {
                        chaine += Convert.ToChar(Chaine[i] + indice + 6);
                    }
                    else if ((Chaine[i] + indice) > 122)
                    {
                        chaine += Convert.ToChar(Chaine[i] + indice - 58);
                    }
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
        public static string Decrypter(string Chaine, int indice)
        {
            string chaine = "";
            for (int i = 0; i < Chaine.Length; i++)
            {
                //entre 65 et 90 	MAJUSCULE
                //entre 97 et 122	minuscule
                if ((Chaine[i] >= 65 && Chaine[i] <= 90)/*MAJUSCULE*/ || (Chaine[i] >= 97 && Chaine[i] <= 122)/*minuscule*/)
                {
                    if ((Chaine[i] - indice) > 90 && (Chaine[i] - indice) <= 97)
                    {
                        chaine += Convert.ToChar(Chaine[i] - indice - 6);
                    }
                    else if ((Chaine[i] - indice) < 65)
                    {
                        chaine += Convert.ToChar(Chaine[i] - indice + 58);
                    }
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
