using System;

namespace Exempel_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            Console.WriteLine("Program");

            while (ans != 3)
            {

                Console.WriteLine("1 2 3");
                Console.WriteLine("1: This is 1");
                Console.WriteLine("2: This is 2");
                Console.WriteLine("3: This is 3");
                ans = int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    default:
                        Console.WriteLine("Wrong");
                        break;
                }

            }
        }
    }
}