using System;

namespace Exempel_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string w1;
            string w2;
            int w11;
            string msg;

            Console.Write("2 words ");
            text = Console.ReadLine();

            w11 = text.IndexOf(" ");
            w1 = text.Substring(0, w11);
            w2 = text.Substring(w11 + 1);

            msg = w2 + w1;

            Console.WriteLine(msg);
        }
    }
}
