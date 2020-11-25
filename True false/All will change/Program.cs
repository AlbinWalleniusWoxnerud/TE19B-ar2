using System;

namespace All_will_change
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 5 };
            int amountmax = 0;
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
                if (amount == amountmax) Console.WriteLine(array[i]);
            }
            
        }
    }
}
