using CL_Bouteille;

namespace ProjetBouteille
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleEau = new Bouteille();
            Bouteille bouteilleSoda = new Bouteille(false, 1.5f, 0.5f, "soda");
            Bouteille bouteilleJus = new Bouteille(true,1f,0.5f,"jus");

            //bool ok1 = bouteilleSoda.Ouvrir();
            bool ok2 = bouteilleJus.Fermer();
            //Console.WriteLine("ouvrir : "+ok1);  
            //Console.WriteLine("fermer : "+ok2);
            

            Console.WriteLine("-------------------------------Tests des Méthodes Ouvrir() et Fermer()------------------------------------------------");
            
            //bouteilleEau = new Bouteille(true, 1.5f, 0f, "eau");
            //Console.WriteLine(bouteilleEau.ToString());
            bool ouvrir1 = bouteilleSoda.Ouvrir();
            //ouvrir1 = bouteilleSoda.Ouvrir();
            Console.WriteLine("Bouteille de soda ouverte (ouvrir1) :" + ouvrir1);//false
            Console.WriteLine("Est ouverte : " + bouteilleSoda.Ouverte);//true
            
            Console.WriteLine("Bouteille de soda ouverte (ouvrir1) :" + ouvrir1);
            Console.WriteLine("Est ouverte : " + bouteilleSoda.Ouverte);
            //bool fermer1 = bouteilleEau.Fermer();
            //Console.WriteLine("Bouteille de soda ouverte :"+ouvrir1);
            //Console.WriteLine("Bouteille de soda ouverte :" + ouvrir2);
            //Console.WriteLine("Bouteille d'eau fermée : "+fermer1);

            Console.WriteLine("------------------------------------------------------------------------------------");
            
            Bouteille b2 = new Bouteille(true, 2.5f, 1.5f, "soda");
            //bool ouvrir2 = b2.Ouvrir();
            //bool fermer2 = b2.Fermer();
            //Console.WriteLine("Bouteille de soda ouverte :" + ouvrir2);
            //Console.WriteLine("Bouteille de soda fermée : " + fermer2);

            Console.WriteLine("-------------------------------Tests des Méthodes Remplir() et Vider() une quantité déterminée------------------------------------------------");

            /*bool remplir1 = bouteilleEau.Remplir(0.6f);
            bool vider1 = bouteilleEau.Vider(0.3f);
            Console.WriteLine("Bouteille d'eau à remplir : " + remplir1.ToString());
            Console.WriteLine("Bouteille d'eau à vider : " + vider1.ToString());

            Console.WriteLine("-------------------------------Tests des Méthodes Remplir() et Vider()------------------------------------------------");
            bool remplir2 = bouteilleEau.Remplir();
            //bool vider2 = b2.Vider();
            Console.WriteLine("Bouteille d'eau à remplir totalement : " + remplir2);
            //Console.WriteLine("Bouteille d'eau à vider totalement : " + vider2);
            

           /* Console.WriteLine("---------------  Etats départ ------------------------------- ");

            Console.WriteLine(bouteilleEau.ToString());
            Console.WriteLine(bouteilleSoda.ToString());
            Console.WriteLine(bouteilleJus.ToString());

            bouteilleEau.Remplir(0.29f);
            bouteilleEau.Fermer();

            bouteilleSoda.Ouvrir();
            bouteilleSoda.Vider();

            bouteilleJus.Ouvrir();
            bouteilleJus.Vider(0.25f);

            Console.WriteLine("---------------  Etats après changement 1  ------------------------------- ");
            Console.WriteLine(bouteilleEau.ToString());
            Console.WriteLine(bouteilleSoda.ToString());
            Console.WriteLine(bouteilleJus.ToString());
           */
            Console.WriteLine("---------------  clonage bouteille bouteilleJus  ------------------------------- ");

            Bouteille bouteilleJus2 = new Bouteille(bouteilleJus);
            Bouteille bouteilleJus3 = new Bouteille(bouteilleJus);


            Console.WriteLine(" ---------------- Etats Bouteilles bouteilleJus -------------------------------------");

            /*Console.WriteLine(bouteilleJus.ToString());
            Console.WriteLine(bouteilleJus2.ToString());
            Console.WriteLine(bouteilleJus3.ToString());

            bouteilleJus.Vider();

            bouteilleJus2.Ouvrir();
            bouteilleJus2.Vider();

            bouteilleJus3.Ouvrir();
            bouteilleJus3.Vider();

            bouteilleJus.Fermer();
            bouteilleJus2.Fermer();
            bouteilleJus3.Fermer();
           
            Console.WriteLine(" ---------------- Nouveaux Etats Bouteilles bouteilleJus -------------------------------------");

            Console.WriteLine(bouteilleJus.ToString());
            Console.WriteLine(bouteilleJus2.ToString());
            Console.WriteLine(bouteilleJus3.ToString());
            */

            /*Bouteille videQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            videQuantite.Vider(0.25f);
            Console.WriteLine(videQuantite.ToString());
            */
        }
    }
}
