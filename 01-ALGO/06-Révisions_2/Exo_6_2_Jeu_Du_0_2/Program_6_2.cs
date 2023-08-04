using System.Security.Cryptography;

namespace Exo_6_2_Jeu_Du_0_2
{
    internal class Program_6_2
    {
        static void Main(string[] args)
        {
            int nbJoueur;
            int nbOrdi;
            int compteurJoueur = 0;
            int compteurOrdi = 0;
            int nbMax = 10;

            do
            {
                do
                {
                    Console.WriteLine("JOUEUR 1 : Veuillez introduire un nombre parmi ces 3 valeurs : 0,1 ou 2 ou un nombre négatif pour quitter le jeu : ");
                    nbJoueur = int.Parse(Console.ReadLine());
                    //Console.WriteLine(nbJoueur.GetType().Name);
                    if (nbJoueur < 0)
                    {
                        Console.WriteLine("Merci de votre visite, à bientôt.");
                        Environment.Exit(0);
                    }
                }while (nbJoueur < 0 || nbJoueur > 2);

               
                Console.WriteLine("ORDINATEUR : Veuillez introduire un nombre parmi ces 3 valeurs : 0,1 ou 2 : ");
                nbOrdi = new Random().Next(0, 3);
                Console.WriteLine(nbOrdi);
                //Console.WriteLine(nbOrdi.GetType().Name);

                int diff = Math.Abs(nbJoueur - nbOrdi);
                //Console.WriteLine("diff : {0} ",diff);

                  switch (diff)
                  {
                    case 2:
                        if (nbJoueur > nbOrdi)
                        {
                            compteurJoueur++;
                            Console.WriteLine("Vous venez de marquer 1 point.");
                            Console.WriteLine("Points marqués par vous-même : {0}",compteurJoueur);
                            Console.WriteLine("Points marqués par l'ordinateur : {0}",compteurOrdi);
                        }
                        else
                        {
                            compteurOrdi++;
                            Console.WriteLine("L'ordinateur vient de marquer 1 point.");
                            Console.WriteLine("Points marqués par vous-même : {0}", compteurJoueur);
                            Console.WriteLine("Points marqués par l'ordinateur : {0}", compteurOrdi);
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        break;
                    case 1:
                        if (nbJoueur < nbOrdi)
                        {
                            compteurJoueur++;
                            Console.WriteLine("Vous venez de marquer 1 point.");
                            Console.WriteLine("Points marqués par vous-même : {0}", compteurJoueur);
                            Console.WriteLine("Points marqués par l'ordinateur : {0}", compteurOrdi);
                        }
                        else
                        {
                            compteurOrdi++;
                            Console.WriteLine("L'ordinateur vient de marquer 1 point.");
                            Console.WriteLine("Points marqués par vous-même : {0}", compteurJoueur);
                            Console.WriteLine("Points marqués par l'ordinateur : {0}", compteurOrdi);
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        break;
                    case 0:
                        if (nbJoueur == nbOrdi)
                        {
                            Console.WriteLine("Egalité, aucun point marqué.");
                            Console.WriteLine("Points marqués par vous-même : {0}", compteurJoueur);
                            Console.WriteLine("Points marqués par l'ordinateur : {0}", compteurOrdi);
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        break;
                  } 
            }while(compteurJoueur < nbMax && compteurOrdi < nbMax);
            //while(compteurJoueur != nbMax && compteurOrdi != nbMax || nbJoueur < 0);--> signe différent
            if (compteurJoueur == 10)
            {
                Console.WriteLine("Bravo, vous avez gagné la partie.");
            }
            else
            {
               Console.WriteLine("L'ordinateur a gagné");
            }
        }
    }
}
