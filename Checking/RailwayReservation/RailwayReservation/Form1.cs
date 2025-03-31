using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservation
{
    public partial class Form1 : Form
    {
        static String ConnectionString = "Data Source=DESKTOP-AI1AVF7;Initial Catalog=Net;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        static int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO railway (id, name, gender, seat_type, [from], [to], [date]) " +
                                                    "VALUES (@id, @name, @gender, @seat_type, @from, @to, @date)", conn);

                    cmd.Parameters.AddWithValue("@id", count);
                    cmd.Parameters.AddWithValue("@name", name.Text);

                    // Gender Selection
                    if (radioButton1.Checked)
                        cmd.Parameters.AddWithValue("@gender", "Male");
                    else if (radioButton2.Checked)
                        cmd.Parameters.AddWithValue("@gender", "Female");
                    else
                        cmd.Parameters.AddWithValue("@gender", "Other");

                    // Other Parameters
                    cmd.Parameters.AddWithValue("@seat_type", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@from", from.Text);
                    cmd.Parameters.AddWithValue("@to", to.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    count++; // Increment count after successful insertion
                    MessageBox.Show("Reservation saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            MessageBox.Show(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
