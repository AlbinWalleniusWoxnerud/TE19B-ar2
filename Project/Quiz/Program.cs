using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;
            int point = 0;

            while (true)
            {
                Console.WriteLine("x*6=42, What is X? ");
                bool success = int.TryParse(Console.ReadLine(), out i1);
                if (success)
                {
                    if (i1 == 7)
                    {
                        Console.WriteLine($"Ja, 7 * 6 = 42");
                        point++;
                        Console.WriteLine($"Points: {point}");
                        break;
                    }
                    else
                    {
                        int i2 = i1 * 6;
                        Console.WriteLine($"Nej, {i1} * 6 = {i2}");
                    }
                }
                else
                {
                    Console.WriteLine("Write heltal pls; ");
                }
            }

        }
    }
}

