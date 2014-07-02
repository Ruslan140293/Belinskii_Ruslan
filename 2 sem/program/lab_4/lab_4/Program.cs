using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fl = true; bool fl2 = true;
            FileInfo f = new FileInfo("file1.txt");
            if (!File.Exists("file1.txt"))
            {
                StreamWriter potok = new StreamWriter("file1.txt", true);
                potok.Close();
            }
            BinaryWriter bwf = new BinaryWriter(f.OpenWrite());
            string answer = "";
            String buf = "";
            string answer2 = "";
            string prov = "проводник";
            string polu = "полупроводник";
            string izo = "изолятор";
            while (fl)
            {
                Console.WriteLine("Введите название:");
                buf = Console.ReadLine() + "\t";
                Console.WriteLine("Введите удельный вес:");
                buf += Console.ReadLine() + "\t";
                while (fl2)
                {
                    Console.WriteLine("Нажмите 1 для проводник\nНажмите 2 для полупроводник\nНажмите 3 для изолятор");
                    answer2 = Console.ReadLine();
                    answer2 = answer2.Trim();
                    switch (Convert.ToChar(answer2))
                    {
                        case '1':
                            buf += prov + "\n";
                            bwf.Write(buf);
                            fl2 = false;
                            break;
                        case '2':
                            buf += polu + "\n";
                            bwf.Write(buf);
                            fl2 = false;
                            break;
                        case '3':
                            buf += izo + "\n";
                            bwf.Write(buf);
                            fl2 = false;
                            break;
                        default: fl2 = false;
                            break;
                    }
                }
                fl2 = true;
                Console.WriteLine("еще?");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "yes" || answer == "y" || answer == "д" || answer == "да") fl = true;
                else fl = false;
            }
            bwf.Close();
            char[] sep = { '\t', '\n' };
            buf = "";
            BinaryReader br = new BinaryReader(f.OpenRead());
            string[] Masbuf;
            while (br.PeekChar() != -1)
            {
                buf = br.ReadString();
                Masbuf = buf.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                if (Masbuf[Masbuf.Length - 1].CompareTo(polu) == 0)
                    Console.Write(buf);
            }
            br.Close();
            Console.ReadLine();
        }
    }
}
