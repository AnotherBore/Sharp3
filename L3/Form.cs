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
            txt4.Text = "0";
            txt1.Text = "0";
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
                Fraction fraction1;
                Fraction fraction2;
                fraction1 = new Fraction(value1, value2, value3);
                fraction2 = new Fraction(value4, value5, value6);

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
                var value1 = int.Parse(txt1.Text);
                var value2 = int.Parse(txt2.Text);
                var value3 = int.Parse(txt3.Text);
                var value4 = int.Parse(txt4.Text);
                var value5 = int.Parse(txt5.Text);
                var value6 = int.Parse(txt6.Text);
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
            txt4.Text = Convert.ToString(first.Integer);
            txt5.Text = Convert.ToString(first.Nominator);
            txt3.Text = Convert.ToString(first.Denominator);
            txt1.Text = Convert.ToString(second.Integer);
            txt2.Text = Convert.ToString(second.Nominator);
            txt6.Text = Convert.ToString(second.Denominator);
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            NewArguments();
            Fraction fraction = Calculate();
            answ1.Text = Convert.ToString(fraction.Integer);
            if (fraction.Nominator > 0)
            {
                answ2.Text = Convert.ToString(fraction.Nominator);
                answ3.Text = Convert.ToString(fraction.Denominator);
            }
        }
    }
}
