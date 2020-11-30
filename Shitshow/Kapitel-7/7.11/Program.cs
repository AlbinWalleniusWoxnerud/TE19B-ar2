using System;

namespace _7._11
{
    class Program
    {
        static void Main(string[] args)
        {
            thiss("Hello World!", ConsoleColor.Red, ConsoleColor.Blue);
        }
        static void thiss(string a, ConsoleColor b, ConsoleColor c)
        {
            ConsoleColor temp = Console.ForegroundColor;
            int d = (a.Length / 2);
            Console.ForegroundColor = b;
            for (int i = 0; i < d; i++)
            {
                Console.Write(a[i]);
            }
            Console.ForegroundColor = c;
            for (int i = d; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.ForegroundColor = temp;
        }
    }
}
