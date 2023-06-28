namespace _03_Boucles
{
    internal class Program_3_1
    {
        static void Main(string[] args)
        {
            String nom;

            do
            {
                Console.WriteLine("Veuillez saisir votre prénom : ");
                nom = Console.ReadLine();

            }
            while (nom.Length < 2);

            Console.WriteLine("Bonjour " + nom);
        }

    }  
}