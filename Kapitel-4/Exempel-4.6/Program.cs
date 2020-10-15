using System;

namespace Exempel_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1;

            Console.Write("Do: ");
            w1 = Console.ReadLine();

            for (int i = 0; i < w1.Length; i++)
            {
                Console.WriteLine(w1[i]);
            }
        }
    }
}
