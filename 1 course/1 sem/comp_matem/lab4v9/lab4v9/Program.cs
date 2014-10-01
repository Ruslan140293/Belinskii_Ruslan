using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4v9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-50, 50);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\nВведите число на которое будем делить:");
            int m = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % m == 0)
                    q = q + 1;
            }
            int[] a1 = new int[q];
            Console.WriteLine("Новый масив кратный {0}:", m);
            for (int j = 0, i = 0; i < n; i++)
                if (a[i] % m == 0)
                {
                    a1[j] = a[i];
                    j++;
                }
            for (int j = 0; j < q; j++)
                Console.Write("{0} ", a1[j]);
            Console.ReadLine();
        }
    }
}
