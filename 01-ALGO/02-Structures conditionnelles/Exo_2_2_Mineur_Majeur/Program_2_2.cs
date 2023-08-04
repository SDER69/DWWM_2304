namespace Exo_2_2_Mineur_Majeur
{
    internal class Program_2_2
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Veuillez entrer un âge : ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }
    }
}
