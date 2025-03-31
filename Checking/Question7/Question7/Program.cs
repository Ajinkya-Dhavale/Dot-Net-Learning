using System;
using System.Data.SqlClient;
using System.Threading;

namespace ADOCRUD
{
    class Program
    {
        //static string connectionString = "Server=MSCCS05;Database=studentDB;Integrated Security=True;";
        static string connectionString = "Server=DESKTOP-AI1AVF7;Database=studentDB;Integrated Security=True;";


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- ADO.NET CRUD Operations ---");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Read Data");
                Console.WriteLine("3. Update Data");
                Console.WriteLine("4. Delete Data");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertData();
                        break;
                    case 2:
                        ReadData();
                        break;
                    case 3:
                        UpdateData();
                        break;
                    case 4:
                        DeleteData();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        public static int count = 8 ;
        static void InsertData()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            using(SqlConnection conn=new SqlConnection(connectionString)) {
                count++;
                String query = "Insert into student(ID,Name, Age) values(@id,@name,@age)";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("ID", count);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@age", age);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void ReadData()
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from student", connection);
                    connection.Open();
                    SqlDataReader reader= cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.Write("Id : " + reader["ID"]);
                        Console.Write("\tName : " + reader["Name"]);
                        Console.WriteLine("\tAge : " + reader["Age"]);
                }
                }
        }

        static void UpdateData()
        {
            Console.Write("Enter Student ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter New Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE student SET Name = @Name, Age = @Age WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Data Updated Successfully!" : "Update Failed!");
            }
        }

        static void DeleteData()
        {
            Console.Write("Enter Student ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM student WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Data Deleted Successfully!" : "Deletion Failed!");
            }
        }
    }
}