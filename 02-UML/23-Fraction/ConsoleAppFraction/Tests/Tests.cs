using ClassLibraryFraction;
using System;

namespace Tests
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            //Tests Constructeurs
            /*Fraction f1 = new Fraction(12,7);
            Console.WriteLine(f1.ToString());

            Fraction f2 = new Fraction();
            Console.WriteLine(f2.ToString());

            Fraction f3 = new Fraction(9);
            Console.WriteLine(f3.ToString());

            Fraction f4 = new Fraction(f1);
            Console.WriteLine(f4.ToString());
            Console.WriteLine(f1.GetHashCode == f4.GetHashCode);
            */
            //Tests méthodes Oppose() et Inverse()
            //Fraction f1 = new Fraction(4, 7);
            //f1.Oppose();
            //Console.WriteLine(f1.ToString());
            //f1.Inverse();
            //Console.WriteLine(f1.ToString());

            //Tests méthodes SuperieurA() et EgalA()
            /*Fraction f = new Fraction(11,7);
            Fraction f1 = new Fraction(5,4);
            bool estSuperieur = f.SuperieurA(f1);
            Console.WriteLine(estSuperieur);
            */
            /*Fraction f = new Fraction(11, 7);
            Fraction f1 = new Fraction(23, 14);
            bool estEgal = f.EgalA(f1);
            Console.WriteLine(estEgal);
            */

            //Tests méthodes Plus() et Moins()
            Fraction f = new Fraction(-5, 15);
            Fraction f1 = new Fraction(9, 1);
            //Fraction somme = f.Plus(f1);// méthode classique
            Fraction somme = f + f1;// surcharge d'opérateur
            Console.WriteLine(somme.ToString());
            
            /*Fraction f = new Fraction(5, 10);
            Fraction f1 = new Fraction(2, 10);
            Fraction soustraction = f.Moins(f1);
            Console.WriteLine(soustraction.ToString());
            */

            //Tests méthodes Multiplie() et Divise()
            /*Fraction f = new Fraction(3, 6);
            Fraction f1 = new Fraction(4, 3);
            Fraction multiplication = f.Multiplie(f1);
            Console.WriteLine(multiplication.ToString());
            */
            /*Fraction f = new Fraction(3, 4);
            Fraction f1 = new Fraction(2, 3);
            Fraction division = f.Divise(f1);
            Console.WriteLine(division.ToString());
            */
        }
    }
}