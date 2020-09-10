using System;

namespace Exempel_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            string msg;

            Console.Write("Give number ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Give number ");
            n2 = int.Parse(Console.ReadLine());

            n3 = (n1 + n2) / 2;

            msg = "This " + n3;
            Console.WriteLine(msg);
        }
    }
}
