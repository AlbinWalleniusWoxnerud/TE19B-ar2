using System;

namespace Exempel_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            double w1;

            Console.Write("Do: ");
            w1 = int.Parse(Console.ReadLine());

            if (w1 < 18)
            {
                msg = "F";
                Console.WriteLine(msg);
            }
            else if (w1 >= 18 && w1 < 27)
            {
                msg = "E";
                Console.WriteLine(msg);
            }
            else if (w1 >= 27 && w1 < 35)
            {
                msg = "D";
                Console.WriteLine(msg);
            }
            else if (w1 >= 35 && w1 < 46)
            {
                msg = "C";
                Console.WriteLine(msg);
            }
            else if (w1 >= 46 && w1 < 55)
            {
                msg = "B";
                Console.WriteLine(msg);
            }
            else if (w1 >= 55)
            {
                msg = "A";
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
