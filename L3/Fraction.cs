using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public class Fraction
    {      
        private int nominator, denominator, integer;

        public int Denominator 
        { 
            get => denominator; 
            set
            {
                if(value != 0)
                denominator = value;
                else throw new ArgumentException("Division by zero");
            }
        }

        public int Nominator { get => nominator;}
        public int Integer { get => integer;}

        public Fraction(int nominator, int denominator)
        {
            this.nominator = nominator;
            Denominator = denominator;
        }
        public Fraction(int integer, int nominator, int denominator)
        {
            this.nominator = integer * denominator + nominator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            int a = NOK(first.Denominator, second.Denominator);
            int m1 = first.Denominator / a;
            int m2 = second.Denominator / a;
            first.nominator *= m1;
            second.nominator *= m2;
            int newNominator = first.nominator + second.nominator;
            var newFraction = new Fraction(newNominator, a);
            newFraction.Reduction();
            return newFraction;
        }
        public static Fraction operator -(Fraction first, Fraction second)
        {
            int a = NOK(first.Denominator, second.Denominator);
            int m1 = first.Denominator / a;
            int m2 = second.Denominator / a;
            first.nominator *= m1;
            second.nominator *= m2;
            int newNominator = first.nominator - second.nominator;
            var newFraction = new Fraction(newNominator, a);
            newFraction.Reduction();
            return newFraction;
        }

        public static Fraction operator *(Fraction first, Fraction second)
        {
            int newNominator = first.nominator * second.nominator;
            int newDeominator = first.Denominator * second.Denominator;
            var newFraction = new Fraction(newNominator, newDeominator);
            newFraction.Reduction();
            return newFraction;
        }
        public static Fraction operator /(Fraction first, Fraction second)
        {
            int newNominator = first.nominator * second.Denominator;
            int newDeominator = first.Denominator * second.nominator;
            var newFraction = new Fraction(newNominator, newDeominator);
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
            int nod = NOD(nominator, Denominator);
            nominator = nominator / nod;
            Denominator = Denominator / nod;
            if (nominator < 0 && Denominator < 0)
            {
                nominator = Math.Abs(nominator);
                Denominator = Math.Abs(Denominator);
            }
            integer = nominator / denominator;
            nominator = nominator % denominator;
        }

        public static int Comparison(Fraction first, Fraction second)
        {
            int mode=10;
            int a = NOK(first.Denominator, second.Denominator);
            int m1 = first.Denominator / a;
            int m2 = second.Denominator / a;
            first.nominator *= m1;
            second.nominator *= m2;
            if (first.nominator > second.nominator) mode = 1;
            else if (first.nominator == second.nominator) mode = 0;
            else mode = 2;
            return mode;
        }

        public string Write()
        {
            return String.Format("{0} {1}", nominator, Denominator);
        }
    }
}
