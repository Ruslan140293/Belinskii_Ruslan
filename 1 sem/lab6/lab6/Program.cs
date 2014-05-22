using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] A = new double[m, n];
            double[] B = new double[n];
            double[] min = new double[n];
            double[] proiz = new double[m];
            Random r = new Random();
            Random r1 = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = r.Next(-10, 10);
            for (int i = 0; i < n; i++)
                B[i] = r1.Next(-10, 10);
            Console.WriteLine("Матрица А:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.Write('\n');
            }
            Console.WriteLine("Вектор B:");
            for (int i = 0; i < n; i++)
                Console.Write(B[i] + " ");
            int pol = 0;
            int otr = 0;
            double minst = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (A[i, j] < 1)
                        otr = otr + 1;
                    else
                        pol = pol + 1;
            if (pol > otr)
            {
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        proiz[i] = proiz[i] + A[i, j] * B[j];
                Console.WriteLine("\nПроизведение вектора на матрицу:");
                for (int i = 0; i < m; i++)
                    Console.Write(proiz[i] + " ");
            }
            else
            {
                for (int j = 0; j < n; j++)
                {
                    minst = A[0, j];
                    for (int i = 0; i < m; i++)
                    {                
                        if (minst > A[i, j])
                            minst = A[i, j];
                    }
                    min[j] = minst;
                }
                Console.WriteLine("\nВектор из минимальных элементов столбцов:");
                for (int i = 0; i < n; i++)
                    Console.Write(min[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
