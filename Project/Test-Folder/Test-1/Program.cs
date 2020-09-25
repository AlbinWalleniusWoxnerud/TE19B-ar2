using System;
using System.Threading;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
        }
        static void Write()
        {
            for (int i = 0; i <= string.Length; i++)
            {

                Thread.Sleep(200);
                string letter = string.Substring(i, 1);
                Console.Write(letter);
            }
        }

    }
}
