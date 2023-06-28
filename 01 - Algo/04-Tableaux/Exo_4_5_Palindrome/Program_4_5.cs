using System.ComponentModel.Design;

namespace Exo_4_5_Palindrome
{
    internal class Program_4_5
    {
        static void Main(string[] args)
        {

            String saisie;
            String phraseInversee = "";



            Console.WriteLine("Veuillez saisir une phrase ou un mot ponctué par un point : ");
            saisie = Console.ReadLine();

            {
                do
                {


                    if (saisie.Length == 0 || saisie == ".")
                    {
                        Console.WriteLine("La phrase est vide");
                        Console.WriteLine("Veuillez saisir une phrase ou un mot ponctué par un point : ");
                        saisie = Console.ReadLine();
                    }
                    else if (saisie[saisie.Length - 1] != '.')
                    {
                        Console.WriteLine("Veuillez saisir une phrase ou un mot ponctué par un point : ");
                        saisie = Console.ReadLine();
                    }
                } while (saisie.Length == 0 || saisie == "." || saisie[saisie.Length - 1] != '.');

                saisie = saisie.ToLower().Replace(".", "").Replace(" ", "");
                //Console.WriteLine("Saisie : {0} " + saisie);
                for (int i = saisie.Length - 1; i >= 0; i--)
                {
                    phraseInversee += saisie[i];
                }
                phraseInversee = phraseInversee.Replace(" ", "");
                //Console.WriteLine("Phrase inversee : {0} ",phraseInversee);


                if (saisie == phraseInversee)
                {
                    Console.WriteLine("La chaîne de caractères est un palindrome");
                }
                else
                {
                    Console.WriteLine("La chaîne de caractères n'est pas un palindrome");
                }

            }


        }
    }
}

