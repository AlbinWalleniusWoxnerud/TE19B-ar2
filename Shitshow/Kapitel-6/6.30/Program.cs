using System;

namespace _6._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(card("5 7 7 5 5"));
        }
        static int card(string a)
        {
            string[] numbers1 = a.Split(" ");
            int[] numbers = new int[numbers1.Length];
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers[i] = int.Parse(numbers1[i]);
            }
            int compsum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool dub = false;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        dub = true;
                        break;
                    }
                }
                if (dub) continue;

                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j]) count++;
                }
                int sum = numbers[i];
                for (int j = 0; j < count - 1; j++)
                {
                    sum *= numbers[i];
                }
                compsum += sum;
            }
            return compsum;
        }
    }
}
