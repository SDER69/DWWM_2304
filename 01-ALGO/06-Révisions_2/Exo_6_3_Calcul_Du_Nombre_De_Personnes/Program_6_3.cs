namespace Exo_6_3_Calcul_Du_Nombre_De_Personnes
{
    internal class Program_6_3
    {
        static void Main(string[] args)
        {
            List<int> listOfValues = new List<int>();

            Console.WriteLine("Veuillez saisir les 20 valeurs pour le calcul du nombre de jeunes : ");

            do {
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine("Age {0} : ",i);
                    int valueRecovery = int.Parse(Console.ReadLine());
                    listOfValues.Add(valueRecovery);
                    //Console.WriteLine("Taille du tableau : " + listOfvalues.Count());
                }break;
            }while (listOfValues.Count() < 20);
            
            Console.WriteLine();

            List<int> listUnder20 = new List<int>();
            List<int> listEqual20 = new List<int>();
            List<int> listOver20 = new List<int>();
            
            for (int i=0; i < listOfValues.Count(); i++)
            {   
                if (listOfValues[i] < 20)
                {
                    listUnder20.Add(listOfValues[i]);
                    //Console.WriteLine(listOfValues[i]);
                }
                else if(listOfValues[i] == 20)
                {
                    listEqual20.Add(listOfValues[i]);
                }
                else
                {
                    listOver20.Add(listOfValues[i]);
                }
            }
            if (listUnder20.Count() == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
            }
            else if (listOver20.Count() == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
            }
            else
            {
                Console.Write("Liste des personnes de moins de 20 ans : ");
                foreach (int value in listUnder20)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
               
                Console.Write("Liste des personnes âgés de 20 ans : ");
                foreach (int value in listEqual20)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();

                Console.Write("Liste des personnes de plus de 20 ans : ");
                foreach (int value in listOver20)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}