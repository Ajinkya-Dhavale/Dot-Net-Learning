using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOperations;


namespace Question2
{
    public delegate void Mydelegrate(String msg);

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


        static void Main(string[] args)
        {
            //Mydelegrate mydelegrate = new Mydelegrate(msg);
            ////mydelegrate("Ajinkya");
            //Mydelegrate mydelegrate1 = new Mydelegrate(msg1);
            ////mydelegrate1("Dhavale");

            //Mydelegrate both = mydelegrate + mydelegrate1;
            //both("Ajinkya Dhavale");


            //Question 
            Operations operations = new Operations();

            Console.WriteLine("Performing Division: 10 / 0");
            operations.PerformDivision(10, 0);

            int[] array = { 1, 2, 3 };
            Console.WriteLine("Accessing Element at Index 5");
            operations.AccessArrayElement(array, 5);


        }
    }
}
