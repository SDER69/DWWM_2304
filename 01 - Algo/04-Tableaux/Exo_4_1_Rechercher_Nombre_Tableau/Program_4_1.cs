namespace Exo_4_1_Rechercher_Nombre_Tableau
{
    internal class Program_4_1
    {
        static void Main(string[] args)
        {
            int[] nombres = { 8, 16, 32, 64, 128, 256 };
            int n;


            Console.WriteLine("Veuillez saisir un nombre entier : ");
            n = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(nombres, n);
            if (index > -1)
            {
                Console.WriteLine("{0} a été trouvé dans le tableau à l'index : {1}", n, index);
            }
            else
            {
                Console.WriteLine("Nombre non trouvé");


            }
        }
    }
}