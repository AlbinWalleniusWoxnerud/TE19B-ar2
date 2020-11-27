using System;

namespace _6._29
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Tri(int.Parse(Console.ReadLine()));
        }
        static void Tri(int a)
        {
            int goup = 1;
            for (int j = 0; j < a; j++)
            {

                for (int k = 0; k < a - 1 - j; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < goup; k++)
                {
                    Console.Write("*");
                }
                goup = goup + 2;
                for (int k = 0; k < a - 1 - j; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
