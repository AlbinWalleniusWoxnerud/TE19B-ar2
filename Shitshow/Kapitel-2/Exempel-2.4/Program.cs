using System;

namespace Exempel_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            string message = "";

            Console.Write("Pick a number ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Pick another number ");
            num2 = double.Parse(Console.ReadLine());

            num3 = num1 + num2;
            num4 = num1 * num2;

            message = "You picked the numbers " + num1 + " and " + num2 + ". \n" + num1 + " + " + num2 + " = " + num3 + ". \n" + num1 + " * " + num2 + " = " + num4 + ".";

            Console.WriteLine(message);
        }
    }
}
