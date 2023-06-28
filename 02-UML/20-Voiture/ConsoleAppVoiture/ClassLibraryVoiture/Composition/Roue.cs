using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture.Composition
{
    public class Roue
    {
        //Attributs
        private string dimensionPneu;
        private bool tourne;

        //Getters et setters
        public string DimensionPneu { get => dimensionPneu; private set => dimensionPneu = value; }
        public bool Tourne { get => tourne; private set => tourne = value; }

        //Constructeurs
        public Roue()
        {
            this.dimensionPneu = "205/55 R16 91V";
            this.tourne = false;
        }
        public Roue(string dimensionPneu, bool tourne)
        {
            this.dimensionPneu = dimensionPneu;
            this.tourne = tourne;
        }
        public Roue(Roue roueACopier)
        {
            this.dimensionPneu = roueACopier.dimensionPneu;
            this.tourne = roueACopier.tourne;
        }
        //Méthodes
        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }
        public bool Stopper()
        {
           if(tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }
    }
}
   
