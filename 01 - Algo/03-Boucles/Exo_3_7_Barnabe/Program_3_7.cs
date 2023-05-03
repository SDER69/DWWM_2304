namespace Exo_3_7_Barnabe
{
    internal class Program_3_7
    {
        static void Main(string[] args)
        {
            double sommeDepart;
            double sommeRestante;
            double sommeDepensee;
            int nbMagasins = 0;


            Console.WriteLine("Veuillez entrer une somme de départ : ");
            sommeDepart = int.Parse(Console.ReadLine());
            

            do
            {
                sommeDepensee = (sommeDepart / 2) + 1;
                sommeRestante = sommeDepart - sommeDepensee;
                sommeDepart = sommeRestante;
                
                nbMagasins += 1;

            }
            while (sommeRestante > 1);

            nbMagasins = (sommeRestante == 1) ? nbMagasins += 1 : nbMagasins;
              
            Console.WriteLine("Barnabé a visité "+nbMagasins+" magasins"); 
            
            

            
        }
    }
}