using System;

namespace All_will_change
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 1, 3, 3, 7, 4, 3, 6, 2, 2, 2, 3, 3, 2, 2 };
            int amountmax = 0;
            int[] b = new int[array.Length];
            for (int a = 0; a < b.Length; a++) b[a] = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int amount = 0;
                for (int j = 0; j < array.Length; j++) if (array[i] == array[j]) amount++;
                if (amountmax < amount) amountmax = amount;
            }

            for (int i = 0; i < array.Length; i++)
            {
                bool tru = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        tru = true;
                        break;
                    }
                }

                if (tru) continue;

                int amount = 0;
                for (int j = 0; j < array.Length; j++) if (array[i] == array[j]) amount++;
                if (amountmax == amount) Console.WriteLine(array[i]); ;
            }

        }

    }
}