using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов масива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(0, 100);
                Console.Write("{0} ",a[i]);
            }
            /*Console.WriteLine("\nВведите число:");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;/
            for (int i = 0; i < n; i++)
                if (b<a[i])
                s = s + a[i];
            Console.WriteLine("Сумма элементов массива значение которых больше {1} ровна:{0}",s,b);*/
            Console.WriteLine("\nВведите номер элемента который будем менять местами с максимальным:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > n)
            {
                Console.WriteLine("Этот элемент находится вне массива");
                Console.ReadLine();
                return;
            }
                int max = a[0];
            int max_i=0;
            for (int i = 1; i < n; i++)
                if (max<a[i])
                {
                    max = a[i];
                    max_i = i;
                }
            int v =a[m-1];
            a[m-1] = a[max_i];
            a[max_i] = v;
            Console.WriteLine("Массив с перестоновкой:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
            Console.ReadLine();
        }
    }
}
