using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Countries
{
    class Program
    {
        static void slee(string inp)
        {
            for (int i = 0; i <= inp.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1);
                Console.Write(inp.Substring(i, 1));
            }
            if (inp.Length <= 10) Thread.Sleep(500);
            Console.WriteLine();
        }
        static void Main()
        {
            Console.WriteLine();
            slee("Detta är en sökmotor för länder baserade på dess prefix.");
            Console.WriteLine("Program listar land och landskod.");
            string[] info = File.ReadAllLines("land.txt");

            bool go = true;
            while (go)
            {
                slee("Ange sökterm (avsluta med return):");
                string inp = Console.ReadLine().ToLower();
                if (inp == "") break;
                foreach (var item in info)
                {
                    if (item.Contains(inp))
                    {
                        string[] temp = item.Split(',');
                        Console.WriteLine($"{temp[0]} {temp[1]}: {temp[2]}");
                    }
                }
            }
        }
    }
}