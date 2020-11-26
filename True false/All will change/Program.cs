using System;

namespace All_will_change
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 1, 2, 2, 2, 3, 3, 2, 2 };
            int amountmax = 0;
            int[] b = new int[array.Length];
            for (int a = 0; a < b.Length; a++) b[a] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int amount = 0;
                for (int j = 0; j < array.Length; j++) if (array[i] == array[j]) amount++;
                if (amountmax < amount) amountmax = amount;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int amount = 0;
                for (int j = 0; j < array.Length; j++) if (array[i] == array[j]) amount++;
                if (amount == amountmax)
                {
                    b[i] = array[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                int yes = 0;
                if (b[i] != 0)
                {
                    for (int j = 0; j < b.Length; j++) if (b[i] == b[j])
                        {
                            yes++;
                            if (yes == 1)
                            {
                                Console.WriteLine(b[i]);
                            }
                        }
                }
            }
        }

    }
}

