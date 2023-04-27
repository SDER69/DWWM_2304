namespace Exo_1_5_Calcul_Surface_Secteur_Circulaire
{
    internal class Program_1_5
    {
        static void Main(string[] args)
        {
            double rayonCercle;
            double angleCercle;
            double aireSecteurCirculaire;

            Console.WriteLine("Veuillez saisir le rayon du cercle : ");
            rayonCercle = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'angle du cercle : ");
            angleCercle = double.Parse(Console.ReadLine());

            aireSecteurCirculaire = (Math.PI *  Math.Pow(rayonCercle,2) * angleCercle) / 360;
            

            Console.WriteLine("L'aire du secteur circulaire : " + aireSecteurCirculaire.ToString("#.##"));
            
        }
    }
}