using System;

namespace Uppgift_7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "first", "second", "third", "fourth", "fifth", "sixth" };

            rev(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void rev(string[] cod)
        {
            int hef = cod.Length / 2;
            for (int i = 0; i < hef; i++)
            {
                string temp = cod[i];
                cod[i] = cod[cod.Length - 1 - i];
                cod[cod.Length - 1 - i] = temp;
            }
        }
    }
}