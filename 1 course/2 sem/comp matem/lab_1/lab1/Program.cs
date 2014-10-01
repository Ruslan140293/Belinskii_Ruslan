using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static bool just(int n)
        {
            bool f = false;
            for (int i = 2; i <= (n / 2) + 1; i++)
            {
                if (n % i == 0)
                {
                    f = false;
                    break;
                }
                else
                {

                    f = true;
                }
            }
            if (n == 2)
            {
                f = true;
            }
            return f;
        }
        static void vivod(int[][] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(1, 50);
            Console.WriteLine("Массив А");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int[][] b = new int[n][];
            int k = 0;
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (just(a[i, j]))
                        k++;
                }
                c[i] = k;
                b[i] = new int[k];
                k = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (just(a[i, j]))
                    {
                        b[i][k] = a[i, j];
                        k++;
                    }
                }
                k = 0;
            }
            Console.WriteLine("Массив В");
            vivod(b);
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[n];
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c[i]; j++)
                    if (b[i][j] < x)
                        z++;
                d[i] = z;
                z = 0;
            }
            Console.WriteLine("Массив А");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("Массив В");
            vivod(b);
            Console.WriteLine("Количество");
            for (int i = 0; i < n; i++)
                Console.WriteLine(d[i]);
            Console.ReadLine();
        }
    }
}
