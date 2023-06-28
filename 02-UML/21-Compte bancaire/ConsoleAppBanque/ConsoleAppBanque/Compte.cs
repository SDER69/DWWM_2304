using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanque
{
    internal class Compte
    {
        // Attributs
        private double decouvertAutorise;
        private string nom;
        private int numero;
        private double solde;

        // Constructeurs
        public Compte()
        {
        }

        public Compte(int numero, string nom, double solde,double decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }

        // Méthodes
        public void Crediter(double montant)
        {
            solde += montant;
        }

        public bool Debiter(double montant)
        {
            if(solde-montant >= decouvertAutorise)
            {
                solde -= montant;
                return true;
            }
            return false;
        }
        
        public bool Transferer(double montant,Compte _compteDestinataire)
        {
            if (Debiter(montant))
            {
                _compteDestinataire.Crediter(montant);
            }
            return false;
        }
          
        public bool Superieur(Compte _autreCompte)
        {
            if(solde > _autreCompte.solde)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"numéro : {numero} nom : {nom} solde : {solde} découvert autorisé : {decouvertAutorise}";
        }
        
    }
}

