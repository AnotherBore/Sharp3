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
        }

        private Fraction Calculate()
        {
            Fraction answer = new Fraction(0,0,1);
            try
            {
                var value1 = int.Parse(txt1.Text);
                var value2 = int.Parse(txt2.Text);
                var value3 = int.Parse(txt3.Text);
                var value4 = int.Parse(txt4.Text);
                var value5 = int.Parse(txt5.Text);
                var value6 = int.Parse(txt6.Text);
                var fraction1 = new Fraction(value1, value2, value3);
                var fraction2 = new Fraction(value4, value5, value6);
                
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

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            answ2.Text = Convert.ToString(fraction.Nominator);
            answ3.Text = Convert.ToString(fraction.Denominator);
        }
    }
}
