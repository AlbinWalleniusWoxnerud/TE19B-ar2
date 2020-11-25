using System;

namespace Exempel_3._2
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

            if (w1 == "usa")
            {
                msg = "yes";
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
