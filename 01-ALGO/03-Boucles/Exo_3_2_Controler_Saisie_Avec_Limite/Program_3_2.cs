using System.Reflection;

namespace Exo_3_2_Controler_Saisie_Avec_Limite
{
    internal class Program_3_2
    {
        static void Main(string[] args)
        {
            String motDePasse;
            String motDePasseValide = "formation";
            int cpt = 0;

            do
            {
                Console.WriteLine("Veuillez saisir votre mot de passe :");
                motDePasse = Console.ReadLine();
                cpt++;
            } while (motDePasse!=motDePasseValide && cpt<3 );

            if (motDePasse == motDePasseValide)
            {
                Console.WriteLine("Vous êtes connecté");
            }
            else
            {
                Console.WriteLine("Votre compte est bloqué");
            }

        }
    }
}





















