using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public static Calculator1 calc;
        double mem =0;
       
          public Calculator()
        {
            InitializeComponent();
            calc = new Calculator1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void number_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Display.Text == "0")
            {
                Display.Text = btn.Text ;
            }
            else
            {
                Display.Text += btn.Text;
            }
        }

        private void C(object sender, EventArgs e)
        {
            Display.Text = "0";
            calc.FirstNumber = 0;
            calc.SecondNumber = 0;
            calc.result = 0;
            calc.operation = " ";

        }

        private void CE(object sender, EventArgs e)
        {
            Display.Text = " ";
            calc.SecondNumber = 0;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(Display.Text);
            //calc.FirstNumber += calc.FirstNumber;
            //calc.FirstNumber += calc.FirstNumbe;
            calc.operation = btn.Text;
            Display.Text = "";

           
           
        }

        private void root(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(Display.Text);
            Display.Text = (Math.Sqrt(calc.FirstNumber)).ToString();

        }

        private void negative(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(Display.Text);
            Display.Text = Convert.ToString(calc.FirstNumber * (-1));
        }

        private void percent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //calc.saveFirstNumber(Display.Text);
            calc.saveSecondNumber(Display.Text);
            Display.Text = Convert.ToString(calc.FirstNumber * calc.SecondNumber / 100);
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.saveSecondNumber(Display.Text);
            calc.calculate();
            if (calc.result == calc.FirstNumber / 0)
            {
                Display.Text = "Деление на ноль невозможно";
                

            }
            else
            {
                Display.Text = calc.result.ToString();
                calc.FirstNumber = double.Parse(Display.Text);
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
                Display.Text += btn.Text;
            
            }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(Display.Text);
            if (calc.FirstNumber == 0)
            {
                Display.Text = "Деление на ноль невозможно";
            }
            else
            {
                Display.Text = Convert.ToString(1 / calc.FirstNumber);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {    int a;
            a = int.Parse(Display.Text);
            Button btn = sender as Button;
            if (Display.Text!="" && a%10!=a)
            {
                Display.Text = calc.Back(Display.Text);
            }
            else if (a%10==a) 
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text = "0";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Display.Text == "0")
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text += btn.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void memory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "MS":
                    mem = double.Parse(Display.Text);
                    Display.Text = "";
                    break;
                case "M+":
                    mem = mem + double.Parse(Display.Text);
                    break;
                case "M-":
                    mem = mem - double.Parse(Display.Text);
                    break;
                case "MR":
                    Display.Text = mem.ToString();
                    break;
                case "MC":
                    mem = 0;
                    Display.Text = "0";
                    break;

            }

        }
    }
    }

