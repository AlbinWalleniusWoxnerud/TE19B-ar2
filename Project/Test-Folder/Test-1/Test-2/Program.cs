using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;

            while (true)
            {
                Console.WriteLine("x*6=42, What is X? ");
                bool success = int.TryParse(Console.ReadLine(), out i1);
                if (success)
                {
                    if (i1 == 7)
                    {
                        Console.WriteLine($"Ja, 7 * 6 = 42");
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
                    Console.WriteLine("Heltal; ");
                }
            }

        }
    }
}