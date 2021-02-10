using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Project_2
{
    class Program
    {
        static int bordsnr = 8;
        static int maxGäster = 8;
        static int fileSlots = 5;
        static List<string> tempinfo = new List<string>();
        static string path = Directory.GetCurrentDirectory();
        static List<string> files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories).Where(filename => !filename.EndsWith("FileListAbsolute.txt")).ToList();
        static string baseName = "Inga gäster";
        static string lastFileNameSaveFile = "lastSaveFile.csv";
        static string fileName = "";
        static void slee(string inp)
        {
            for (int i = 0; i <= inp.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1);
                Console.Write(inp.Substring(i, 1));
            }
            if (inp.Length <= 10) Thread.Sleep(500);
            Console.WriteLine();
        }
        static void slee1(string inp)
        {
            for (int i = 0; i <= inp.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1);
                Console.Write(inp.Substring(i, 1));
            }
            if (inp.Length <= 10) Thread.Sleep(500);
        }
        static void Main()
        {
            slee("Detta är Centralrestaurangens bordshanterare");

            if (files.Count > 0)
            {
                Console.WriteLine();
                slee("Bordsinformation kan läsas in från fil");
                bool choise1 = true;
                while (choise1)
                {
                    slee("Vill du läsa in en fil? J/N");
                    string a = Console.ReadLine().ToLower();
                    if (a == "n") { slee("Ny information skapades"); choise1 = false; empty(); }
                    if (a == "j")
                    {
                        if (files.Count < 2)
                        {
                            fileName = "bord.txt";
                            string[] tempFileNameArray = new string[1];
                            tempFileNameArray[0] = fileName;
                            File.WriteAllLines(lastFileNameSaveFile, tempFileNameArray);

                            fileName = File.ReadAllText(lastFileNameSaveFile).Trim();
                            tempinfo = File.ReadAllLines(fileName).ToList();
                            fileCheck();
                            choise();
                        }
                        else
                        {
                            choise1 = false;
                            useLast();
                            check();
                        }
                    }
                }
            }
            else
            {
                slee("Filer med bordsinformation hittades ej, ny information skapades");
                empty();
            }
        }

        static void fileCheck()
        {
            string[] getbordinfo = File.ReadAllLines(fileName);
            foreach (string bord in getbordinfo)
            {
                bool isCorrect = true;
                int useless;
                string[] singletableinfo = bord.Split(';');
                for (int i = 0; i < fileSlots; i++)
                {
                    if (i == 2)
                    {
                        continue;
                    }
                    else isCorrect = int.TryParse(singletableinfo[i], out useless);

                    if (isCorrect == false)
                    {
                        slee("Invalid fileformat, reforming");
                        empty();
                    }
                }
            }
        }

        static void useLast()
        {
            bool correctInput = true;
            while (correctInput)
            {
                slee("Vill du använda den senaste använda filen? (J/N)");
                string inputCheck = Console.ReadLine().ToLower();
                if (inputCheck == "n") correctInput = false;
                if (inputCheck == "j")
                {
                    fileName = File.ReadAllText(lastFileNameSaveFile).Trim();
                    tempinfo = File.ReadAllLines(fileName).ToList();
                    choise();
                }
            }
        }

        static void check()
        {
            int counter = 0;
            Console.WriteLine();
            foreach (string item in files)
            {
                slee($"{counter + 1}. {Path.GetFileNameWithoutExtension(item)}");
                counter++;
            }
            Console.WriteLine();

            bool correctInput2 = true;
            int whichFile = 0;
            while (correctInput2)
            {
                bool nestedCorrectInput = true;
                while (nestedCorrectInput)
                {
                    slee($"Välj vilken av filerna du vill använda: (1-{counter})");
                    nestedCorrectInput = int.TryParse(Console.ReadLine(), out whichFile);
                }
                if (0 < whichFile && whichFile < files.Count) correctInput2 = false;
            }

            fileName = Path.GetFileName(files[whichFile - 1]);

            fileCheck();
            tempinfo = File.ReadAllLines(fileName).ToList();
            choise();
        }

        static void choise()
        {

            bool choise3 = false;
            int a = 0;
            while (!choise3)
            {
                bool choise2 = false;
                while (!choise2)
                {
                    Console.WriteLine();
                    slee("Välj ett alternativ\n1.Visa alla bord\n2.Lägg till / ändra bordsinformation\n3.Nota\n4.Max antal gäster\n5.Markera att ett bord är tomt\n6.Töm alla bord\n7.Sparfiler\n8.Avsluta programmet");
                    choise2 = int.TryParse(Console.ReadLine(), out a);
                }
                if (0 < a && a < 9) choise3 = true;
            }
            switch (a)
            {
                case 1:
                    allabord();
                    break;
                case 2:
                    bordinfo();
                    break;
                case 3:
                    nota();
                    break;
                case 4:
                    maxAntal();
                    break;
                case 5:
                    bordtomt();
                    break;
                case 6:
                    empty();
                    break;
                case 7:
                    save();
                    break;
                case 8:
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void allabord()
        {
            Console.WriteLine();
            string[] getbordinfo = File.ReadAllLines(fileName);
            int guest = 0;
            foreach (string bord in getbordinfo)
            {
                string[] singletableinfo = bord.Split(';');
                guest += int.Parse(singletableinfo[1]);
                if (singletableinfo[2] != baseName)
                {
                    Console.WriteLine($"Bord {singletableinfo[0]} - antal gäster: {singletableinfo[1]} - Namn: { singletableinfo[2]} - Nota: {singletableinfo[3]} kr - Max antal gäster; {singletableinfo[4]}");
                }
                else
                {
                    Console.WriteLine($"Bord {singletableinfo[0]} - inga gäster");
                }
            }
            Console.WriteLine($"Totalt antal gäster: {guest}");
            choise();
        }

        static void bordinfo()
        {

            bool choise3 = false;
            bool choise4 = false;
            int bordNr = 0;
            while (!choise3)
            {
                bool choise2 = false;
                while (!choise2)
                {
                    Console.WriteLine();
                    slee($"Vilket bordsnummer vill du lägga till/ändra informationen för? (1-{bordsnr})");
                    choise2 = int.TryParse(Console.ReadLine(), out bordNr);
                }
                if (0 < bordNr && bordNr <= bordsnr) choise3 = true;
            }
            bordNr -= 1;
            slee("Skriv in bordets namn");
            string namn = Console.ReadLine();

            string[] getBordInfo = File.ReadAllLines(fileName);
            string singleTableInfo = getBordInfo[bordNr];
            string[] singleTable = singleTableInfo.Split(';');
            int maxG = int.Parse(singleTable[4]);
            int nota = int.Parse(singleTable[3]);
            int antalG = 0;
            while (!choise4)
            {
                bool choise5 = false;
                while (!choise5)
                {
                    slee($"Hur många gäster finns vid bordet? (Max {maxG})");
                    choise5 = int.TryParse(Console.ReadLine(), out antalG);
                }
                if (0 < antalG && antalG <= maxG) choise4 = true;
            }
            tempinfo[bordNr] = ($"{bordNr + 1};{antalG};{namn};{nota};{maxG}");
            update();
        }

        static void nota()
        {
            int bordNr = 0;
            int nota = 0;
            bool korrektBord = false;
            while (!korrektBord)
            {
                bool korrektNr = false;
                while (!korrektNr)
                {
                    Console.WriteLine("Vilket bords nota vill du ändra? ");
                    korrektNr = int.TryParse(Console.ReadLine(), out bordNr);
                }
                if (0 < bordNr && bordNr <= bordsnr) korrektBord = true;
            }
            bool korrektNota = false;

            string[] getBordInfoNota = File.ReadAllLines(fileName);
            string singleTableInfoNota = getBordInfoNota[bordNr - 1];
            string[] singleTableNota = singleTableInfoNota.Split(';');
            if (singleTableNota[2] != baseName)
            {
                while (!korrektNota)
                {
                    bool rimligt = false;
                    while (!rimligt)
                    {
                        Console.WriteLine($"Vad ska bord {bordNr} nota vara? (endast heltal)");
                        rimligt = int.TryParse(Console.ReadLine(), out nota);
                    }
                    if (0 <= nota && nota < 50000) korrektNota = true;
                }
                singleTableNota[3] = $"{nota}";
                tempinfo[bordNr] = string.Join(";", singleTableNota);
                update();
            }
            else
            {
                slee($"Det finns inga gäster vid bord {bordNr}.");
            }

        }

        static void maxAntal()
        {
            int bordNr = 0;
            int maxG = 0;
            bool korrektBord = false;
            while (!korrektBord)
            {
                bool korrektNr = false;
                while (!korrektNr)
                {
                    Console.WriteLine("Vilket bords max antal vill du ändra? ");
                    korrektNr = int.TryParse(Console.ReadLine(), out bordNr);
                }
                if (0 < bordNr && bordNr < bordsnr) korrektBord = true;
            }
            bordNr -= 1;
            string[] getBordInfo = File.ReadAllLines(fileName);
            string singleTableInfo = getBordInfo[bordNr];
            string[] singleTable = singleTableInfo.Split(';');

            bool korrektMax = false;
            while (!korrektMax)
            {
                bool korrektAntal = false;
                while (!korrektAntal)
                {
                    Console.WriteLine($"Vad är bord {bordNr + 1}'s max antal gäster? (max 20)");
                    korrektAntal = int.TryParse(Console.ReadLine(), out maxG);
                }
                if (0 < maxG && maxG <= 20) korrektMax = true;
            }
            singleTable[4] = $"{maxG}";
            tempinfo[bordNr] = string.Join(";", singleTable);
            update();
        }

        static void bordtomt()
        {
            bool choise2 = false;

            int a = 0;
            while (!choise2)
            {
                bool choise1 = false;
                while (!choise1)
                {
                    Console.WriteLine();
                    slee("Vilket bordsnummer vill du markera som tomt?");
                    choise1 = int.TryParse(Console.ReadLine(), out a);
                }
                if (0 < a && a < bordsnr) choise2 = true;
            }
            a -= 1;
            tempinfo[a] = ($"{a + 1};0;Inga gäster;0");
            update();
        }

        static void update()
        {
            // files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories).Where(filename => !filename.EndsWith("FileListAbsolute.txt")).ToArray();
            if (bordsnr > tempinfo.Count)
            {
                int runThrough = bordsnr - tempinfo.Count;
                for (int i = 0; i < (runThrough); i++)
                {
                    tempinfo.Add($"{tempinfo.Count + 1};0;Inga gäster;0;{maxGäster}");
                }
            }
            File.WriteAllLines(fileName, tempinfo);
            string[] tempFileNameArray = new string[1];
            tempFileNameArray[0] = fileName;
            File.WriteAllLines(lastFileNameSaveFile, tempFileNameArray);
            choise();
        }

        static void empty()
        {
            tempinfo.Clear();
            for (int i = 0; i < 8; i++)
            {
                tempinfo.Add($"{i + 1};0;Inga gäster;0;{maxGäster}");
            }
            File.WriteAllText(fileName, string.Empty);
            File.WriteAllLines(fileName, tempinfo);
            choise();
        }

        static void save()
        {

            bool choise3 = false;
            int fileNr = 0;
            while (!choise3)
            {
                bool choise2 = false;
                while (!choise2)
                {
                    Console.WriteLine();
                    slee("Välje ett alternativ:\n1.Skapa en ny sparfil\n2.Ändra spar fil (bland redan existerande sparfiler)\n3.Ändra nuvarnde sparfil");
                    choise2 = int.TryParse(Console.ReadLine(), out fileNr);
                }
                if (0 < fileNr && fileNr < 4) choise3 = true;
            }
            switch (fileNr)
            {
                case 1:

                    slee("Vad ska filen heta? ");
                    string localFile = $"{Console.ReadLine()}.txt";
                    fileName = localFile;
                    string localFilePath = $"{path}\\{localFile}";
                    File.Create(localFile).Close();

                    bool choise30 = false;
                    int fileBordNr = 0;
                    while (!choise30)
                    {
                        bool choise2 = false;
                        while (!choise2)
                        {
                            Console.WriteLine();
                            slee("Hur många bord ska filen ha? (max 20)");
                            choise2 = int.TryParse(Console.ReadLine(), out fileBordNr);
                        }
                        if (0 < fileBordNr && fileBordNr <= 20) choise30 = true;
                    }
                    bordsnr = fileBordNr;
                    // tempinfo[tempinfo.Count - 1] = $"{fileBordNr}";
                    update();
                    break;

                case 2:
                    {
                        check();
                        break;
                    }
                case 3:

                    bool choise300 = false;
                    int fileBordNr1 = 0;
                    while (!choise300)
                    {
                        bool choise2 = false;
                        while (!choise2)
                        {
                            Console.WriteLine();
                            slee("Hur många bord ska filen ha? (max 20)");
                            choise2 = int.TryParse(Console.ReadLine(), out fileBordNr1);
                        }
                        if (0 < fileBordNr1 && fileBordNr1 <= 20) choise300 = true;
                    }
                    bordsnr = fileBordNr1;
                    update();
                    break;
            }
        }
    }
}