using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            todo.Text = "Ajinkya";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void todobtn_Click(object sender, EventArgs e)
        {
            string inputText = todo.Text.Trim();

            if (!string.IsNullOrEmpty(inputText))
            {
                ListViewItem item = new ListViewItem(inputText);
                listView1.Items.Add(item);
                todo.Clear();
                todo.Focus();
            }
            else
            {
                MessageBox.Show("Please enter some text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
