using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question2
{
    public delegate void Mydelegrate(String msg);

    public class MyCustomException : Exception
    {

        public MyCustomException(string message) : base(message)
        {
        }
    }

    public delegate void OperationDelegate();

    internal class Program
    {
        //public static void msg(String msg)
        //{
        //    Console.WriteLine("Message 1 : "+msg);
        //}
        //public static void msg1(String msg)
        //{
        //    Console.WriteLine("Message 2 : "+msg);
        //}


        public void PerformDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new MyCustomException("Division by zero error.");
            }
            Console.WriteLine("Result: " + (a / b));
        }

        public void AccessArrayElement(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new MyCustomException("Index out of range error.");
            }
            Console.WriteLine("Element: " + array[index]);
        }

        static void ExecuteWithDelegate(OperationDelegate operation)
        {
            try
            {
                operation();
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            //Mydelegrate mydelegrate = new Mydelegrate(msg);
            ////mydelegrate("Ajinkya");
            //Mydelegrate mydelegrate1 = new Mydelegrate(msg1);
            ////mydelegrate1("Dhavale");

            //Mydelegrate both = mydelegrate + mydelegrate1;
            //both("Ajinkya Dhavale");


            //Question 1
            Program operations = new Program();

            ExecuteWithDelegate(() => operations.PerformDivision(10, 1));

            int[] numbers = { 1, 2, 3 };
            ExecuteWithDelegate(() => operations.AccessArrayElement(numbers, 5));


            //Question 2


        }
    }
}
