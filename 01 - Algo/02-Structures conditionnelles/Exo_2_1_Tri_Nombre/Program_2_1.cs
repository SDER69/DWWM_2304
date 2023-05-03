namespace Tri_de_nombres
{
    internal class Program_2_1
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Veuillez entrer un premier nombre a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un premier nombre b : ");
            b = int.Parse(Console.ReadLine());

            if (b < a)
            {
                Console.WriteLine(b + " - " + a);
            }
            else
            {
                Console.WriteLine(a + " - " + b);
            }




        }
    }
}