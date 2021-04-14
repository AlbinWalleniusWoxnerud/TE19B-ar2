using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace prov_2
{
    class Program
    {
        static string[] filmer = File.ReadAllLines("movies.tsv");
        static List<string> fName = new List<string>();
        static List<string> fMoney = new List<string>();
        static List<string> fYear = new List<string>();
        static void Main()
        {
            Console.WriteLine("Programmet för att söka filmer.");
            foreach (string item in filmer)
            {
                string[] iFilm = item.Split("\t");
                fName.Add($"{iFilm[0]}");
                fMoney.Add($"{iFilm[1]}");
                fYear.Add($"{iFilm[2]}");
            }
            bool runT = true;
            while (runT)
            {
                bool correktInp = false;
                bool correktInp2 = false;
                int val = 0;
                while (!correktInp)
                {
                    correktInp2 = false;
                    while (!correktInp2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1.Visa alla filmer\n2.Sök år\n3.Avsluta\nVälj ett alternativ: ");
                        correktInp2 = int.TryParse(Console.ReadLine(), out val);
                    }
                    if (0 < val && val < 4)
                    {
                        correktInp = true;
                    }
                }
                switch (val)
                {
                    case 1:
                        Console.WriteLine($"Hittade {fName.Count} filmer:");
                        for (int i = 0; i < fName.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {fName[i]} från {fYear[i]}");
                        }
                        break;
                    case 2:

                        bool correktYear = false;
                        int yearVal = 0;
                        while (!correktYear)
                        {
                            bool correktYearInp = false;
                            while (!correktYearInp)
                            {
                                Console.WriteLine("Vilket år söker du? ");
                                correktYearInp = int.TryParse(Console.ReadLine(), out yearVal);
                            }
                            if (1990 < yearVal && yearVal < 2022) correktYear = true;
                            else Console.WriteLine("Icke giltigt år, vg försök igen");
                        }
                        List<string> fYearIndex = new List<string>();

                        int count = 0;
                        string summa = "";
                        string retard = "";
                        int summaT = 0;
                        foreach (var item in filmer)
                        {
                            if (item.Contains($"{yearVal}"))
                            {
                                count++;
                                string[] temp = item.Split('\t');
                                for (int i = 1; i < temp[1].Length - 1; i++)
                                {
                                    if ((temp[1].Substring(i, 1) != ",")) summa += int.Parse((temp[1].Substring(i, 1)));
                                }
                                summaT += int.Parse(summa);
                                summa = "";
                            }
                        }

                        retard += summaT;
                        int l = retard.Length;
                        for (int i = l; i >= 0; i--)
                        {

                        }

                        if (count > 0)
                        {
                            int count2 = 1;
                            Console.WriteLine();
                            Console.WriteLine($"Hittade {count} filmer från {yearVal}");
                            Console.WriteLine($"Total summa intäkter ${summaT}");
                            foreach (var item in filmer)
                            {

                                if (item.Contains($"{yearVal}"))
                                {
                                    string[] temp = item.Split('\t');
                                    Console.WriteLine();
                                    Console.WriteLine($"Summa intäkter: {temp[1]}");
                                    Console.WriteLine($"{count2}: {temp[0]}");
                                    count2++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hittade inga filmer");
                        }
                        break;
                    case 3:
                        runT = false;
                        break;
                }
            }
        }
    }
}
