using System;

namespace Shit
{
    class Program
    {
        static void Main()
        {
            string w1;

            Console.WriteLine("Do: ");
            w1 = Console.ReadLine();
            bool mt1 = false;

            for (int i = 0; i < w1.Length; i++)
            {
                bool mt2 = false;
                for (int o = 0; o < i; o++)
                {
                    if (w1[i] == w1[o])
                    {
                        mt2 = true;
                        break;
                    }
                }

                if (mt2)
                {
                    continue;
                }

                bool mt3 = false;
                for (int p = i + 1; p < w1.Length; p++)
                {
                    if (w1[i] == w1[p])
                    {
                        mt3 = true;
                        break;
                    }
                }


                if (mt3)
                {
                    int counter = 0;
                    for (int q = 0; q < w1.Length; q++)
                    {
                        if (w1[i] == w1[q])
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"'{w1[i]}' occurs {counter} times");
                    mt1 = true;
                }
            }

            if (mt1 == false)
            {
                Console.WriteLine($"No more than once");
            }
        }
    }
}
