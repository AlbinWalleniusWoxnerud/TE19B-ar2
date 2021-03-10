using System;

namespace _6._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator");
            while (true)
            {
                int inputOption = 0;
                bool correktInput = false;

                while (!correktInput)
                {
                    bool correktInputRange = false;
                    while (!correktInputRange)
                    {
                        Console.WriteLine("Välj ett alternativ");
                        Console.WriteLine("1. Addera två tal");
                        Console.WriteLine("2. Subtrahera två tal");
                        Console.WriteLine("3. Multiplicera två tal");
                        Console.WriteLine("4. Dividera två tal");
                        Console.WriteLine("5. Avsluta programmet");
                        correktInputRange = int.TryParse(Console.ReadLine(), out inputOption);
                    }
                    if (0 < inputOption && inputOption < 6) correktInput = true;
                }
                switch (inputOption)
                {
                    case 1: Console.WriteLine(Add(tvåTal())); break;
                    case 2: Console.WriteLine(Sub(tvåTal())); break;
                    case 3: Console.WriteLine(Mult(tvåTal())); break;
                    case 4: Console.WriteLine(Div(tvåTal())); break;
                    case 5: System.Environment.Exit(0); break;
                }
            }
        }
        static int[] tvåTal()
        {
            string tal = "";
            int tempTal = 0;
            for (int i = 0; i < 2; i++)
            {
                bool correktNumber = false;
                while (!correktNumber)
                {
                    Console.WriteLine("Skriv ett tal");
                    correktNumber = int.TryParse(Console.ReadLine(), out tempTal);
                }
                if (i == 1)
                {
                    tal += " ";
                    tal += tempTal;
                }
                else
                {
                    tal += tempTal;
                }
            }
            string[] falseTal = tal.Split(' ');
            int[] trueTal = Array.ConvertAll(falseTal, int.Parse);
            return trueTal;
        }
        static int Add(int[] trueTal)
        {
            return (trueTal[0] + trueTal[1]);
        }
        static int Sub(int[] trueTal)
        {
            return (trueTal[0] - trueTal[1]);
        }
        static int Mult(int[] trueTal)
        {
            return (trueTal[0] * trueTal[1]);
        }
        static int Div(int[] trueTal)
        {
            return (trueTal[0] / trueTal[1]);
        }
    }
}
