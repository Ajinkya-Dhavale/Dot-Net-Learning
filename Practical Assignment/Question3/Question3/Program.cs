using System;
using System.Linq;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check if it's a palindrome: ");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
