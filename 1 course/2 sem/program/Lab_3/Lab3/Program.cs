using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("new.txt");
            Console.WriteLine("Введите слово которое будем искать:");
            string slovo = Console.ReadLine();
            slovo = slovo.Trim(); slovo = slovo.ToLower();
            string buf="",buf2="";
            string[]bufSlov= new string[1];
            while ((buf = sr.ReadLine()) != null)
            {
                buf2 = buf.ToLower();
                bufSlov = buf2.Split(' ');
                for (int i = 0; i < bufSlov.Length; i++)
                {
                    if (bufSlov[i] == slovo)
                    {
                        Console.WriteLine(buf);
                        break;
                    }
                }

            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
