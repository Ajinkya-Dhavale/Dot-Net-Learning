using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todolist.Items.Add(todo.Text);
            todo.Text = "";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(todolist.SelectedIndex != -1)
            {
                todolist.Items.RemoveAt(todolist.SelectedIndex);
            }
        }
    }
}
