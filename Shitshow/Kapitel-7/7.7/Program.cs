using System;

namespace _7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.5, 2, 3, 4, 5.5 };
            Console.WriteLine($"Ye, {summa(array)}");
        }
        static double summa(double[] inp)
        {
            double a = 0;
            for (int i = 0; i < inp.Length; i++) a += inp[i];
            return a;
        }
    }
}
