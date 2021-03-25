using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(square(int.Parse(Console.ReadLine())));
        }
        static int square(int a)
        {
            return (a * a);
        }
    }
}
