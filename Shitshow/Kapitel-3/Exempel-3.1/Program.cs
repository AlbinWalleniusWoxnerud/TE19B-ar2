using System;

namespace Exempel_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1;

            Console.Write("Do: ");
            w1 = int.Parse(Console.ReadLine());

            if (w1 >= 50)
            {
                Console.WriteLine("May");
            }
            else if (w1 < 50)
            {
                Console.WriteLine("May not");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

