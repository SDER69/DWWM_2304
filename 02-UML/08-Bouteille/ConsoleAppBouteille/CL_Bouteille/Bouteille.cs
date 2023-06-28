using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CL_Bouteille
{
    public class Bouteille
    {   
        // Attributs
        private bool ouverte;
        private float volumeMaxEnLitres;
        private float volumeActuelEnLitres;
        private string nomDuContenu;

        // Getters et setters
        public bool Ouverte { get => ouverte; private set => ouverte = value; }
        public float VolumeMaxEnLitres { get => volumeMaxEnLitres; private set => volumeMaxEnLitres = value; }
        public float VolumeActuelEnLitres { get => volumeActuelEnLitres; private set => volumeActuelEnLitres = value; }
        public string NomDuContenu {  get => nomDuContenu; private set => nomDuContenu = value; }   
        
        

        // Constructeurs
        public Bouteille()
            :this(false,2,1,"eau")
        {
            //this.ouverte = true;
            //this.volumeMaxEnLitres = 2;
            //this.volumeActuelEnLitres = 1;
            //this.nomDuContenu = "eau";
        }

        public Bouteille(bool ouverte, float volumeMaxEnLitres, float volumeActuelEnLitres, string nomDuContenu)
        {
            this.ouverte = ouverte;
            this.volumeMaxEnLitres = volumeMaxEnLitres;
            this.volumeActuelEnLitres = volumeActuelEnLitres;
            this.nomDuContenu = nomDuContenu;
        }

        public Bouteille(Bouteille bouteilleACopier)
            :this(bouteilleACopier.ouverte,bouteilleACopier.VolumeMaxEnLitres,bouteilleACopier.VolumeActuelEnLitres,bouteilleACopier.nomDuContenu)
        {   
            /*
            this.ouverte = bouteilleACopier.ouverte;
            this.volumeMaxEnLitres = bouteilleACopier.volumeMaxEnLitres;
            this.volumeActuelEnLitres = bouteilleACopier.volumeActuelEnLitres;
            this.nomDuContenu= bouteilleACopier.nomDuContenu;
            */
        }

        // Méthodes
        public bool Ouvrir()
        {   if (!ouverte) 
            {
                ouverte = true;
                return true;
            }
            return false;
        }

        public bool Fermer()
        {   
            if (ouverte)        
            {
               ouverte=false;
               return true;
            }
            return false;
        }

        public bool Vider(float volumeAViderEnLitres)
        {
            if (ouverte && volumeAViderEnLitres <= volumeActuelEnLitres && volumeAViderEnLitres < volumeMaxEnLitres && volumeAViderEnLitres > 0)
            {
                volumeActuelEnLitres -= volumeAViderEnLitres;
                return true;
            }
            return false;        
        }

        public bool Remplir(float volumeARemplirEnLitres)
        {
            if (ouverte && volumeARemplirEnLitres <= volumeMaxEnLitres && volumeARemplirEnLitres > 0 && volumeARemplirEnLitres <= volumeMaxEnLitres-volumeActuelEnLitres)
            {
                volumeActuelEnLitres += volumeARemplirEnLitres;
                return true;
            }
            return false;
        }

        public bool Vider()
        {
            if(ouverte && volumeActuelEnLitres > 0 && volumeActuelEnLitres <= volumeMaxEnLitres)
            {
                volumeActuelEnLitres -= volumeActuelEnLitres;
                return true;
            }
            return false;
        }

        public bool Remplir()
        {
            if (ouverte && volumeActuelEnLitres >= 0 && volumeActuelEnLitres < volumeMaxEnLitres)
            {
                volumeActuelEnLitres += volumeMaxEnLitres - volumeActuelEnLitres;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "------------------------------------------ \n\r" +
                   "Contenu bouteille : " + this.nomDuContenu + "\n\r" +
                   "Est ouverte ? " + this.ouverte + "\n\r" +
                   "Volume max en litres : " + this.volumeMaxEnLitres + "\n\r" +
                   "Volume actuel en litres : " + this.volumeActuelEnLitres + "\n\r";
        }

        public override bool Equals(object? obj)
        {
            return obj is Bouteille bouteille &&
                   ouverte == bouteille.ouverte &&
                   volumeMaxEnLitres == bouteille.volumeMaxEnLitres &&
                   volumeActuelEnLitres == bouteille.volumeActuelEnLitres &&
                   nomDuContenu == bouteille.nomDuContenu &&
                   Ouverte == bouteille.Ouverte &&
                   VolumeMaxEnLitres == bouteille.VolumeMaxEnLitres &&
                   VolumeActuelEnLitres == bouteille.VolumeActuelEnLitres &&
                   NomDuContenu == bouteille.NomDuContenu;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ouverte, volumeMaxEnLitres, volumeActuelEnLitres, nomDuContenu, Ouverte, VolumeMaxEnLitres, VolumeActuelEnLitres, NomDuContenu);
        }
    
    }
}




