namespace ClassLibraryVoiture.Composition
{
    public class Moteur
    {
        //Attributs
        private bool enMarche;

        //Getters et setters
        public bool EnMarche { get => enMarche; private set => enMarche = value; }

        //Constructeurs
        public Moteur()
        {
            this.enMarche = false;
        }
        public Moteur(bool enMarche)
        {
            this.enMarche = enMarche;
        }
        public Moteur(Moteur moteurACopier)
        {
            this.enMarche = moteurACopier.enMarche;
        }

        //Méthodes
        public bool Demarrer()
        {
            if (!enMarche)
            {
                enMarche = true;
                return true;
            }
            return false;
        }
        public bool Eteindre()
        {
            if (enMarche)
            {
                enMarche = false;
                return true;
            }
            return false;
        }

        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {
            if (enMarche)
            {
                bool ok1 = roue1.Tourner();
                bool ok2 = roue2.Tourner();
                if (ok1 && ok2)
                {
                    roue1.Tourner();
                    roue2.Tourner();   
                }
                return true;
            }
            else
            {
                roue1.Stopper();
                roue2.Stopper();
            }
            return false;
        }

        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            if (enMarche)
            {
                bool ok1 = roue1.Stopper();
                bool ok2 = roue2.Stopper();
                if (ok1 && ok2)
                {   
                    return true;
                }
            }
            else
            {
                roue1.Stopper();
                roue2.Stopper();

            }
            return false;

        }
    }
}
    

    
