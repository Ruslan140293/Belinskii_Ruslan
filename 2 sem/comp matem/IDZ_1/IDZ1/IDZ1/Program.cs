using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IDZ1
{
    class Program
    {
        static void vivod(DirectoryInfo dir, DirectoryInfo[] masDir, FileInfo[] af)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(dir);
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (DirectoryInfo folder in masDir)
                Console.WriteLine(folder);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo file in af)
                Console.WriteLine(file);
            Console.WriteLine();
            for (int i = 0; i < masDir.Length; i++)
            {
                dir = masDir[i];
                DirectoryInfo[] Dir = dir.GetDirectories();
                FileInfo[] af2 = dir.GetFiles();
                if (dir.Exists)
                {
                    vivod(dir, Dir, af2);
                }
                else return;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите директорию:");
            string direc = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(direc);
            DirectoryInfo[] masDir = dir.GetDirectories();
            FileInfo[] masFile = dir.GetFiles();
            vivod(dir, masDir, masFile);
            Console.ReadLine();
        }
    }
}
