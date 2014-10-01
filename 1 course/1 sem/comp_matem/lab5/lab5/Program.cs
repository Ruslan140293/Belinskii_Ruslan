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
            Console.WriteLine("Введите количество строк:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(-5, 5);//маленькие числа ставил для проверки
            Console.WriteLine("Вы ввели матрицу:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine("\n");
            }
            /* int s = 0;
             for (int i = 0; i < m; i++)
                 for (int j = 0; j < n; j++)
                     s = s + a[i, j];
             Console.WriteLine("Сумма всех элементов матрицы:{0}", s);*/
            int z = 0;// счетчик размера одномерного массива
            for (int i = 0; i < m; i++)
            {
                if (a[i, 0] > a[i, 1])
                    z = z + 1;
            }
            if (z == 0)
            {
                Console.WriteLine("Нет таких строк!!!");
                Console.ReadLine();
                return;
            }
            int[] a1 = new int[z];
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                if (k == z)
                    break;
                if (a[i, 0] > a[i, 1])
                {
                    a1[k] = i;
                    Console.WriteLine("Строка:{0}", a1[k] + 1);
                    k++;
                }
            }
            k = 0;
            int s1 = 0;
            for (int i = a1[k], j = 0; j < n; j++)
            {
                
                s1 = s1 + a[i, j];
                if (j == n-1 && k!=z-1) { k++; i = a1[k]; j = -1; }
                
            }      
            Console.WriteLine("Сумма элементов этих строк:{0}", s1);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = a[i, j] - s1;
            Console.WriteLine("Новая матрица:");
            for (int i = 0; i < m; i++)
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
