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
            StreamReader sr = new StreamReader("new.txt");
            StreamWriter sw = new StreamWriter("new2.txt", false);
            int n = Convert.ToInt32(sr.ReadLine());
            Console.WriteLine("Длина " + n);
            string buffer = "";
            buffer = sr.ReadToEnd();
            string[] sep = { " ", "\r", "\n" };
            string[] bufMas = buffer.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string buffer2 = ""; string buffer3 = "";
            int k = 0;
            while (k < bufMas.Length)
            {
                buffer2 = ""; buffer3 = "";
                while (true)
                {
                    buffer2 += bufMas[k] + ' ';
                    if (k >= bufMas.Length - 1) { k++; break; }
                    buffer3 = buffer2 + bufMas[k + 1];
                    if (buffer3.Length <= n) { k++; }
                    else { k++; break; }
                }
                buffer2 = buffer2.Trim(); buffer2 = buffer2.PadLeft(n);
                sw.WriteLine(buffer2);
            }
            sw.Close(); sr.Close();
        }
    }
}
