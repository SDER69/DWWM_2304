using System.Runtime.CompilerServices;

namespace Exo_1_3_Calcul_Moyenne
{
    internal class Program_1_3
    {
        static void Main(string[] args)
        {
            int nombre1;
            int nombre2;
            double moyenne;
            String saisie;

            Console.WriteLine("******************************************************************");
            Console.WriteLine("*Bienvenue dans le programme de calcul de la moyenne de 2 nombres*");
            Console.WriteLine("******************************************************************");

            Console.WriteLine("Veuillez saisir un premier nombre : ");

            saisie = Console.ReadLine();

            //nombre1 = Convert.ToInt32(saisie);

            nombre1 = int.Parse(saisie);

            Console.WriteLine("Veuillez saisir un second nombre : ");

            nombre2 =int.Parse(Console.ReadLine());

            moyenne = (nombre1 + nombre2) / 2d;

            Console.WriteLine("La moyenne de " + nombre1 + " et " + nombre2 + " est : " + moyenne);

            Console.ReadLine();





        }
    }
}