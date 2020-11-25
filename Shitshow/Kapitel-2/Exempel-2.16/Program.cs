using System;

namespace Exempel_2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            int o1;
            int o2;
            int o3;
            string w1;
            string w2;
            string w3;
            string full;
            string dot = ".";

            Console.Write("Gib 3 words: ");
            full = Console.ReadLine();

            o1 = full.IndexOf(" ");
            w1 = full.Substring(0, o1);

            o1 = o1 + 1;
            o2 = full.IndexOf(" ", o1);
            w2 = full.Substring(o1, o2 - o1);

            o2 = o2 + 1;
            o3 = full.IndexOf(".", o2);
            if (o3 == -1)
            {
                o3 = full.Length;
                dot = "";
            }
            w3 = full.Substring(o2, o3 - o2);

            msg = $"{w3} {w2} {w1}{dot}";

            Console.WriteLine(msg);
        }
    }
}
