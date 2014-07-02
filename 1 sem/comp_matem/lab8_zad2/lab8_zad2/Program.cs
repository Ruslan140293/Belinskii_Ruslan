using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab8_zad2
{
    class Program
    {
        static int OPR(int[,] a, int n)
        #region OPR
        {
            int answer;
            if (n == 2)
                return answer = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
            if (n == 3)
            {
                return answer = a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * a[2, 1] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] * a[2, 2] - a[0, 0] * a[1, 2] * a[2, 1];
            }
            else
                return answer = a[0, 0];
        }
        #endregion
        static void copyMass(int[,] a, int n, int[,] a1)
        #region copyMass
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a1[i, j] = a[i, j];
        }
        #endregion
        static void zamena(int[,] a1, int[] b, int n, int k)
        #region zamena
        {
            for (int i = 0; i < n; i++)
                a1[i, k] = b[i];
        }
        #endregion
        static void Vivod(int[,] a, int n)
        #region Vivod
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            int n=0;
            bool f = true;
            while (f)
            {
                Console.WriteLine("Введите порядок матрицы:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                { 
                    Console.WriteLine("Размер матрицы не может быть 0!!!");
                    continue;
                }
                if (n < 0)
                {
                    n = Math.Abs(n);
                    Console.WriteLine("Отрицательное значение, возмем по модулю n={0}", n);
                }
                if (n > 3)
                {
                    Console.WriteLine("К сожалению программа не рассчитана на порядок больше 3");
                    continue;
                }
                f = false;
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Введите коэффициенты левой части уравнений");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            Vivod(a, n);
            int[] b = new int[n];
            Console.WriteLine("Введите коэффициенты правой части уравнения:");
            for (int i = 0; i < n; i++)
                b[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");
            double delA = OPR(a, n);
            if (delA == 0)
            {
                Console.WriteLine("\nСистема не имеет решений");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\nОбщий определитель {0}", delA);
            int[,] a1 = new int[n, n];
            copyMass(a, n, a1);
            int k = 0;
            zamena(a1, b, n, k);
            Console.WriteLine();
            Vivod(a1, n);
            double delX1 = OPR(a1, n);
            if (delX1 == 0)
            {
                Console.WriteLine("Система не имеет решений");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Опредилитель X1:{0}", delX1);
            k++;
            copyMass(a, n, a1);
            zamena(a1, b, n, k);
            Console.WriteLine();
            Vivod(a1, n);
            double delX2 = OPR(a1, n);
            if (delX2 == 0)
            {
                Console.WriteLine("Система не имеет решений");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Опредилитель X2:{0}", delX2);
            double x1 = delX1 / delA;
            double x2 = delX2 / delA;
            if (n == 3)
            {
                k++;
                copyMass(a, n, a1);
                zamena(a1, b, n, k);
                double delX3 = OPR(a1, n);
                Console.WriteLine();
                Vivod(a1, n);
                if (delX3 == 0)
                {
                    Console.WriteLine("Система не имеет решений");
                }
                Console.WriteLine("Опредилитель X3:{0}", delX3);
                double x3 = delX3 / delA;
                Console.WriteLine();
                Console.WriteLine("x1={0}, x2={1}, x3={2}", x1, x2, x3);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            Console.ReadLine();
        }
    }
}