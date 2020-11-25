using System;

namespace Exempel_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            while (answer != "japan")
            {
                Console.WriteLine("Do: ");
                answer = Console.ReadLine();
            }
        }
    }
}
