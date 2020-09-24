using System;

namespace Exempel_2._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            string w1;
            int o1;
            int o2;
            int o3;
            int o4;
            double n1;
            double n2;
            double n3;
            double n4;
            double n5;
            double n6;
            double n7;

            Console.Write("Do: ");
            w1 = Console.ReadLine();

            o1 = w1.IndexOf(",");
            n1 = double.Parse(w1.Substring(0, o1));
            o1 = o1 + 1;

            o2 = w1.IndexOf("*");
            n2 = double.Parse(w1.Substring(o1, o2 - o1));
            o2 = o2 + 1;

            o3 = w1.IndexOf(",", o2);
            n3 = double.Parse(w1.Substring(o2, o3 - o2));
            o3 = o3 + 1;

            o4 = w1.Length;
            n4 = double.Parse(w1.Substring(o3, o4 - o3));

            n5 = n1 + (n2 * 0.1);
            n6 = n3 + (n4 * 0.1);
            n7 = n5 * n6;

            msg = $"{n5} \n{n6} \n{n7}";

            Console.WriteLine(msg);
        }
    }
}