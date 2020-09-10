using System;

namespace Exempel_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int age2100 = 2100;
            int ageDiff;
            string msg;

            Console.Write("Year? ");
            age = int.Parse(Console.ReadLine());

            ageDiff = age2100 - age;

            msg = "This " + ageDiff;
            Console.WriteLine(msg);
        }
    }
}
