using System;
using System.Windows.Forms;

namespace L3
{
    public partial class Form : System.Windows.Forms.Form
    {
        Fraction fraction1 = new Fraction(0, 0, 1);
        Fraction fraction2 = new Fraction(0, 0, 1);
        public Form()
        {
            InitializeComponent();
        }

        private void ReadValues()
        {
            try
            {
                int value1 = Decimal.ToInt32(num1.Value);
                int value2 = Decimal.ToInt32(num2.Value);
                int value3 = Decimal.ToInt32(num3.Value);
                int value4 = Decimal.ToInt32(num4.Value);
                int value5 = Decimal.ToInt32(num5.Value);
                int value6 = Decimal.ToInt32(num6.Value);
                if (ch1.Checked && ch2.Checked)
                {
                    fraction1 = new Fraction(value1 * (-1), value2, value3);
                    fraction2 = new Fraction(value4 * (-1), value5, value6);
                }
                else if (ch1.Checked)
                {
                    fraction1 = new Fraction(value1 * (-1), value2,  value3);
                    fraction2 = new Fraction(value4, value5, value6);
                }
                else if (ch2.Checked)
                {
                    fraction1 = new Fraction(value1, value2, value3);
                    fraction2 = new Fraction(value4 * (-1), value5, value6);
                }

                else
                {
                    fraction1 = new Fraction(value1, value2, value3);
                    fraction2 = new Fraction(value4, value5, value6);
                }
            }
            catch (FormatException)
            {

            }
        }

        private Fraction Calculate()
        {
            ReadValues();
            Fraction answer = new Fraction(0, 0, 1);
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
            lab.Visible = false;
            answ1.Visible = true;
            answ2.Visible = true;
            answ3.Visible = true;

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
            else if (fraction.Nominator < 0 && fraction.Integer > 0)
            {
                answ1.Text = "+";
                answ2.Text = Convert.ToString(fraction.Nominator * -1);
            }
            else
            {
                answ1.Text = Convert.ToString(fraction.Integer);
                answ2.Text = Convert.ToString(fraction.Nominator);
            }
            answ3.Text = Convert.ToString(fraction.Denominator);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab.Visible = true;
            answ1.Visible = false;
            answ2.Visible = false;
            answ3.Visible = false;

            NewArguments();
            ReadValues();
            int mode = Fraction.Comparison(fraction1, fraction2);
            if (mode == 1)
            {
                lab.Text = "Первая дробь больше";
            }
            else if (mode == 2)
            {
                lab.Text = "Вторая дробь больше";
            }
            else if (mode == 0)
            {
                lab.Text = "Дроби равны";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Value = 0;
            num2.Value = 0;
            num3.Value = 1;
            num4.Value = 0;
            num5.Value = 0;
            num6.Value = 1;
            answ1.Text = "";
            answ2.Text = "";
            answ3.Text = "";
        }

        private void Just_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
