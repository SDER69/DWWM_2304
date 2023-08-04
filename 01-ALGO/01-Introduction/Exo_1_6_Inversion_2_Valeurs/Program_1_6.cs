namespace Exo_1_6_Inversion_2_Valeurs
{
    internal class Program_1_6
    {
        static void Main(string[] args)
        {
            int a,b,temp;
             

            Console.WriteLine("Veuillez entrer un premier nombre entier a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un premier nombre entier b : ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            

            Console.WriteLine("La nouvelle valeur de a est : " + a);
            Console.WriteLine("La nouvelle valeur de b est : " + b);
        }
    }
}