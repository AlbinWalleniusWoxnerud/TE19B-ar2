using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\TE19B-ar2\Shitshow\Project\file-folder\f\";
            string path1 = @"D:\TE19B-ar2\Shitshow\Project\file-folder\f\f1\";
            string path2 = @"D:\TE19B-ar2\Shitshow\Project\file-folder\f\f1\f1-2\f1-3\f1-4\";
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (string item in dirs)
            {
                // Console.WriteLine(item);
            }

            Console.WriteLine();
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string item in files)
            {
                // Console.WriteLine(item);
                // Console.WriteLine(Path.GetFullPath(item));
                Console.WriteLine(Path.GetFileName(item));
                // Console.WriteLine(Path.GetDirectoryName(item));
                Console.WriteLine(Path.GetFileNameWithoutExtension(item));
                // var info = new FileInfo(item);
                // Console.WriteLine($"{Path.GetFileName(item)}: {info.Length} bytes");
            }
            // bool directoryExist = Directory.Exists(path2);
            // if (directoryExist)
            // {
            //     Console.WriteLine("Dir exists");
            // }
            // else
            // {
            //     Console.WriteLine("Doesn't exist");
            //     Directory.CreateDirectory(path2);
            // }

            string[] files2 = Directory.GetFiles(path);
            string destinationFolder = path1;
            // foreach (string item in files2)
            // {
            //     // Console.WriteLine(item);
            //     File.Copy(item, $"{destinationFolder}{ Path.GetFileName(item) }", true);
            // }

            // for (int i = 0; i < files2.Length; i++)
            // {
            //     File.Copy(files2[i], $"{destinationFolder}{ i }.txt", false);
            // }

            // foreach (string item in files2)
            // {
            //     // Console.WriteLine(item);
            //     File.Move(item, $"{destinationFolder}{ Path.GetFileName(item) }", true);
            // }

            foreach (string item in files)
            {
                // Console.WriteLine(item);
                // Console.WriteLine(Path.GetFullPath(item));
                // Console.WriteLine(Path.GetFileName(item));
                // Console.WriteLine(Path.GetDirectoryName(item));
                // Console.WriteLine(Path.GetFileNameWithoutExtension(item));
                // var info = new FileInfo(item);
                // Console.WriteLine($"{Path.GetFileName(item)}: {info.Length} bytes");
            }
        }
    }
}
