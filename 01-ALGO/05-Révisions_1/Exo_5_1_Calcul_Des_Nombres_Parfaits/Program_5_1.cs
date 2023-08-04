namespace Exo_5_1_Nbres_Parfaits
{
    internal class Exo_5_1
    {
        static void Main(string[] args)
        {

            int n = 4;
            int nombre = 2;
            int compteurNombresParfaits = 0;

            Console.WriteLine("Affichage des 4 premiers nombres parfaits : ");
            while (compteurNombresParfaits < n)
            {
                int sommeDiviseurs = 1;
                for (int diviseur = 2; diviseur <= nombre / 2; diviseur++)
                {
                    if (nombre % diviseur == 0)
                    {
                        sommeDiviseurs += diviseur;
                    }
                }
                if (sommeDiviseurs == nombre)
                {
                    Console.WriteLine("{0} est un nombre parfait.", nombre);
                    compteurNombresParfaits++;
                }
                nombre++;
            }
        }
    }
}

