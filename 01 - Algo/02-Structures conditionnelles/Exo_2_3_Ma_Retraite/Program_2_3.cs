namespace Exo_2_3_Ma_Retraite
{
    internal class Program_2_3
    {
        static void Main(string[] args)
        {
            int age, nbAnnees;

            Console.WriteLine("Veuillez entrer un âge : ");
            age = int.Parse(Console.ReadLine());

            if (age <= 0 || age > 150)
            {
                Console.WriteLine("La valeur fournie n'est pas un âge valide");
            }
            else if (age < 60)
            {
                nbAnnees = 60 - age;
                Console.WriteLine("Il vous reste " + nbAnnees + " années avant la retraite.");
            }
            else if (age == 60)
            {
                Console.WriteLine("C'est le moment de prendre sa retraite.");
            }
            else if (age > 60)
            {
                nbAnnees = age - 60;
                Console.WriteLine("Vous êtes à la retraite depuis " + nbAnnees + " années.");
            }
           }
         }
       }
    
