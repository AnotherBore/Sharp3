using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public class Fraction
    {      
        private int nominator, denominator;

        public Fraction(int nominator, int denominator)
        {
            this.nominator = nominator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            int a = NOK(first.denominator, second.denominator);
            int m1 = first.denominator / a;
            int m2 = second.denominator / a;
            first.nominator *= m1;
            second.nominator *= m2;
            int newNominator = first.nominator + second.nominator;
            var newFraction = new Fraction(newNominator, a);
            newFraction.Reduction();
            return newFraction;
        }
        private static int NOK(int a, int b)
        {
            int c;
            c = a / NOD(a,b) * b;
            return c;
        }
        private static int NOD(int a, int b)
        {

            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return (a + b);
        }
        public void Reduction()
        {
            int nod = NOD(nominator, denominator);
            nominator = nominator / nod;
            denominator = denominator / nod;
        }

        public string Write()
        {
            return String.Format("{0} {1}", nominator, denominator);
        }
    }
}
