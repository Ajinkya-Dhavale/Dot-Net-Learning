using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double t = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(price.Text == "" || discount.Text == "")
            {
                MessageBox.Show("Please enter a price and discount");
            }
            else
            {
                double p = Convert.ToDouble(price.Text);
                double d = Convert.ToDouble(discount.Text);
                double total1 = p - (p * d / 100);
                list.Items.Add("Price: " + p + " Discount: " + d + " Total: " + total1);
                t += total1;
                totalPrice.Text = t.ToString();
                price.Text = "";
                discount.Text = "";
            }
        }
    }
}
