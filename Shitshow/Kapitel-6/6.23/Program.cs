using System;

namespace _6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string.");
            Console.Write(lowerUpper(Console.ReadLine()));
        }
        static string lowerUpper(string input)
        {
            string[] separation = input.Split(' ');
            for (int i = 1; i < separation.Length + 1; i++)
            {
                if (i % 2 != 0)
                {
                    separation[i - 1] = separation[i - 1].ToUpper();
                }
                else
                {
                    separation[i - 1] = separation[i - 1].Substring(0, 1).ToUpper + separation[i - 1].Substring(1).ToLower();
                }
            }
            return string.Join(' ', separation);
        }
    }
}
