using System;
using System.Collections.Generic;

namespace _7._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar1 = { "a", "b", "b", "c", "hej" };
            string[] ar2 = { "hej", "a", "a", "b", "programmering" };
            foreach (string item in both(ar1, ar2))
            {
                Console.WriteLine(item);
            }
        }
        static string[] both(string[] a, string[] b)
        {
            List<string> nono = new List<string>();
            for (int i = 0; i < a.Length; i++)
            {
                bool tru = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        tru = true;
                        break;
                    }
                }
                if (tru) continue;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i].Contains(b[j]))
                    {
                        nono.Add(b[j]);
                        break;
                    }
                }
            }
            return nono.ToArray();
        }
    }
}