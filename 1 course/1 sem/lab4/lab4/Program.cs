using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядок матрицы:");
            int p = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            int i = 0, j = 0;
            int[,] m = new int[p, p];
            for (i = 0; i < p; i += 2)
            {
                for (j = 0; j < p; j++)
                {
                    m[i, j] = 2 * n - 1;
                    n++;
                }
            }

            n = 1;
            for (i = 1; i < p; i += 2)
            {
                for (j = 0; j < p; j++)
                {
                    m[i, j] = 2 * n;
                    n++;
                }
            }
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < p; j++)
                {
                    Console.Write("{0}\t",m[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
