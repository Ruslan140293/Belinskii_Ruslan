using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ost;
            Console.WriteLine("Введите размер последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Размер последовательности должен быть положительным");
                Console.ReadLine();
                return;
            }
            int[] Q = new int[n];
            Console.WriteLine("Введите {0} элементов массива Q", n);
            for (int i = 0; i < n; i++)
                Q[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ost = (Q[i] % 7);
                if (ost == 1 || ost == 2 || ost == 5)
                    Console.WriteLine("Числа с остатком 1,2,5:{0}", ost);
            }
            Console.ReadLine();
        }
    }
}
