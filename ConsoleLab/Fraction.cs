using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    internal class Fraction
    {
        public int n { get; set; }
        public int d { get; set; }

        public Fraction(int n, int d)
        {
            this.n = n;
            this.d = d;
        }

        public Fraction Mul(Fraction f)
        {
            return new Fraction(this.n * f.n, this.d * f.d);
        }

        public static Fraction operator *(Fraction f, Fraction c)
        {
            return new Fraction(c.n * f.n, c.d * f.d);
        }

        public static bool operator >(Fraction f, Fraction c)
        {
            if (f.n > c.n) return true;
            else return false;
        }

        public static bool operator <(Fraction f, Fraction c)
        {
            if (f.n < c.n) return true;
            else return false;
        }
    }
}
