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
            Console.WriteLine("Введите количество дней:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random r1 = new Random();//осадки
            Random r2 = new Random();// температура
            int[] a = new int[n];//Осадки
            Console.WriteLine("Осадки:\n");
            for (int i = 0; i < n; i++)
            {
                a[i] = r1.Next(0, 100);
                Console.Write("{0} ", a[i]);
            }
            int[] a1 = new int[n];
            Console.WriteLine("\nТемпература:\n");
            for (int j = 0; j < n; j++)
            {
                a1[j] = r2.Next(-20, 30);
                Console.Write("{0} ", a1[j]);
            }
            int s = 0;
            int d = 0;
            for (int j = 0; j < n; j++)
            {
                if (a1[j] < 1)
                    s = s + a[j];
                else
                    d = d + a[j];
            }
            Console.WriteLine("\nЗа эти дни в виде снега выпало: {0}, в виде дождя {1}",s,d);
                Console.ReadLine();
        }
    }
}
