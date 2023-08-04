namespace Exo_6_4_Denombrer_Lettres_Alphabet
{
    internal class Program_6_4
    {
        static void Main(string[] args)
        {
            string enteredSentence;
            int counterCharacters;

            do
            {
                Console.WriteLine("Veuillez entrer un texte d'au moins 100 caractères : ");
                enteredSentence = Console.ReadLine();
                counterCharacters = enteredSentence.Length;
                Console.WriteLine("Nombre de caractères : {0} ", counterCharacters);
            } while (enteredSentence.Length < 100);

            // TRAITEMENT DES LETTRES
            enteredSentence = enteredSentence.ToLower();
            const string consonants = "bcdfghjklmnpqrstvwxz";
            const string vowels = "aeiouy";
            int counterConsonants = 0;
            int counterVowels = 0;

            for (int i = 0; i < enteredSentence.Length; i++)
            {
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (enteredSentence[i] == consonants[j])
                    {
                        counterConsonants++;
                    }
                }
                for (int k = 0; k < vowels.Length; k++)
                {
                    if (enteredSentence[i] == vowels[k])
                    {
                        counterVowels++;
                    }
                }
            }
            Console.WriteLine("Nombre de consonnes : {0} ", counterConsonants);
            Console.WriteLine("Nombre de voyelles : {0} ", counterVowels);

            // TRAITEMENT DES CHIFFRES
            string numbers = "0123456789";
            int counterNumbers = 0;
            List<int> extractedNumbers = new List<int>();
            int extractOneNumber;

            for (int i = 0; i < enteredSentence.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (enteredSentence[i] == numbers[j])
                    {   
                         extractOneNumber = int.Parse(enteredSentence[i].ToString());
                         extractedNumbers.Add(extractOneNumber);
                         counterNumbers++;
                    }
                }
            }
            Console.WriteLine("Nombre de chiffres : {0} ", counterNumbers);
            if(counterNumbers == 0)
            {
                Console.WriteLine("Aucun chiffre saisi.");
                Console.WriteLine("La moyenne des chiffres est égale à : {0} ", counterNumbers);
            }
            else
            {
                double sum = extractedNumbers.Sum();
                double total = extractedNumbers.Count();
                double average = sum / total;
                average = Math.Round(average, 2);
                Console.WriteLine("La moyenne des chiffres est égale à : {0} ", average);
            }
        }
    }
}
