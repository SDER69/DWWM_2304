using System;

namespace Exo_3_3_Intervalle_Entre_2_Nombres
{
    internal class Program_3_3
    {
        static void Main(string[] args)
        {
            int a, b;
            //List<int> ordreCroissant = new List<int>();
            //List<int> ordreDecroissant = new List<int>();


            Console.WriteLine("Veuillez saisir un premier nombre entier : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un second nombre entier : ");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    //ordreCroissant.Add(i);
                    Console.Write(i + " ");

                }
                //Console.WriteLine(String.Join(" ", ordreCroissant));
            }
            else
            {
                for(int i = a-1; i > b ; i--)
                {
                    //ordreDecroissant.Add(i);
                    Console.Write(i + " ");
                }
                
                //Console.WriteLine(String.Join(" ", ordreDecroissant));

            }
            
            }
        }
    }
