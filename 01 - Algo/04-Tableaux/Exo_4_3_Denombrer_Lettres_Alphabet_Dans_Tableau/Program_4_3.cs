using System.Globalization;
using System.Threading.Channels;

namespace Exo_4_3_Denombrer_Lettres_Alphabet_Dans_Tableau
{
    internal class Program_4_3
    {
        static void Main(string[] args)
        {
            String texte;
            int longueurTexte = 0;
            int occurences = 0;

            do
            {
                Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères : ");
                texte = Console.ReadLine();
                longueurTexte = texte.Count();
                if (longueurTexte < 120)
                {
                    Console.WriteLine("Nombres de caractères saisis : " + longueurTexte);
                    Console.WriteLine("Le texte ne comporte pas un minimum de 120 caractères.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Nombres de caractères saisis : " + longueurTexte);
                    Console.WriteLine("Voici le décompte de toutes les occurences du texte pour chacune des lettres de l'alphabet : ");
                }
                
            } while (longueurTexte < 120);

            texte = texte.ToLower();
            for (char lettre = 'a'; lettre <= 'z'; lettre++)
            {
                occurences = 0;

                for (int j = 0; j < texte.Length; j++)
                {
                    if (lettre == texte[j])
                    {
                        occurences++;
                    }
                   
                }
                   Console.WriteLine("La lettre {0} est présente {1} fois.", lettre, occurences);
                    
            }
        }
    }

     
}

    

        
