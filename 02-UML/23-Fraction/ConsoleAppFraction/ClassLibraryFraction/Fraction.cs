using System.Runtime.CompilerServices;

namespace ClassLibraryFraction
{
    public class Fraction
    {
        //Attributs
        private int numerateur;
        private int denominateur;

        //Constructeurs
        public Fraction()
        : this(0, 1)
        {
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public Fraction(int _numerateur)
        : this(_numerateur, 1)
        {
            //this.numerateur= _numerateur;
            //this.denominateur = 1;
        }

        public Fraction(Fraction _fraction)
        : this(_fraction.numerateur, _fraction.denominateur)
        {
        }

        //Méthodes
        public override string ToString()
        {
            return $"{numerateur}/{denominateur}";
        }

        public void Oppose()
        {
            this.numerateur = this.numerateur * (-1);
        }

        public void Inverse()
        {
            int temp = 0;
            temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }

        private float Evaluer()
        {
            float result = (float)this.numerateur / this.denominateur;
            return result;
        }

        public bool SuperieurA(Fraction f)
        {
            if (this.Evaluer() > f.Evaluer())
            {
                return true;
            }
            return false;
        }

        public bool EgalA(Fraction f)
        {
            if (this.Evaluer() == f.Evaluer())
            {
                return true;
            }
            return false;
            /*if ((float)f.numerateur / f.denominateur == (float)this.numerateur / this.denominateur)
          {
              return true;
          }
          return false;
          */
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
        
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                   
                while (a != b)
                {
                    if (a < b)
                    {
                           b = b - a;
                        }
                        else
                        {
                           a = a - b;
                        }
                }
            pgcd = a;
            }
            return pgcd;
        }

        private void Reduire()
        {   
            int pgcd = GetPgcd();
            this.numerateur = this.numerateur / pgcd;
            this.denominateur = this.denominateur / pgcd;

            if (denominateur < 0)
            {
                this.numerateur = -this.numerateur;
                this.denominateur =  -this.denominateur;
            }
        }

        public Fraction Plus(Fraction _autreFraction)
        {
            int numerateur1 = this.numerateur * _autreFraction.denominateur;
            int numerateur2 = _autreFraction.numerateur * this.denominateur;
            int denominateurCommun = this.denominateur * _autreFraction.denominateur;
            int sommeNumerateurs = numerateur1 + numerateur2;
            Fraction f= new Fraction(sommeNumerateurs,denominateurCommun);
            f.Reduire();
            return f;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return a.Plus(b);
        }


        public Fraction Moins(Fraction _autreFraction)
        {
            int numerateur1 = this.numerateur * _autreFraction.denominateur;
            int numerateur2 = _autreFraction.numerateur * this.denominateur;
            int denominateurCommun = this.denominateur * _autreFraction.denominateur;
            int differenceNumerateurs = numerateur1 - numerateur2;
            Fraction f = new Fraction(differenceNumerateurs, denominateurCommun);
            f.Reduire();
            return f;
        }

        public Fraction Multiplie(Fraction _autreFraction)
        {
            int numerateur = this.numerateur * _autreFraction.numerateur;
            int denominateur = _autreFraction.denominateur * this.denominateur;
            Fraction f = new Fraction(numerateur, denominateur);
            f.Reduire();
            return f;
        }

        public Fraction Divise(Fraction _autreFraction)
        {
            //_autreFraction.Inverse();
            
            //int numerateur = this.numerateur * _autreFraction.denominateur;
            //int denominateur = _autreFraction.numerateur * this.denominateur;
            Fraction f = new Fraction(_autreFraction);
            f.Inverse();
            return Multiplie(f);
        }





    }
}


