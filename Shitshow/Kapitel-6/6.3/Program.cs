using System;

namespace _6._3
{
    class Program
    {
        // 6.4
        static void Main(string[] args)
        {
            draw(int.Parse(Console.ReadLine()));
        }
        static void draw(int a)
        {
            for (int i = 1; i < a + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
