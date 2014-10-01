using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            char[] sep = { ' ' };
            string[] sMas = s.Split(sep);
            Console.WriteLine("Количество слов в строке:"+sMas.Length);
            for (int i=0;i<sMas.Length;i++)
                Console.Write(sMas[i].Length+" ");
            Console.ReadLine();
        }
    }
}
