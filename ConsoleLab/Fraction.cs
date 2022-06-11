using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{

   public class Class<T1>
    {
        public T1 doll;

        public Class(T1 doll)
        {
            this.doll = doll;
        }

        public T1 foo()
        {
            Type type = typeof(T1);
            if(type.IsPrimitive && type.Name != "Boolean")
            {
                double doll2 = Convert.ToDouble(doll);
                doll2 *= 2;
            }
            return doll;
        }
    }

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

        public Fraction Add(int a)
        {
            return new Fraction(n + a * d, d);
        }

        public static Fraction operator +(Fraction f, int a)
        {
            return f.Add(a);
        }

        public static Fraction operator +(int a, Fraction f)
        {
            return f.Add(a);
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

        public double ShowDouble()
        {
            return n / d;
        }

        public override string ToString()
        {
            return n + "/" + d;
        }
    }
}
