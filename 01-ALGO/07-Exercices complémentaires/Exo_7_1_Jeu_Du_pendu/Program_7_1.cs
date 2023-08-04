using System.ComponentModel.Design;

namespace Exo_7_1_Jeu_Du_Pendu
{
    internal class Program_7_1
    {
        static void Main(string[] args)
        {
            string enteredWord;

            do
            {
                Console.WriteLine("Veuillez saisir un mot d'une longueur de 5 lettres minimum : ");
                enteredWord = Console.ReadLine();
            } while (enteredWord.Length < 5);

            enteredWord = enteredWord.ToLower();
            char[] chars = enteredWord.ToCharArray();// mot saisi sous forme d'un tableau de chars
            char[] modifiedWord = enteredWord.ToCharArray();

            Console.Clear();

            char replacement = '-';
            //Console.WriteLine(modifiedWord.GetType().Name);
            for (int i = 1; i < modifiedWord.Length - 1; i++)
            {
                modifiedWord[i] = replacement;
            }

            int maxTrials = 6;
            char proposedLetter;
            bool win = false;
            int counter = 0;

            do
            {
                Console.Write("Mot à  deviner : ");
                Console.WriteLine(modifiedWord);
                Console.WriteLine("Nombres d'essais restants : {0} ", maxTrials);
                Console.Write("Lettre proposée : ");
                proposedLetter = char.Parse(Console.ReadLine());
                proposedLetter = char.ToLower(proposedLetter);
                counter++;
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------");

                bool contain = enteredWord.Contains(proposedLetter);
                if (!contain)
                {
                    maxTrials--;
                    for (int i = 1; i < modifiedWord.Length - 1; i++)
                    {
                        if (modifiedWord[i] == 45)
                        {
                            win = false;
                            break;
                        }
                        else
                        {
                            win = true;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < enteredWord.Length - 1; i++)
                    {
                        if (enteredWord[i] == proposedLetter)
                        {
                            for (int j = 1; j < modifiedWord.Length - 1; j++)
                            {
                                modifiedWord[i] = proposedLetter;
                            }
                        }
                    }
                    if (Enumerable.SequenceEqual(chars, modifiedWord))
                    {
                        win = true;
                    }
                }
            } while (win == false && maxTrials > 0);

            if (win == true)
            {
                Console.WriteLine("Bravo, vous avez gagné la partie en {0} essais.", counter);
            }
            if (maxTrials == 0)
            {
                Console.WriteLine("Dommage, vous avez perdu la partie le mot à deviner était : '{0}' ", enteredWord);
            }
        }
    }
}













