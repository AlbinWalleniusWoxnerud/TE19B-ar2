using System;

namespace Exempel_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string ab;
            string msg;
            int c;

            Console.Write("Name? ");
            ab = Console.ReadLine();

            c = ab.IndexOf(" ");
            a = ab.Substring(0, c);
            b = ab.Substring(c + 1);

            msg = $"This: {a} {b}";

            Console.WriteLine(msg);
        }
    }
}
