using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            /*txt4.Text = "0";
            txt1.Text = "0";*/
        }

         private Fraction Calculate()
         {
             Fraction answer = new Fraction(0,0,1);
             try
             {
                 int value1 = Decimal.ToInt32(num1.Value);
                 int value2 = Decimal.ToInt32(num2.Value);
                 int value3 = Decimal.ToInt32(num3.Value);
                 int value4 = Decimal.ToInt32(num4.Value);
                 int value5 = Decimal.ToInt32(num5.Value);
                 int value6 = Decimal.ToInt32(num6.Value);
                 Fraction fraction1 = new Fraction(0,0,1);
                 Fraction fraction2 = new Fraction(0, 0, 1);
                if (ch1.Checked)
                {
                    fraction1 = new Fraction(value1, value2 * (-1), value3);
                    fraction2 = new Fraction(value4, value5, value6);
                }
                else if (ch2.Checked)
                {
                    fraction1 = new Fraction(value1, value2, value3);
                    fraction2 = new Fraction(value4, value5 * (-1), value6);
                }
                else if(ch1.Checked && ch2.Checked)
                {
                    fraction1 = new Fraction(value1, value2 * (-1), value3);
                    fraction2 = new Fraction(value4, value5 * (-1), value6);
                }
                else
                {
                    fraction1 = new Fraction(value1, value2, value3);
                    fraction2 = new Fraction(value4, value5, value6);
                }
                 

                 switch (cmbOp.Text)
                 {
                     case "+":
                     answer = fraction1 + fraction2;
                     break;
                     case "-":
                         answer = fraction1 - fraction2;
                         break;
                     case "/":
                         answer = fraction1 / fraction2;
                         break;
                     case "*":
                         answer = fraction1 * fraction2;
                         break;
                 }

             }
             catch (FormatException)
             {

             }
             return answer;
         }

        private void NewArguments()
        {
            try
            {
                int value1 = Decimal.ToInt32(num1.Value);
                int value2 = Decimal.ToInt32(num2.Value);
                int value3 = Decimal.ToInt32(num3.Value);
                int value4 = Decimal.ToInt32(num4.Value);
                int value5 = Decimal.ToInt32(num5.Value);
                int value6 = Decimal.ToInt32(num6.Value);
                Fraction fraction1;
                Fraction fraction2;
                fraction1 = new Fraction(value1, value2, value3);
                fraction2 = new Fraction(value4, value5, value6);

                fraction1.Reduction();
                fraction2.Reduction();
                WriteNewArguments(fraction1, fraction2);
            }
            catch (FormatException)
            {

            }
        }

        private void WriteNewArguments(Fraction first, Fraction second)
        {
            num1.Value = first.Integer;
            num2.Value = first.Nominator;
            num3.Value = first.Denominator;
            num4.Value = second.Integer;
            num5.Value = second.Nominator;
            num6.Value = second.Denominator;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            NewArguments();
            Fraction fraction = Calculate();
            
            if (fraction.Nominator < 0 && fraction.Integer != 0)
            {
                answ1.Text = Convert.ToString(fraction.Integer);
                answ2.Text = Convert.ToString(fraction.Nominator * -1);
            }
            else if(fraction.Nominator < 0 && fraction.Integer == 0)
            {
                answ1.Text = "-";
                answ2.Text = Convert.ToString(fraction.Nominator * -1);
            }
            else
            {
                answ1.Text = Convert.ToString(fraction.Integer);
                answ2.Text = Convert.ToString(fraction.Nominator);
            }
            answ3.Text = Convert.ToString(fraction.Denominator);
        }
    }
}
