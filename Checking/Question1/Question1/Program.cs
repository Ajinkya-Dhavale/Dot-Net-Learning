using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        public static void Question1a()
        {
            Console.Write("Enter Any String  : ");
            String input = Console.ReadLine();
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string shuffledString = lastChar + input.Substring(1, input.Length - 2) + firstChar;
            Console.WriteLine($"Shuffled String: {shuffledString}");
        }

        public static void Question1b()
        {
            Console.Write("Enter Any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(number !=0)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine("Sum Of All the Digit : "+sum);

        }

        public static bool palimdrome(String number)
        {
            int i = 0;
            int j=number.Length-1;

            while(i<j)
            {
                if (number[i]!=number[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public static bool palimdromeRecurssion(String number, int i,int j)
        {
            if(i>=j)
            {
                return true;
            }
            if (number[i] != number[j])
            {
                return false;
            }
            return palimdromeRecurssion(number,i+1,j-1);
        }

        public static void Question2a()
        {
            Console.Write("Enter Any Number : ");
            String number = Console.ReadLine();

            int i = 0;
            int j=number.Length-1;
            if (palimdromeRecurssion(number,i,j))
            {
                Console.WriteLine("Given is palimdrome");
            }
            else {
                Console.WriteLine("Given is not palimdrome");
            }
        }

        public static void Question2b()
        {
            Console.Write("Enter Any Number : ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArgumentException("Number is Negative");
                }
                Console.WriteLine("Square Root  : "+Math.Sqrt(n));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }


        static void Main(string[] args)
        {
            //Question1a();
            //Question1b();
            //Question2a();
            Question2b();
        }
    }
}
