using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++) Console.WriteLine(backwards($"Albin:{i + 1}"));
        }
        static string backwards(string a)
        {
            char[] cArray = a.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }
    }
}
