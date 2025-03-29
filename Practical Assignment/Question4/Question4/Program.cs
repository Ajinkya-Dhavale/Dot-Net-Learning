using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Menu Driven Calculator =====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Calculate Sum of Digits");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                int choice;
                bool isValid = int.TryParse(Console.ReadLine(), out choice);

                if (!isValid || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    continue;
                }

                if (choice == 6)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                if (choice == 5)
                {
                    Console.Write("Enter a number to find the sum of its digits: ");
                    int number = int.Parse(Console.ReadLine());
                    int sum = CalculateDigitSum(number);
                    Console.WriteLine($"The sum of the digits of {number} is: {sum}");
                    continue;
                }

                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                }
            }
        }

        // Function to calculate the sum of digits
        static int CalculateDigitSum(int num)
        {
            int sum = 0;
            num = Math.Abs(num); // Ensure it's positive for digit calculation

            while (num > 0)
            {
                sum += num % 10; // Get the last digit
                num /= 10;       // Remove the last digit
            }
            return sum;
        }
    }
}
