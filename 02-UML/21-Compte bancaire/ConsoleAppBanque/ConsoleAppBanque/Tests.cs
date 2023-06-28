using ConsoleAppBanque;

namespace ConsoleApp1
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            // Création compte
            /*Compte c = new Compte();
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            */
            // Méthodes Debiter() et Crediter()
            /*Compte b = new Compte(545454, "Laurent", 2000, -500);
            b.Crediter(100);
            Console.WriteLine(b);
            bool ok = b.Debiter(100000);
            
            Console.WriteLine(b.ToString());
            if (ok)
            {
                Console.WriteLine("Débit réussi");
            }
            else
            {
                Console.WriteLine("Débit non réussi");
            }
            */
            // Méthodes Transférer()
            Compte c1 = new Compte(12345,"toto",1000,-500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            c1.Transferer(1300,c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
           
            // Méthodes Superieur()
            /*Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.Superieur(c2))
            {
                Console.WriteLine("Supérieur");
            }
            else
            {
                Console.WriteLine("Inférieur");
            }
            */



        }
    }
}