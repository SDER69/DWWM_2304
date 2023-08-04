namespace Exo_3_6_Jeu_De_La_Fourchette
{
    internal class Program_3_6
    {
        static void Main(string[] args)
        {
            int n;
            Random aleatoire = new Random();
            int aleat = aleatoire.Next(101);
            int tentatives = 1;
            int min = 0;
            int max = 100;
            
            
            Console.WriteLine("Veuillez entrer un nombre : ");
            n = int.Parse(Console.ReadLine());
            while (n != aleat)
            {
                if (n < aleat)
                {
                    Console.WriteLine("Trop petit,le nombre est compris entre "+(n+1)+" et "+max);
                    n = int.Parse(Console.ReadLine());
                    tentatives++;
                }
                else
                {
                    Console.WriteLine("Trop grand,le nombre est compris entre " + min + " et " + (n-1));
                    n = int.Parse(Console.ReadLine());
                    tentatives++;
                }
            }
            if (tentatives == 1)
            {
                Console.WriteLine("Bravo vous avez trouvé le nombre en " + tentatives + " tentative");
            }
            else
                Console.WriteLine("Bravo vous avez trouvé le nombre en " + tentatives + " tentatives");
        }
    }

}
    