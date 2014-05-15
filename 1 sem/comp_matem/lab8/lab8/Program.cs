using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class Program
    {
        static Random r = new Random();
        static int[] postr(int n, int d1, int d2)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = r.Next(d1, d2);
            return a;
        }
        static void vivod(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static int[,] postr(int m, int n, int d1, int d2)
        {
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(d1, d2);
            return a;
        }
        static void vivod(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static int[] zam(int[] a, int[] b, int n1, int k1)
        {
            for (int i = k1, j = 0; j < n1; i++, j++)
            {
                a[i] = b[j];
            }
            return a;
        }
        static int[,] sortSt(int[,] a, int n, int st)
        {
            int max = a[st, 0];
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - j-1; i++)
                    if (a[st, i] < a[st, i + 1])
                    {
                        max = a[st, i];
                        a[st, i] = a[st, i + 1];
                        a[st, i + 1] = max;
                    }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int numberTask;
            bool t = true;
            while (t)
            {
                Console.WriteLine("нажмите 1 для первого задания:");
                Console.WriteLine("Нажмите 2 для второго задания:");
                numberTask = Convert.ToInt32(Console.ReadLine());
                switch (numberTask)
                {
                    case 1:
#region case 1
                        {
                            Console.WriteLine("Введите размерность массива:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (n < 1)
                            {
                                Console.WriteLine("Размерность массива не может быть отрицательной или равняться 0");
                                Console.ReadLine();
                                break;
                            }
                            Console.WriteLine("Ведите нижнию грань для заполнения массива:");
                            int d1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите верхнюю грань для заполнения массива:");
                            int d2 = Convert.ToInt32(Console.ReadLine());
                            if (d1 > d2)
                            {
                                Console.WriteLine("Вы перепутали грани местами!!! Я их поменял!!!");
                                int d0 = d2;
                                d2 = d1;
                                d1 = d0;
                            }
                            int[] a = postr(n, d1, d2);
                            vivod(a, n);
                            Console.WriteLine("Введите размерность массива:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            if (n1 < 1)
                            {
                                Console.WriteLine("Размерность массива не может быть отрицательной или равняться 0");
                                Console.ReadLine();
                                break;
                            }
                            Console.WriteLine("Ведите нижнию грань для заполнения массива:");
                            int d3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите верхнюю грань для заполнения массива:");
                            int d4 = Convert.ToInt32(Console.ReadLine());
                            if (d3 > d4)
                            {
                                Console.WriteLine("Вы перепутали грани местами!!! Я их поменял!!!");
                                int d0 = d4;
                                d4 = d3;
                                d3 = d0;
                            }
                            int[] b = postr(n1, d3, d4);
                            vivod(b, n1);
                            Console.WriteLine("Введите номер элемента с которого будем менять:");
                            int k1 = Convert.ToInt32(Console.ReadLine());
                            k1 = k1 - 1;
                            vivod(a, n);
                            vivod(b, n1);
                            if (k1 < 0)
                            {
                                Console.WriteLine("Номер элемента не может быть отрицательным!!!");
                                Console.ReadLine();
                                break;
                            }
                            if (k1 >= n)
                            {
                                Console.WriteLine("Такого элемента не существует!!!");
                                Console.ReadLine();
                                break;
                            }
                            if (n1 + k1 > n)
                                n1 = n - k1;
                            if (n1 > n)
                                n1 = n - k1;
                            zam(a, b, n1, k1);
                            vivod(a, n);
                            break;
                        }
#endregion
                    case 2:
#region case 2
                        {
                            Console.WriteLine("Введите количество строк:");
                            int m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите количество столбцов:");
                            int n3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ведите нижнию грань для заполнения массива:");
                            int d5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите верхнюю грань для заполнения массива:");
                            int d6 = Convert.ToInt32(Console.ReadLine());
                            if (d5 > d6)
                            {
                                Console.WriteLine("Вы перепутали грани местами!!! Я их поменял!!!");
                                int d0 = d6;
                                d6 = d5;
                                d5 = d0;
                            }
                            int[,] a1 = postr(m, n3, d5, d6);
                            vivod(a1, m, n3);
                            Console.WriteLine("Введите номер строки которую будем сортировать:");
                            int st = Convert.ToInt32(Console.ReadLine());
                            st = st - 1;
                            if ((st < 0) || (st > m - 1))
                            {
                                Console.WriteLine("Нет такой строки!!!");
                                break;
                            }
                            sortSt(a1, n3, st);
                            vivod(a1, m, n3);
                            break;
                        }
#endregion
                    default: return;
                } 
            }
        }
    }
}
