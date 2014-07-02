using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5v3z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядок матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(-50, 50);
            Console.WriteLine("Вы ввели матрицу:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine("\n");
            }
            int sum = 0;
            for (int i = 0; i < n; i += 2)
                for (int j = 0; j < n; j++)
                    if (a[i, j] > 0)
                        sum = sum + a[i, j];
            Console.WriteLine("Сумма положительных элементов нечетных строк:{0}",sum);
            for (int i = 1; i < n; i += 2)
                a[n - 1,i] = sum;
            Console.WriteLine("Матрица с заменой:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine("\n");
            }
                Console.ReadLine();
        }
    }
}
