using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bakgrundsfärg terminal
            Console.BackgroundColor = ConsoleColor.Blue;

            // Textfärg terminal
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            Console.WriteLine("Hello World!");
        }
    }
}
