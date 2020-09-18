using System;

namespace FizzBang
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int v1;
            int v2;

            for (i = 1; i <= 1000; i++)
            {
                v1 = i % 3;
                v2 = i % 5;

                if (v1 == 0 && v2 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (v1 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (v2 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
