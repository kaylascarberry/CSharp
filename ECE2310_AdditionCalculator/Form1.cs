using System;
using System.Linq.Expressions;

namespace ECE2310_AdditionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            double X, Y, Sum;
            string str_X = txtX.Text;
            string str_Y = txtY.Text;
            X = Convert.ToDouble(str_X);
            Y = Convert.ToDouble(str_Y);
            Sum = X + Y;
            txtSum.Text = Sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0;
            string str_Sum = txtSum.Text;
            string[] num = str_Sum.Split('+');
            foreach (string s in num)
            {
                double parsedNum;
                if (double.TryParse(s, out parsedNum))
                {
                    result += parsedNum;
                    txtStr.Text = result.ToString();
                }
                else
                {
                    txtStr.Text = "Invalid";
                }

            }
        }
        //subtract
        private void button3_Click(object sender, EventArgs e)
        {
            double X, Y, Diff;
            string str_X = txtX.Text;
            string str_Y = txtY.Text;
            X = Convert.ToDouble(str_X);
            Y = Convert.ToDouble(str_Y);
            Diff = X - Y;
            txtSum.Text = Diff.ToString();
        }

        //multiply
        private void button4_Click(object sender, EventArgs e)
        {
            double X, Y, Mult;
            string str_X = txtX.Text;
            string str_Y = txtY.Text;
            X = Convert.ToDouble(str_X);
            Y = Convert.ToDouble(str_Y);
            Mult = X * Y;
            txtSum.Text = Mult.ToString();
        }

        //divide
        private void button5_Click(object sender, EventArgs e)
        {
            double X, Y, Div;
            string str_X = txtX.Text;
            string str_Y = txtY.Text;
            X = Convert.ToDouble(str_X);
            Y = Convert.ToDouble(str_Y);
            Div = X / Y;
            txtSum.Text = Div.ToString();
        }

        //modulus
        private void button6_Click(object sender, EventArgs e)
        {
            double X, Y, Mod;
            string str_X = txtX.Text;
            string str_Y = txtY.Text;
            X = Convert.ToDouble(str_X);
            Y = Convert.ToDouble(str_Y);
            Mod = X % Y;
            txtSum.Text = Mod.ToString();
        }

        //clear button
        private void button7_Click(object sender, EventArgs e)
        {
            txtX.Text = String.Empty;
            txtY.Text = String.Empty;
            txtSum.Text = String.Empty;
        }
    }
}
