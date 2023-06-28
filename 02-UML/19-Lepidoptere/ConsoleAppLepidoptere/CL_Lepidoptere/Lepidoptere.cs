using CL_Stade;
using System.Security.Cryptography;

namespace CL_Lepidoptere
{
    public class Lepidoptere
    {   
        //Attribut
        private Stade stadeCourant;

        //Constructeur
        public Lepidoptere()
        {
            this.stadeCourant = new Oeuf();
        }
        
        //Méthodes
        public void SeDeplacer()
        {
            this.stadeCourant = stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.stadeCourant = stadeCourant.SeMetamorphoser();
        }
    }
}