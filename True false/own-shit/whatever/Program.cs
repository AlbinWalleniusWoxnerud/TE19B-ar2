using System;

namespace whatever
{
    class Program
    {
        static void Main()
        {
            int[,,] array = new int[9, 3, 3];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array[i, j, k] = j * k;
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(array[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
