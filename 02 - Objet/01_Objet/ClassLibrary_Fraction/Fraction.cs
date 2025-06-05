using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

namespace ClassLibrary_Fraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public Fraction(int numerateur, int denominateur)
        {
            try
            {
                if (this.denominateur == 0)
                {
                    throw new ArgumentException("Impossible de diviser par 0");
                }
                else
                {
                    this.numerateur = numerateur;
                    this.denominateur = denominateur; ;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public Fraction(int numerateur)
        {
            this.numerateur = numerateur;
            this.denominateur = 1;
        }

        public Fraction() : this(0, 1)
        {
        }

        public Fraction(Fraction f) : this(f.numerateur, f.denominateur)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} [numerateur: {this.numerateur}, denominateur:{this.denominateur}";
        }

        public string Display()
        {
            this.Reduire();
            if (this.numerateur == 0)
            {
                return "0";
            }
            else if (this.denominateur == 1)
            {
                return $"{this.numerateur}";
            }
            else
            {
                return $"{this.numerateur}/{this.denominateur}";
            }
        }

        public void Oppose()
        {
            this.numerateur = -this.numerateur;
        }

        public void Inverse()
        {
            try
            {
                if (this.numerateur == 0)
                {
                    throw new ArgumentException("Impossible d'inverser une fraction dont le numérateur est égale à 0");
                }
                else
                {
                    int temp = this.numerateur;
                    this.numerateur = this.denominateur;
                    this.denominateur = temp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool SuperieurA(Fraction fractionAComparer)
        {
            if ((this.numerateur / this.denominateur) > (fractionAComparer.numerateur / fractionAComparer.denominateur))
            {
                return true;
            }
            return false;
        }

        public bool EgalA(Fraction fractionAComparer)
        {
            if ((this.numerateur / this.denominateur) == (fractionAComparer.numerateur / fractionAComparer.denominateur))
            {
                return true;
            }
            return false;
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0)
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
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
            int pgcd = this.GetPgcd();
            this.numerateur = this.numerateur / pgcd;
            this.denominateur = this.denominateur / pgcd;
            if (this.numerateur < 0 && this.denominateur < 0 || this.numerateur > 0 && this.denominateur < 0)
            {
                this.numerateur = -this.numerateur;
                this.denominateur = -this.denominateur;
            }
        }

        public Fraction Plus(Fraction b)
        {
            int newNumerateur;
            int newDenominateur;
            newNumerateur = this.numerateur * b.denominateur + b.numerateur * this.denominateur;
            newDenominateur = this.denominateur * b.denominateur;
            return new Fraction(newNumerateur, newDenominateur);
        }

        public Fraction Moins(Fraction b)
        {
            int newNumerateur;
            int newDenominateur;
            newNumerateur = this.numerateur * b.denominateur - b.numerateur * this.denominateur;
            newDenominateur = this.denominateur * b.denominateur;
            return new Fraction(newNumerateur, newDenominateur);
        }

        public Fraction Multiplie(Fraction b)
        {
            int newNumerateur;
            int newDenominateur;
            newNumerateur = this.numerateur * b.numerateur;
            newDenominateur = this.denominateur * b.denominateur;
            return new Fraction(newNumerateur, newDenominateur);
        }

        public Fraction Divise(Fraction b)
        {
            if (this.numerateur == 0 || b.numerateur == 0)
            {
                return new Fraction();
            }
            else
            {
                Fraction c = new Fraction(b);
                c.Oppose();
                return this.Multiplie(c);
            }
        }
    }
}
