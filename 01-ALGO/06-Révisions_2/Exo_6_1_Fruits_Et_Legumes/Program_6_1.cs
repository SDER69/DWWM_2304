using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Exo_6_1_Fruits_Et_Legumes
{
    internal class Program_6_1
    {
        static void Main(string[] args)


        {
            string saisie;
            List<string> fruitsLegumes = new List<string>();
            
            string carottes = "1 kilogramme de carottes coûte 2.99 euros.";
            string poireaux = "1 kilogramme de poireaux coûte 1.99 euros.";
            string fraises = "1 kilogramme de fraises coûte 3.99 euros.";
            string pommes = "1 kilogramme de pommes coûte 0.99 euros.";
            string[] subs;
            List<float> nombresExtraits = new List<float>();
            
            do
            {
                Console.WriteLine("Veuillez saisir le nom des fruits ou légumes ainsi que leur prix au kilo : ");
                saisie = Console.ReadLine().ToLower();
                fruitsLegumes.Add(saisie);

            } while (saisie != "go");



            for (int fruit = 0; fruit < fruitsLegumes.Count; fruit++)
            {
               
                if (fruitsLegumes[fruit] == "carottes 2.99")
                {
                    Console.WriteLine(carottes);  
                }
                else if (fruitsLegumes[fruit] == "poireaux 1.99")
                {
                    Console.WriteLine(poireaux);
                }
                else if (fruitsLegumes[fruit] == "fraises 3.99")
                {
                    Console.WriteLine(fraises);
                }
                else if (fruitsLegumes[fruit] == "pommes 0.99")
                {
                    Console.WriteLine(pommes);
                }
                
                List<string> numbers = new List<string>();
                subs = fruitsLegumes[fruit].Split(' ');
                for (int i = 0; i < subs.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        numbers.Add(subs[i]);

                    }
                }
                numbers.Add(subs[1]);
               
                for (int number = 0; number < numbers.Count ; number++)
                {
                    float numberExtrait = float.Parse(numbers[number], CultureInfo.InvariantCulture.NumberFormat);
                    nombresExtraits.Add(numberExtrait);
                }
                
            }
            nombresExtraits.Sort();
            for (int i = 0; i < nombresExtraits.Count; i++)
            {
                if (nombresExtraits[0] == 0.99f)
                {
                    Console.WriteLine("Légume ou fruit le moins cher au kilo : pommes");
                    break;
                }
                else if(nombresExtraits[0] == 1.99f)
                {
                    Console.WriteLine("Légume ou fruit le moins cher au kilo : poireaux");
                    break;
                }
                else if (nombresExtraits[0] == 2.99f)
                {
                    Console.WriteLine("Légume ou fruit le moins cher au kilo : carottes");
                    break;
                }
                else if (nombresExtraits[0] == 3.99f)
                {
                    Console.WriteLine("Légume ou fruit le moins cher au kilo : fraises");
                    break;
                }
            }

        }
    }
}


                



        




   
        




   
    

