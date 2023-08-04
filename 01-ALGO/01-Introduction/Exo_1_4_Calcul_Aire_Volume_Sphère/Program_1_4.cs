namespace Exo_1_4_Calcul_Aire_Volume_Sphère
{
    internal class Program_1_4
    {
        static void Main(string[] args)
        {
            double rayonSphere;
            double aire;
            double volume;

            Console.WriteLine("Veuillez saisir le rayon de la sphère : ");
            rayonSphere = double.Parse(Console.ReadLine());

            aire = 4 * Math.PI * Math.Pow(rayonSphere,2);
            volume = (4 * Math.PI * Math.Pow(rayonSphere,3)) / 3;

            Console.WriteLine("L'aire du rayon de la sphère saisi est : "+aire.ToString("#.##"));
            Console.WriteLine("Le volume du rayon de la sphère saisi est : " + volume.ToString("#.##"));
        }
    }
}