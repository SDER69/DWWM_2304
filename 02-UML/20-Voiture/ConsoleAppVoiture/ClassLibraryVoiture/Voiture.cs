using ClassLibraryVoiture.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        //Attributs
        private string marque;
        private List<Roue> ses4Roues;
        private Moteur sonMoteur;

        //Getters et setters
        public string Marque { get => marque; private set => marque = value; }
        public List<Roue> Ses4Roues { get => ses4Roues; private set => ses4Roues = value; }
        public Moteur SonMoteur { get => sonMoteur; private set => sonMoteur = value; }

        //Constructeurs
        public Voiture()
        : this("Peugeot", "205/55 R16 91V", false, false)
        {

        }
        /*{
            this.marque = "Peugeot";
            this.ses4Roues = new List<Roue>(Ses4Roues);
            this.sonMoteur = new Moteur();
        }*/
        public Voiture(string marque, List<Roue> ses4Roues, Moteur sonMoteur)
        {
            if (ses4Roues != null && ses4Roues.Count == 4)
            {
                this.marque = marque;
                this.ses4Roues = ses4Roues;
                this.sonMoteur = sonMoteur;
            }
            else
            {
                throw new Exception("Une voiture doit avoir 4 roues !");
            }
        }

        public Voiture(string marque, string dimensionPneu, bool tourne, bool enMarche)
        : this(marque,
             new List<Roue> {  new Roue(dimensionPneu,tourne),
                               new Roue(dimensionPneu,tourne),
                               new Roue(dimensionPneu,tourne),
                               new Roue(dimensionPneu,tourne)
                            },
             new Moteur(enMarche))
        {
        }

        public Voiture(Voiture voitureACopier)
        {
            this.marque = voitureACopier.marque;
            this.ses4Roues = new List<Roue>();
            this.ses4Roues.Add(new Roue(voitureACopier.ses4Roues[0]));
            this.ses4Roues.Add(new Roue(voitureACopier.ses4Roues[1]));
            this.ses4Roues.Add(new Roue(voitureACopier.ses4Roues[2]));
            this.ses4Roues.Add(new Roue(voitureACopier.ses4Roues[3]));

            this.sonMoteur = new Moteur(voitureACopier.sonMoteur);
        }
        

        //this.marque = voitureACopier.marque;
        //this.ses4Roues = voitureACopier.ses4Roues;
        //this.sonMoteur = voitureACopier.sonMoteur;

        //Méthodes

        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }

        public bool Avancer()
        {
            return sonMoteur.EntrainerRoues(ses4Roues[0], ses4Roues[1]);
        }

        public bool Freiner()
        {
            return sonMoteur.ArreterRoues(ses4Roues[0], ses4Roues[1]);
        }
    }
}

    
