using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,x;
            Console.WriteLine("Введите х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            p = x ;
            for (int i = 1; i < n; i++)
                p = p * (x + i);
            Console.WriteLine("Произведение:{0}",p);
            Console.ReadLine();
        }
    }
}
