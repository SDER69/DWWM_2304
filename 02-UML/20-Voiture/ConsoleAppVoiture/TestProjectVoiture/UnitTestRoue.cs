using ClassLibraryVoiture.Composition;
using ClassLibraryVoiture;
using System.Security.Cryptography;

namespace TestProjectVoiture
{
    [TestClass]
    public class UnitTestRoue
    {
        //Tests Méthode Tourner()
        [TestMethod]
        public void TestMethod_Roue_Tourner_EtatArrete_ReturnTrue()
        {
            Roue rArrete = new Roue("205/55 R16 91V", false);
            bool ok = rArrete.Tourner();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(rArrete.Tourne == true);
        }

        [TestMethod]
        public void TestMethod_Roue_Tourner_EtatTourne_ReturnFalse()
        {
            Roue rArrete = new Roue("205/55 R16 91V", false);
            bool ok = rArrete.Tourner();// true
            ok = rArrete.Tourner();// false
            Assert.IsTrue(ok == false);
            Assert.IsTrue(rArrete.Tourne == true);
        }

        //Tests Méthode Stopper()
        [TestMethod]
        public void TestMethod_Roue_Stopper_EtatStope_ReturnFalse()
        {
            Roue rArrete = new Roue("205/55 R16 91V", false);
            bool ok = rArrete.Stopper();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(rArrete.Tourne == false);
        }

        [TestMethod]
        public void TestMethod_Roue_Tourner_EtatTourne_ReturnTrue()
        {
            Roue rArrete = new Roue("205/55 R16 91V", true);
            bool ok = rArrete.Stopper();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(rArrete.Tourne == false);
        }

        //Tests Méthode EntrainerRoues()
        [TestMethod]
        public void TestMethod_Roue_EntrainerRoues_EtatEnMarche_ReturnTrue()
        {
            Moteur mEnMarche = new Moteur(true);
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            bool ok = mEnMarche.EntrainerRoues(roue1, roue2);
            Assert.IsTrue(ok == true);
            Assert.IsTrue(mEnMarche.EnMarche == true);
            Assert.IsTrue(roue1.Tourne == true);
            Assert.IsTrue(roue2.Tourne == true);
        }
        [TestMethod]
        public void TestMethod_Roue_EntrainerRoues_EtatStoppe_ReturnFalse()
        {
            Moteur mEnMarche = new Moteur(false);
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            bool ok = mEnMarche.EntrainerRoues(roue1, roue2);
            Assert.IsTrue(ok == false);
            Assert.IsTrue(mEnMarche.EnMarche == false);
            Assert.IsTrue(roue1.Tourne == false);
            Assert.IsTrue(roue2.Tourne == false);

        }

        //Tests Méthode ArreterRoues()
        [TestMethod]
        public void TestMethod_Roue_ArreterRoues_EtatEnMarche_ReturnTrue()
        {
            Moteur mEnMarche = new Moteur(true);
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            bool ok = mEnMarche.ArreterRoues(roue1, roue2);
            Assert.IsTrue(ok == true);
            Assert.IsTrue(mEnMarche.EnMarche == true);
            Assert.IsTrue(roue1.Tourne == false);
            Assert.IsTrue(roue2.Tourne == false);
        }
        [TestMethod]
        public void TestMethod_Roue_ArreterRoues_EtatStoppe_ReturnFalse()
        {
            Moteur mEnMarche = new Moteur(false);
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            bool ok = mEnMarche.ArreterRoues(roue1, roue2);
            Assert.IsTrue(ok == false);
            Assert.IsTrue(mEnMarche.EnMarche == false);
            Assert.IsTrue(roue1.Tourne == false);
            Assert.IsTrue(roue2.Tourne == false);
        }
        //Tests Constructeur par copie
        [TestMethod]
        public void TestMethod_Constructeur_VoitureACopier()
        {
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            Roue roue3 = new Roue("205/55 R16 91V", true);
            Roue roue4 = new Roue("205/55 R16 91V", true);
            Moteur m = new Moteur(true);
            Voiture v1 = new Voiture("Peugeot", new List<Roue> { roue1, roue2, roue3, roue4 }, m);
            Voiture v2 = new Voiture(v1);
            int v1HashCode = v1.GetHashCode();
            int v2hashCode = v2.GetHashCode();
            Assert.IsFalse(v1HashCode.Equals(v2hashCode));
            /*Moteur mEnMarche = new Moteur(false);
            Roue roue1 = new Roue("205/55 R16 91V", true);
            Roue roue2 = new Roue("205/55 R16 91V", true);
            bool ok = mEnMarche.ArreterRoues(roue1, roue2);
            Assert.IsTrue(ok == false);
            Assert.IsTrue(mEnMarche.EnMarche == false);
            Assert.IsTrue(roue1.Tourne == false);
            Assert.IsTrue(roue2.Tourne == false);
            */
        }
        //Tests Méthode Démarrer()
        [TestMethod]
        public void TestMethod_Voiture_Demarrer_MoteurArrete_ReturnTrue()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", false, false);
            bool ok = v.Demarrer();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(v.SonMoteur.EnMarche == true);
        }

        [TestMethod]
        public void TestMethod_Voiture_Demarrer_MoteurDemarre_ReturnFalse()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", true, true);
            bool ok = v.Demarrer();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(v.SonMoteur.EnMarche == true);
        }
        //Tests Méthode Avancer()
        [TestMethod]
        public void TestMethod_Voiture_Avancer_MoteurEnMarche_ReturnTrue()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", true, true);
            bool ok = v.Avancer();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(v.SonMoteur.EnMarche == true);
        }

        [TestMethod]
        public void TestMethod_Voiture_Avancer_MoteurArrete_ReturnFalse()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", false, false);
            bool ok = v.Avancer();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(v.SonMoteur.EnMarche == false);
        }

        // Tests Méthode Freiner
        [TestMethod]
        public void TestMethod_Voiture_Freiner_MoteurEnMarche_ReturnTrue()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", true, true);
            bool ok = v.Freiner();
            Assert.IsTrue(ok == true);
            Assert.IsTrue(v.SonMoteur.EnMarche == true);
        }

        [TestMethod]
        public void TestMethod_Voiture_Freiner_MoteurArrete_ReturnFalse()
        {
            Voiture v = new Voiture("Peugeot", "205/55 R16 91V", false, false);
            bool ok = v.Freiner();
            Assert.IsTrue(ok == false);
            Assert.IsTrue(v.SonMoteur.EnMarche == false);
        }
    }
}

