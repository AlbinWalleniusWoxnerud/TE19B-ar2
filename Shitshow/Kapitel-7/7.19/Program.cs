using System;

namespace _7._19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "hej", "nej", "ja" };
            Console.WriteLine(cont(array, 'a'));
        }
        static bool cont(string[] ar, char a)
        {
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                string temp = ar[i];
                if (temp.Contains(a))
                {
                    count++;
                }
            }
            if (count == ar.Length) return true;
            else return false;
        }
    }
}
