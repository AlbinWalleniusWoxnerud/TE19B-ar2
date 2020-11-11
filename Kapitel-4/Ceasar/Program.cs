using System;

namespace Ceasar
{
    class Program
    {
        static void Main()
        {
            test(Console.ReadLine(), Console.ReadLine());
        }
        static void test(string imput, string test)
        {
            bool fal = false;
            int lol;
            bool succ = int.TryParse(test, out lol);
            while (!succ)
            {
                Console.WriteLine("Wrong, imput number");
                test = Console.ReadLine();
                succ = int.TryParse(test, out lol);
            }
            string e = "";
            int a = imput.Length;
            for (int b = 0; b < a; b++)
            {
                char c = imput[b];
                int ascii = (int)c;
                ascii = ascii + lol;
                if (ascii >= 127 || ascii > 0)
                {
                    string f = "";
                    for (int i = 0; i < a; i++)
                    {
                        f = f + "?";
                    }

                    Console.WriteLine($"Can't convert, result: {f}");
                    fal = true;
                    break;
                }
                Console.Write(ascii + " ");
                char d = (char)ascii;
                e = e + d;
            }
            if (!fal)
            {
                Console.WriteLine();
                Console.WriteLine(e);
            }
        }
    }
}
