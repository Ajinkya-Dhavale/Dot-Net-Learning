using System;

// Interface Definition
public interface IPerson
{
    void ShowDetails();
}

// Base Class - Person
public class Person : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Public Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual Method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Interface Method Implementation
    public void ShowDetails()
    {
        Console.WriteLine("Person Details Displayed.");
    }
}

// Derived Class - Employee
public class Employee : Person
{
    public int EmployeeId { get; set; }
    public string Department { get; set; }

    // Public Constructor
    public Employee(string name, int age, int employeeId, string department) : base(name, age)
    {
        EmployeeId = employeeId;
        Department = department;
    }

    // Overriding Method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
        base.DisplayInfo();
    }
}

// Static Class with Static Constructor
public static class Company
{
    public static string CompanyName { get; }

    // Static Constructor
    static Company()
    {
        CompanyName = "Tech Solutions Ltd";
        Console.WriteLine("Static Constructor: Company Initialized.");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Console.WriteLine($"Welcome to {Company.CompanyName}");

        // Person Object
        Person person = new Person("John", 30);
        person.DisplayInfo();
        person.ShowDetails();

        // Employee Object
        Employee employee = new Employee("Alice", 28, 1001, "HR");
        employee.DisplayInfo();
        employee.ShowDetails();

        // Demonstrating Polymorphism
        Person empAsPerson = new Employee("Bob", 35, 1002, "IT");
        empAsPerson.DisplayInfo();
    }
}
 