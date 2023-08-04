using System;

namespace Exo_3_5_Nombre_Premier
{
    internal class Program_3_5
    {
        static void Main(string[] args)
        {
            int n;
            int compteur = 0;

           
            Console.WriteLine("Veuillez saisir un nombre entier : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    compteur++;
            }
           
            if (compteur == 2)
            {
                Console.WriteLine("Le nombre saisi est premier");
            }
            else
            {
                Console.WriteLine("Le nombre saisi n'est pas premier");
            }

        }
    }


}



  
    
    


