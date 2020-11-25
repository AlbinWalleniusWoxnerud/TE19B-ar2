using System;

namespace Exempel_2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string com = "It AB";
            double num = 10000;
            string a;
            double b;
            string msg;
            string msg2;
            string msg3;

            Console.Write("Company ");
            a = Console.ReadLine();

            Console.Write("Numbers ");
            b = double.Parse(Console.ReadLine());

            msg = $" {com,-10}{num,10}{num,30}";
            msg2 = $" {com,-10}{num,10}{num,30}";
            msg3 = $" {a,-10}{b,10}{b,30}";

            Console.WriteLine(msg + "\n" + msg2 + "\n" + msg3);
        }
    }
}
