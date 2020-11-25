using System;

namespace Exempel_2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            string msg;

            Console.Write("P1 ");
            a = double.Parse(Console.ReadLine());

            Console.Write("P2 ");
            b = double.Parse(Console.ReadLine());

            Console.Write("P3 ");
            c = double.Parse(Console.ReadLine());

            d = (a + b + c) / 3;

            msg = " " + d;

            Console.WriteLine(msg);
        }
    }
}
