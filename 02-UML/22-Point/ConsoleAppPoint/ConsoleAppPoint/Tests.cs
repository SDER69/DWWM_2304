using ClassLibraryPoint;

namespace ConsoleAppPoint
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            // Tests constructeurs

            // 1) Constructeur par défaut
            /*Point p = new Point();
            Console.WriteLine(p.ToString());
            */

            // 2) Constructeur avec paramètres
            //Point p = new Point(1.5F,3.5F);
            //Console.WriteLine(p.ToString());

            // 3) Constructeur par copie
            /*Point p1 = new Point(1.5F, 3.5F);
            Point p2 = new Point(p1);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p1.GetHashCode == p2.GetHashCode);
            */

            // Tests Méthodes
            // Méthode Déplacer()
            /*Point p1 = new Point(1.5F, 3.5F);
            p1.Deplacer(2.5F, 4.5F);
            Console.WriteLine(p1.ToString());
            */

            // Méthode Permuter()
            /*Point p1 = new Point(1.5F, 3.5F);
            p1.Permuter();
            Console.WriteLine(p1.ToString());
            */

            // Méthode SymetrieAxeAbscisse
            /*Point p1 = new Point(3.5F,5F);
            Point p2=p1.SymetrieAxeAbscisse();
            Console.WriteLine(p2.ToString());
            */

            // Méthode SymetrieAxeAbscisse
            /*Point p1 = new Point(3.5F, 5F);
            Point p2 = p1.SymetrieAxeOrdonnee();
            Console.WriteLine(p2.ToString());
            */

            // Méthode SymetrieOrigine
            Point p1 = new Point(3F, -4F);
            Point p2 = p1.SymetrieOrigine();
            Console.WriteLine(p2.ToString());
            



        }
    }
}