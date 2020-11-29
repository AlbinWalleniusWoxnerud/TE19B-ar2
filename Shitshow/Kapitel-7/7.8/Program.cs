using System;

namespace _7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 10, 10 };
            Console.WriteLine($"Medel: {medel(array)}");
        }
        static int medel(int[] a)
        {
            int medel = 0;
            for (int i = 0; i < a.Length; i++) medel += a[i];
            medel = medel / a.Length;
            return medel;
        }
    }
}
