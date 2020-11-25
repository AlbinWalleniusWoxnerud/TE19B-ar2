using System;

namespace Exempel_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            string w1;

            Console.Write("Do: ");
            w1 = Console.ReadLine();
            w1 = w1.ToLower();

            if (w1 == "stig")
            {
                msg = "yes";
                Console.WriteLine(msg);
            }
            else if (w1 == "abraham")
            {
                msg = "yes no";
                Console.WriteLine(msg);
            }
            else
            {
                msg = "no";
                Console.WriteLine(msg);
            }

        }
    }
}
