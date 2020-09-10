using System;

namespace Exempel_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int w11;
            int t1;
            int t2;
            int t3;
            string msg;
            string text;

            Console.Write("Gib ");
            text = Console.ReadLine();

            w11 = text.IndexOf("+");
            t1 = int.Parse(text.Substring(0, w11));
            t2 = int.Parse(text.Substring(w11 + 1));

            t3 = t1 + t2;

            msg = "This " + t3;

            Console.WriteLine(msg);
        }
    }
}
