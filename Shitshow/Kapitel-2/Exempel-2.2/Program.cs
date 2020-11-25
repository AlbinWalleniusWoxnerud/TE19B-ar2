using System;

namespace Exempel_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int year = 0;
            int year20 = 0;
            string message = "";

            // Year
            Console.Write("What is the current year? ");
            year = int.Parse(Console.ReadLine());


            year20 = year + 20;


            message = "In 20 years the year will be " + year20 + ".";
            Console.WriteLine(message);
        }
    }
}
