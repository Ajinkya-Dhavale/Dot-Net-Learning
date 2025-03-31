// a. Write a program to demonstrate LINQ to array.

using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

class LINQDemo
{
    static void Main()
    {
        Question4();
    }

    static void Question1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtering even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        // Filtering odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

        // Finding the sum of all numbers
        int sum = numbers.Sum();
        Console.WriteLine($"Sum of All Numbers: {sum}");

        // Finding the maximum and minimum numbers
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"Maximum Number: {max}, Minimum Number: {min}");

        // Sorting the array in ascending order
        var ascendingOrder = numbers.OrderBy(n => n);
        Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", ascendingOrder));

        // Sorting the array in descending order
        var descendingOrder = numbers.OrderByDescending(n => n);
        Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", descendingOrder));

        // Counting numbers greater than 5
        int countGreaterThanFive = numbers.Count(n => n > 5);
        Console.WriteLine($"Count of Numbers Greater Than 5: {countGreaterThanFive}");

        // Checking if all numbers are positive
        bool allPositive = numbers.All(n => n > 0);
        Console.WriteLine($"Are All Numbers Positive? {allPositive}");

        // Checking if any number is greater than 8
        bool anyGreaterThanEight = numbers.Any(n => n > 8);
        Console.WriteLine($"Is Any Number Greater Than 8? {anyGreaterThanEight}");

        // Selecting numbers multiplied by 2
        var multipliedByTwo = numbers.Select(n => n * 2);
        Console.WriteLine("Numbers Multiplied by 2: " + string.Join(", ", multipliedByTwo));
    }
    static void Question2()
    {
        // Creating XML using LINQ to XML
        XElement employees = new XElement("Employees",
            new XElement("Employee",
                new XAttribute("Id", 1),
                new XElement("Name", "John"),
                new XElement("Department", "HR"),
                new XElement("Salary", 5000)
            ),
            new XElement("Employee",
                new XAttribute("Id", 2),
                new XElement("Name", "Alice"),
                new XElement("Department", "IT"),
                new XElement("Salary", 7000)
            ),
            new XElement("Employee",
                new XAttribute("Id", 3),
                new XElement("Name", "Bob"),
                new XElement("Department", "Finance"),
                new XElement("Salary", 6000)
            )
        );

        Console.WriteLine("\nXML Data:");
        Console.WriteLine(employees);

        // Querying XML using LINQ
        Console.WriteLine("\nEmployees with Salary > 5500:");
        var highSalaryEmployees = from emp in employees.Elements("Employee")
                                  where (int)emp.Element("Salary") > 5500
                                  select emp;

        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"Name: {emp.Element("Name").Value}, Department: {emp.Element("Department").Value}, Salary: {emp.Element("Salary").Value}");
        }
    }

    public static void Question3()
    {
        string connectionString = "Data Source=DESKTOP-AI1AVF7;Initial Catalog=studentDB;Integrated Security=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT ID, Name, Age FROM student";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            var students = from DataRow row in table.Rows
                           where Convert.ToInt32(row["Age"]) >= 20
                           select new
                           {
                               ID = row["ID"],
                               Name = row["Name"],
                               Age = row["Age"]
                           };

            Console.WriteLine("Students older than 20:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ID}: {student.Name} - {student.Age} years old");
            }
        }
    }

    static void Question4()
    {
        // Creating a collection of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John", Department = "IT", Salary = 60000 },
            new Employee { ID = 2, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { ID = 3, Name = "Bob", Department = "Finance", Salary = 70000 },
            new Employee { ID = 4, Name = "Mike", Department = "IT", Salary = 80000 },
            new Employee { ID = 5, Name = "Emma", Department = "HR", Salary = 45000 }
        };

        // 1. Display All Employees
        Console.WriteLine("All Employees:");
        var allEmployees = from emp in employees select emp;
        foreach (var emp in allEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }

        // 2. Employees with Salary greater than 60000
        Console.WriteLine("\nEmployees with Salary > 60000:");
        var highSalaryEmployees = employees.Where(emp => emp.Salary > 60000);
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }

        // 3. Grouping Employees by Department
        Console.WriteLine("\nEmployees Grouped by Department:");
        var groupedByDept = employees.GroupBy(emp => emp.Department);
        foreach (var group in groupedByDept)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Salary}");
            }
        }

        // 4. Calculate Average Salary
        double avgSalary = employees.Average(emp => emp.Salary);
        Console.WriteLine($"\nAverage Salary: ${avgSalary}");

        // 5. Sorting Employees by Salary in Descending Order
        Console.WriteLine("\nEmployees Sorted by Salary (Descending):");
        var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }
    }

}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}