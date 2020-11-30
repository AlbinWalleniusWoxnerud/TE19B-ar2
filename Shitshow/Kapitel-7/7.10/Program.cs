using System;

namespace _7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            col("Hello World!", ConsoleColor.Red);
            Console.WriteLine("hello");
        }
        static void col(string a, ConsoleColor paint)
        {
            ConsoleColor Before = Console.ForegroundColor;
            Console.ForegroundColor = paint;
            Console.WriteLine(a);
            Console.ForegroundColor = Before;
        }
    }
}
