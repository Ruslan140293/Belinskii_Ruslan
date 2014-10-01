using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х:");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = (3.0 / 2.0) * x;
            double p = a;
            for (int i = 1; i < k; i++)
            {
                a = a * (((((2 * i) + 3) * i) / ((i + 1) * ((2 * i) + 1))) * x);
                p = p + a;
            }
            Console.WriteLine("Сумма:{0}", p);
            Console.ReadLine();
            for (x = 0.1; x < 3; x += 0.1)
            {
                a = (3.0 / 2.0) * x;
                p = a;
                for (int i = 1; i < k; i++)
                {
                    a = a * (((((2 * i) + 3) * i) / ((i + 1) * ((2 * i) + 1))) * x);
                    p = p + a;

                }
                Console.WriteLine("x={0},s={1}", x, p);
            }
            Console.ReadLine();
        }
    }
}
