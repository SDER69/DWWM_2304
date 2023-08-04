namespace Exo_4_2_Rechercher_Lettre_Dans_Phrase
{
    internal class Program_4_2
    {
        static void Main(string[] args)
        {
            String chaine = "Il fait beau aujourd'hui.";
            char lettreRecherchee = 'z';
            int cpt = 0;

            foreach (char c in chaine.ToLower())
            {
                if (c == lettreRecherchee)
                {
                    cpt++;
                }
            }

            if (chaine == "" || chaine == ".")
            {
                Console.WriteLine("La chaine est vide.");
            }
            else if (cpt == 0)
            {
                Console.WriteLine("La lettre n'est pas présente.");
            }

            else if (cpt > 0)
            {
                Console.WriteLine("La lettre est présente {0} fois.",cpt);
            }
           
        }
    }
}
