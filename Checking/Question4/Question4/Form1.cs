using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4
{
    public partial class Form1 : Form
    {
        Double num1;
        Double ans;
        String op = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button1.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button2.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button3.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button4.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button5.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button6.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button7.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button8.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button9.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + button0.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + buttonDot.Text;
            num1 = Convert.ToDouble(inputBox.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            num1 = 0;
            ans = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ans += num1;
            inputBox.Text = "";
            op = "+";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(inputBox.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Invalid Operation");
                inputBox.Text = "";
                num1 = 0;
                ans = 0;
                return;

            }


            if (op=="+")
            {
                ans += num1;
            }
            else if(op=="-")
            {
                ans -= num1;
            }
            else if (op == "*")
            {
                ans *= num1;
            }
            else if (op == "/")
            {
                ans /= num1;
            }
            else
            {
                MessageBox.Show("Invalid Operation");
                inputBox.Text = "";
                num1 = 0;
                ans = 0;
                return;
            }
            inputBox.Text = ans.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ans -= num1;
            inputBox.Text = "";
            op = "-";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            ans *= num1;
            inputBox.Text = "";
            op = "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            ans /= num1;
            inputBox.Text = "";
            op = "/";
        }
    }
}
