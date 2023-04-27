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

            if (a>b)
            {
                Console.WriteLine("a = "+a+" b = "+b);
            }
            else
            {
                Console.WriteLine("b = " + b+ " a = " + a);
            }




        }
    }
}