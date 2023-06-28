using CL_Bouteille;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {   
        // Méthode Ouvrir()
        [TestMethod]
        public void TestMethod_Bouteille_Ouvrir_EtatFerme_ReturnTrue()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Ouvrir();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(bFerme.Ouverte == true);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Ouvrir_EtatOuvert_ReturnFalse()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Ouvrir();// true
            ok = bFerme.Ouvrir();// false
            Assert.IsTrue(ok == false);
            Assert.IsTrue(bFerme.Ouverte == true);
        }
        // Méthode Fermer()
        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatFerme_ReturnFalse()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Fermer();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(bFerme.Ouverte == false);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatOuvert_ReturnTrue()
        {
            Bouteille bFerme = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Fermer();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(bFerme.Ouverte == false);
        }
        // Méthode Vider (quantité determinée)
        [TestMethod]
        public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatOuvert_ReturnTrue()
        {
            Bouteille videQuantite = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsTrue(ok == true);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.25f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatFerme_ReturnFalse()
        {
            Bouteille videQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsTrue(ok == false);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.5f);
        }
        // Méthode Remplir (quantité determinée)
        [TestMethod]
        public void TestMethod_Bouteille_Remplir_Avec_Quantite_Determinee_EtatOuvert_ReturnTrue()
        {
            Bouteille rempliQuantite = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = rempliQuantite.Remplir(0.25f);
            Assert.IsTrue(ok == true);
            Assert.IsTrue(rempliQuantite.VolumeActuelEnLitres == 0.75f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Remplir_Avec_Quantite_Determinee_EtatFerme_ReturnFalse()
        {
            Bouteille rempliQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = rempliQuantite.Remplir(0.25f);
            Assert.IsTrue(ok == false);
            Assert.IsTrue(rempliQuantite.VolumeActuelEnLitres == 0.5f);
        }
        // Méthode Vider()
        [TestMethod]
        public void TestMethod_Bouteille_ViderTout_EtatOuvert_ReturnTrue()
        {
            Bouteille videTout = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = videTout.Vider();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(videTout.VolumeActuelEnLitres == 0f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_ViderTout_EtatFerme_ReturnFalse()
        {
            Bouteille videTout = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = videTout.Vider();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(videTout.VolumeActuelEnLitres == 0.5f);
        }
        // Méthode Remplir()
        [TestMethod]
        public void TestMethod_Bouteille_RemplirTout_EtatOuvert_ReturnTrue()
        {
            Bouteille rempliTout = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = rempliTout.Remplir();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(rempliTout.VolumeActuelEnLitres == 1.5f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_RemplirTout_EtatFerme_ReturnFalse()
        {
            Bouteille rempliTout = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = rempliTout.Remplir();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(rempliTout.VolumeActuelEnLitres == 0.5f);
        }
    }
}