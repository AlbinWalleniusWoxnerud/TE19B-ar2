using System;

namespace Exempel_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c = 500;
            double d = 1;
            double e = 300;
            double f;
            string msg;

            Console.Write("1 ");
            a = double.Parse(Console.ReadLine());

            Console.Write("2 ");
            b = double.Parse(Console.ReadLine());

            f = e + (d * a) + (c * b);

            msg = " " + f;


            Console.WriteLine(msg);
        }
    }
}
