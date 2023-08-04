using ClassLibraryLepidoptere.Stades;
using System.Security.Cryptography;

namespace CL_Lepidoptere
{
    public class Lepidoptere
    {
        private Stade stadeCourant;

        public Lepidoptere()
        {
            stadeCourant = new Oeuf();
        }


        public void SeDeplacer()
        {
            stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.stadeCourant = stadeCourant.SeMetamorphoser();
        }
    }
}