namespace Exo_3_4_Diviseurs_Nombre
{
    internal class Program_3_4
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Veuillez saisir un nombre entier : ");
            a = int.Parse(Console.ReadLine());

            for (int i = 2; i < a; i++)
            {
                if(a%i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}