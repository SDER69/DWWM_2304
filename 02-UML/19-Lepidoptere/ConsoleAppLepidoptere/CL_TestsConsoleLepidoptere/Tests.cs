using CL_Lepidoptere;

using ClassLibraryLepidoptere.Stades;

namespace CL_TestsConsoleLepidoptere
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            Lepidoptere p;
            p= new Lepidoptere();
            p.SeDeplacer();
            p.SeMetamorphoser();
            
        }
    }
}