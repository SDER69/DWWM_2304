using System;

namespace Exo_2_5_Ma_Bicyclette
{
    internal class Program_2_5
    {
        static void Main(string[] args)
        {
            bool meteo;
            bool etatBicyclette;
            bool veloUtilisable;
            bool possessionLivre;
            bool livreDisponible;

            Console.WriteLine("Est-ce qu'il fait beau aujourd'hui ?");
            meteo = bool.Parse(Console.ReadLine());

            if (meteo)
            {
                Console.WriteLine("Est-ce que la bicyclette est en bon état ?");
                etatBicyclette = bool.Parse(Console.ReadLine());
                if (etatBicyclette)
                {
                    Console.WriteLine("Je peux faire une balade en bicyclette.");
                }
                else
                {
                    Console.WriteLine("Aller chez garagiste avant la balade.");
                    Console.WriteLine();
                    Console.WriteLine("Est-ce que le vélo est réparable immédiatement ?");
                    veloUtilisable = bool.Parse(Console.ReadLine());
                    if (veloUtilisable)
                    {
                        Console.WriteLine("Le vélo est utilisable.");
                        Console.WriteLine("Je peux faire une balade en bicyclette.");
                    }
                    else
                    {
                        Console.WriteLine("Renoncer à la balade en bicyclette.");
                        Console.WriteLine("Aller à pied jusqu'à l'étang pour cueillir des joncs.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Consacrer sa journée à la lecture.");
                Console.WriteLine();
                Console.WriteLine("Est-ce que le livre est en ma possession ?");
                possessionLivre = bool.Parse(Console.ReadLine());
                if (possessionLivre)
                {
                    Console.WriteLine("Je peux m'installer confortablement dans le canapé pour la lecture.");
                }
                else
                {
                    Console.WriteLine("Emprunter le livre à la bibliothèque.");
                    Console.WriteLine();
                    Console.WriteLine("Est-ce que le livre est disponible à la bibliothèque ?");
                    livreDisponible = bool.Parse(Console.ReadLine());
                    if (livreDisponible)
                    {
                        Console.WriteLine("Rentrer à la maison");
                        Console.WriteLine("S'installer confortablement dans le canapé pour la lecture.");
                    }
                    else
                    {
                        Console.WriteLine("Emprunter un roman policier.");
                        Console.WriteLine("Rentrer à la maison");
                        Console.WriteLine("S'installer confortablement dans le canapé pour la lecture.");
                    }
                }
            }
            
        }
    }

}
            
    

    
                   

              
                  
                    
                
            
