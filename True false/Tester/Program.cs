using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 10, 15 };
            int[] b = a;
            Console.WriteLine($"a[1]: {a[1]}, b[1]: {b[1]}");

            b[1] = 20;
            Console.WriteLine($"a[1]: {a[1]}, b[1]: {b[1]}");

            ÄndraVärde(a);
            Console.WriteLine($"a[1]: {a[1]}, b[1]: {b[1]}");

        }

        static void ÄndraVärde(int[] talArray)
        {
            talArray[1] = 25;
        }
    }
}

