using System;

namespace Shit
{
    class Program
    {
        static void Main()
        {

            int[] numbers = { 5, 2, 1, 3, 4, 11, 22423 };
            for (int i = 0; i < numbers.Length; i++)
            {
                int bigger = 0;
                int smaller = 0;
                for (int a = 0; a < numbers.Length; a++) if (numbers[i] < numbers[a]) bigger++; else if (numbers[i] > numbers[a]) smaller++;
                if (smaller == bigger && smaller != 0 && bigger != 0) Console.WriteLine($"Median: {numbers[i]}");
            }

        }
    }
}