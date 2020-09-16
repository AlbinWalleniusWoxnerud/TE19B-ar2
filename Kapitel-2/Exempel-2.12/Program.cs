using System;

namespace Exempel_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            string msg;

            Console.Write("Jump 1 ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Jump 2 ");
            b = double.Parse(Console.ReadLine());

            c = b - a;

            msg = "1) " + a + "    2) " + b + "  3) " + c;


            Console.WriteLine(msg);
        }
    }
}
