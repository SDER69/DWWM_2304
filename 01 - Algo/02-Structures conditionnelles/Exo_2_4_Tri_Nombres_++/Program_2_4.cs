using System;
using System.Runtime.Intrinsics.X86;

namespace Exo_2_4_Tri_Nombres_
{
    internal class Program_2_4
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Veuillez entrer un premier nombre a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un second nombre b : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un troisième nombre c : ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c && b < c)
            {
                Console.WriteLine("a = " + a + " b = " + b + " c = " + c);
            }
            else if (b < a && b < c && a < c)
            {
                Console.WriteLine("b = " + b + " a = " + a + " c = " + c);
            }
            else if (c < a && c < b && a < b)
            {
                Console.WriteLine("c = " + c + " a = " + a + " b = " + b);
            }
            else if (a > b && a > c && b > c)
            {
                Console.WriteLine("c = " + c + " b = " + b + " a = " + a);
            }
            else if (a < b && a < c && b > c)
            {
                Console.WriteLine("a = " + a + " c = " + c + " b = " + b);
            }
            else if (a > b && a > c && b < c)
            {
                Console.WriteLine("b = " + b + " c = " + c + " a = " + a);
            }
        }
    }
}