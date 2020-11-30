using System;

namespace _7._12
{
    class Program
    {
        static void Main(string[] args)
        {
            ne(ConsoleColor.Red, "Denna rad har", " röd text ", " i mitten.");
            ne(ConsoleColor.Blue, "", "Här är texten blå ", "i början.");
            ne(ConsoleColor.Green, "", "Hela denna rad är grön.");
            ne(ConsoleColor.Magenta, "Denna rad är avslutningsvis", " lila.");
        }
        static void ne(ConsoleColor a, string b, string c = "", string d = "")
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.Write(b);
            Console.ForegroundColor = a;
            Console.Write(c);
            Console.ForegroundColor = temp;
            Console.WriteLine(d);
        }
    }
}
