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
            if(integer < 0)
            {
                this.nominator = -1 * (Math.Abs(integer) * denominator + nominator);
            }
            else
            {
                this.nominator = integer * denominator + nominator;
            }
            Denominator = denominator;
            this.integer = 0;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            int a = NOK(first.Denominator, second.Denominator);
            int m1 = a / first.Denominator;
            int m2 = a / second.Denominator;
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
            int m1 = a / first.Denominator;
            int m2 = a / second.Denominator;
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
            int newNominator;
            int newDenominator;
            if (first.Nominator < 0 || second.Nominator < 0)
            {
                newDenominator = first.Denominator * Math.Abs(second.nominator);
                if (second.Nominator < 0 && first.Nominator < 0)
                {
                    newNominator = -1 * first.nominator * second.Denominator;
                }
                else
                {
                    newNominator = -1 * Math.Abs(first.nominator * second.Denominator);
                }               
            }
            else
            {
                newNominator = first.nominator * second.Denominator;
                newDenominator = first.Denominator * second.nominator;
            }
            var newFraction = new Fraction(newNominator, newDenominator);
            newFraction.Reduction();
            return newFraction;
        }
        private static int NOK(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            int c;
            c = a / NOD(a,b) * b;
            return c;
        }
        private static int NOD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
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
            integer = nominator / denominator;
            nominator = nominator % denominator;
        }

        public static int Comparison(Fraction first, Fraction second)
        {
            int mode=10;
            int a = NOK(first.Denominator, second.Denominator);
            int m1 = a /first.Denominator;
            int m2 = a /second.Denominator;
            first.nominator *= m1;
            second.nominator *= m2;
            if (first.Nominator > second.Nominator) mode = 1;
            else if (first.Nominator == second.Nominator) mode = 0;
            else mode = 2;
            return mode;
        }

        public string Write()
        {
            return String.Format("{0} {1} {2}",integer, nominator, Denominator);
        }
    }
}
