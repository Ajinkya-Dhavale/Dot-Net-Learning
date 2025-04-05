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

namespace HospitalOPD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Data Source=DESKTOP-AI1AVF7;Initial Catalog=Net;Integrated Security=True";

            using (SqlConnection connection1 = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("insert into hospital(id,name,mobile,addreess,dob,appointment_date,gender) values(@id,@name,@mobile,@address,@dob,@appointment_@date,@gender)",connection1);
                connection1.Open();

                cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@name",name.Text);
                cmd.Parameters.AddWithValue("@address",address.Text);
                cmd.Parameters.AddWithValue("@mobile", mobile.Text);
                cmd.Parameters.AddWithValue("@dob",dob.Text);
                cmd.Parameters.AddWithValue("@appointment_@date",appointmentDate.Text);
                if(radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Male");
                }
                else if (radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Female");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", "Other");
                }
                cmd.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Appointment Booked");
            }
        }
    }
}
