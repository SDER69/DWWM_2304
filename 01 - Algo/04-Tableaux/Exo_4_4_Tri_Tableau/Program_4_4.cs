using System;
using System.Globalization;


namespace Exo_4_5_Tri_Tableau
{
    internal class Program_4_4
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 128, 64, 8, 512, 16, 32, 256, 5 , 5, 10, 15, 250, 589, 789, 1456, 2569, 789, 456, 123 };




            /*Console.WriteLine("-------------------------------Méthode avec sort----------------------------------------------");
            Console.WriteLine("Tableau avant tri croissant :\n");
            
            foreach (int value in array)
            {
                Console.Write(value + " ");// affichage des valeurs du tableau donné
            }
            Console.WriteLine("\n");
            
            Array.Sort(array);// tri des valeurs par ordre croissant
            Console.WriteLine("Tableau après tri croissant :\n");
            foreach (int value in array)
            {
                Console.Write(value + " ");// affichage des valeurs du tableau par ordre croissant
               
            }
            Console.WriteLine("\n");
            */


            //Console.WriteLine("-------------------------------Méthode tri à bulles----------------------------------------------");



            /*for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j] < array[j - 1]; j--)
                {
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;


                }
            }*/




            /*for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {

                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }

                }
            */

            Console.WriteLine("-------------------------------Méthode demandée----------------------------------------------");


            for (int i = 0; i < array.Length; i++)
            {
                //recherche du minimum
                int indexMinimum = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[indexMinimum] > array[j])
                    {
                        indexMinimum = j;

                    }
                }
                //permutation
                int temp = array[indexMinimum];
                array[indexMinimum] = array[i];
                array[i] = temp;

            }



            /*Console.WriteLine("-------------------------------Affichage avec boucle for----------------------------------------------");
            for (int k=0; k < array.Length; k++)
            {
                Console.Write(array[k]+" ");
            }
             */
            Console.WriteLine("-------------------------------Affichage avec boucle foreach----------------------------------------------");
            foreach (int value in array)
            {
                Console.Write(value + " ");// affichage des valeurs du tableau donné
            }
            Console.WriteLine("\n");
            Console.WriteLine(array.Length);

        }



    }
}







