using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibraryPoint
{
    public class Point
    {
        // Attributs
        private float x;
        private float y;

        // Constructeurs
        public Point()
        : this(0, 0)
        {
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point (Point _point)
        :this(_point.x,_point.y)
        {
            //this.x = _point.x;
            //this.y = _point.y;
        }

        // Méthodes
        public void Deplacer(float _nouveauX,float _nouveauY)
        {
            this.x = _nouveauX;
            this.y = _nouveauY;
        }

        public void Permuter()
        {
            float temp = this.x;
            this.x = this.y;
            this.y = temp;
        }
        
        public Point SymetrieAxeAbscisse()
        {
            return new Point(this.x, this.y * (-1));
        }

        public Point SymetrieAxeOrdonnee()
        {
            return new Point(this.x*(-1),this.y);
        }

        public Point SymetrieOrigine()
        {
            
            return this.SymetrieAxeOrdonnee().SymetrieAxeAbscisse();
          
           //return new Point(this.x*(-1),this.y*(-1)); 
        }
        

        public override string ToString()
        {
            return $"Point x : {x} \n" +
                   $"Point y : {y}";
        }

    }    
}



