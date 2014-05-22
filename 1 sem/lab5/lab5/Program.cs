using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int i = 0;
            int j = 1;
            int k = 0;
            int l = 1;
            Console.WriteLine("Введите порядок матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            a[0, 0] = 1;
            for (int count = 0; count <= n - 1; count++)
            {
                for (k = i, l = j; k < n; k++, l--)
                {
                    a[k, l] = number;
                    number++;
                    if (l - 1 < 0 || k + 1 == n) break;
                }
                if (i != n) { i = k + 1; j = 0; }
                if (i == n) { j = l + 1; i = n - 1; }

                for (k = i, l = j; l < n; k--, l++)
                {
                    a[k, l] = number;
                    number++;
                    if (k - 1 < 0 || l + 1 == n) break;
                }
                if (l != n - 1) { i = 0; j = l + 1; }
                if (l + 1 == n) { i = k + 1; j = n - 1; }
                if (k == n - 1) { j = n - 1; i = l + 1; }
            }
            for (int c = 0; c < n; c++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(a[c, b] + "\t");
                }
                Console.Write("\n\n");
            } 
            Console.ReadLine();
        }
    }
}
