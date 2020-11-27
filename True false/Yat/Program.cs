using System;

namespace Yat
{
    class Program
    {
        static void Main()
        {
            //5.21
            Random ran = new Random();
            int[] dice = new int[5];
            int[] locked = new int[5];
            string[] input1 = new string[5];
            for (int i = 0; i < dice.Length; i++) locked[i] = 0;
            while (true)
            {

                int lock1 = 0;

                for (int i = 0; i < dice.Length; i++)
                {
                    if (locked[i] == 0) dice[i] = ran.Next(1, 7);
                }

                for (int i = 0; i < dice.Length; i++)
                {
                    if (locked[i] != 0)
                    {
                        Console.WriteLine($"Dice {i + 1}: Locked");
                    }

                    if (locked[i] == 0)
                    {
                        Console.WriteLine($"Dice {i + 1}: {dice[i]}");
                    }
                }

                input1 = Console.ReadLine().Split(' ');
                for (int i = 0; i < 5; i++)
                {
                    for (int a = 0; a < input1.Length; a++)
                    {
                        if ((int.Parse(input1[a]) - 1) == i)
                        {
                            locked[i] = dice[i];
                        }
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    if (locked[i] != 0)
                    {
                        lock1++;
                    }
                }

                if (lock1 == locked.Length)
                {
                    break;
                }
            }
            Console.WriteLine("Done: \nDice: ");
            foreach (int p in locked)
            {
                Console.Write($"{p}, ");
            }
        }
    }
}